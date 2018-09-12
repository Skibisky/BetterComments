using BetterComments.Options;
using Microsoft.VisualStudio.Shell;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace BetterComments
{
    [ProvideOptionPage(typeof(OptionsGeneralPage), "Better Traces", "General", 0, 0, true)]
    [ProvideOptionPage(typeof(OptionsTokensPage), "Better Traces", "Tokens", 0, 0, true)]
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", Vsix.Id, IconResourceID = 400)]
    [Guid(PACKAGE_GUID_STRING)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
                      Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    public sealed class VsPackage : Package
    {
        public const string PACKAGE_GUID_STRING = "DA2981D2-DB2E-4364-A35B-C7596513F3AB";
    }
}