﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Text.Editor;

namespace BetterComments.ItalicComments
{
    internal sealed class CommentFormatter
    {
        private bool italicizing;
        private readonly IClassificationFormatMap formatMap;
        private readonly IClassificationTypeRegistryService typeRegistryService;

        private static readonly List<string> commentTypes = new List<string>()
            {
                "comment",
                "xml doc comment",
                "vb xml doc comment",
                "xml comment",
                "html comment",
                "xaml comment"
            };

        public CommentFormatter(ITextView textView,
                                 IClassificationFormatMap formatMap,
                                 IClassificationTypeRegistryService typeRegistryService)
        {
            textView.GotAggregateFocus += TextView_GotAggregateFocus;

            this.formatMap = formatMap;
            this.typeRegistryService = typeRegistryService;

            FormatComments();
        }

        private void TextView_GotAggregateFocus(object sender, EventArgs e)
        {
            var view = sender as ITextView;
            if (view != null)
                view.GotAggregateFocus -= TextView_GotAggregateFocus;

            // TODO: Deal with this issue gracefully in release mode.
            Debug.Assert(!italicizing, "Can't format comments while the view is getting focus!");

            FormatComments();
        }

        private void FormatComments()
        {
            italicizing = true;

            try
            {
                FormatKnownCommentTypes();
                FormatUnknowCommentsTypes();
            }
            catch (Exception ex)
            {
                //TODO: Handle the exception gracefully in relaese mode.
                Debug.Assert(false, $"Exception while formatting! \n", ex.Message);
            }
            finally
            {
                italicizing = false;
            }
        }

        private void FormatKnownCommentTypes()
        {
            var knowns = commentTypes.Select(type => typeRegistryService.GetClassificationType(type))
                                     .Where(type => type != null);

            foreach (var classificationType in knowns)
                Italicize(classificationType);
        }

        private void FormatUnknowCommentsTypes()
        {
            var unknowns = from type in formatMap.CurrentPriorityOrder.Where(type => type != null)
                           let name = type.Classification.ToLowerInvariant()
                           where !commentTypes.Contains(name) && name.ToLowerInvariant().Contains("comment")
                           select type;

            foreach (var classificationType in unknowns)
                Italicize(classificationType);
        }

        private void Italicize(IClassificationType classificationType)
        {
            var properties = formatMap.GetTextProperties(classificationType);
            var typeface = properties.Typeface;

            if (typeface.Style == FontStyles.Italic)
                return;

            var newTypeface = new Typeface(new FontFamily("Lucida Sans"), FontStyles.Italic, FontWeights.Normal, typeface.Stretch);
            var newproperties = properties.SetTypeface(newTypeface).SetFontRenderingEmSize(properties.FontRenderingEmSize);

            formatMap.SetTextProperties(classificationType, newproperties);
        }
    }
}