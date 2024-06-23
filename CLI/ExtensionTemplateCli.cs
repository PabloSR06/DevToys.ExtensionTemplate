using DevToys.Api;
using System.ComponentModel.Composition;
using ExtensionTemplate.Helpers;
using ExtensionTemplate.Texts;
using Microsoft.Extensions.Logging;

namespace ExtensionTemplate.CLI;

[Export(typeof(ICommandLineTool))]
[Name("ExtensionName")]
[CommandName(
    Name = "extension-name",
    Alias = "extension-alias",
    ResourceManagerBaseName = "ExtensionTemplate.Texts.ExtensionTemplateText", // The full name (including namespace) of the resource file containing our localized texts
    DescriptionResourceName = nameof(ExtensionTemplateText.Description))]
internal sealed class ExtensionCli : ICommandLineTool
{


    public ValueTask<int> InvokeAsync(ILogger logger, CancellationToken cancellationToken)
    {

        Console.WriteLine(ExtensionTemplateHelper.DoYourThing(ExtensionTemplateText.HelloWorldLabel, logger, cancellationToken));
        return ValueTask.FromResult(0);
    }
}
