# Better Comments
**Better Comments** is a Visual Studio extension that gives you the ability to customize the font and opacity of your comments independently of the editor's font settings. 
It also adds four additional comment classifications, each classification with its own customizable foreground. 


<!-- Replace this badge with your own-->
[![Build status](https://ci.appveyor.com/api/projects/status/04caiutue4j1hq9d?svg=true)](https://ci.appveyor.com/project/omsharp/bettercomments)

<!-- Update the VS Gallery link after you upload the VSIX-->
Download this extension from the [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=OmarRwemi.BetterComments).

Download the latest build from [VSIX Gallery](http://vsixgallery.com/extension/BetterComments.Omar%20Rwemi.e985519f-8696-40b7-9400-807054b4ec76/).

---------------------------------------

## Features

- Additional comment classifications. Important, Question, Task, and Crossed. 
- Customizable foreground for each comment classification.
- Customize the font settings and opacity of your comments.
- Works with C#, F#, VB.NET, C/C++, JavaScript, Python, HTML, and XAML.

<br>

### Comment Classifications

- Use '!' for Important.
- Use '?' for Question.
- Use "Todo" (Case ignored) for Task.
- Use 'x', 'X', or double comment for strikethrough (Crossed).


Or you can use your own custom tokens:

![Sample1](screenshots/CustomTokensExample.png)

![Sample1](screenshots/CustomTokensOptionsPage.png)




C#, F#, C/C++, and JavaScript 

![Sample1](screenshots/ClassificationC.png)

VB.NET 

![Sample1](screenshots/ClassificationVB.png)

Python 

![Sample1](screenshots/ClassificationPython.png)

HTML/XAML (**Works only with single-line comments**) 

![Sample1](screenshots/ClassificationMarkup.png)

Multiline delimited comments (**Works only in C#**).

![Sample1](screenshots/ClassificationMultilineCS.png)

Single-line delimited comments (**Works in C#, F#, C/C++, and JavaScript**)

![Sample1](screenshots/ClassificationDelimited.png)

<br>

### Custom Foreground Color for each Classification 

- You can set each comment classification foreground color to whatever you like.

- You can also set a particular comment classification font weight to bold.

   Go to Tools => Options => Fonts and Colors


![Sample1](screenshots/CommentsColors.png)

<br>

### Independent Font Settings

- You can change the comments font settings without affecting the editor's font settings.

   Go to Tools -> Options -> Better Comments -> Font Options

![Options](screenshots/Options.png)

- You can use whatever font you like.

![Options](screenshots/FontSample.png)

- You can offset the comment font size relative to the font size of the editor. Make it larger or smaller.

![Options](screenshots/SizeSample.png)

- You can italicize comments.

![Options](screenshots/ItalicSample.png)

- You can control the comments opacity.

![Options](screenshots/OpacitySample.png)

- You can choose to color the "Todo" keyword only instead of the whole task comment.

![Options](screenshots/HighlightOnlyKeywordSample.png)

- You can choose to underline the important comments 

![Options](screenshots/UnderlineSample.png)


<br>

## Contribute
- Check out the [contribution guidelines](CONTRIBUTING.md)
if you want to contribute to this project.

- See the [changelog](CHANGELOG.md) for changes and roadmap.

<br>

## License
[Apache 2.0](LICENSE)