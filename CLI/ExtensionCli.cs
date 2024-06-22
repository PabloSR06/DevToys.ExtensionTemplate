using DevToys.Api;
using System.ComponentModel.Composition;
using Microsoft.Extensions.Logging;
using static DevToys.Api.GUI;

namespace ExtensionTemplate;

[Export(typeof(ICommandLineTool))]
[Name("ExtensionName")]
[CommandName(
    Name = "extension-name",
    Alias = "extension-alias",
    ResourceManagerBaseName = "ExtensionTemplate.Texts.ExtensionText", // The full name (including namespace) of the resource file containing our localized texts
    DescriptionResourceName = nameof(ExtensionText.Description))]
internal sealed class ExtensionCli : ICommandLineTool
{


    public ValueTask<int> InvokeAsync(ILogger logger, CancellationToken cancellationToken)
    {

        Console.WriteLine(ExtensionHelper.DoYourThing(ExtensionText.HelloWorldLabel, logger, cancellationToken));
        return ValueTask.FromResult(0);
    }
}
