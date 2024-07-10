using DevToys.Api;
using System.ComponentModel.Composition;

namespace ExtensionTemplate;

[Export(typeof(IResourceAssemblyIdentifier))]
[Name(nameof(ExtensionTemplateResourceAssemblyIdentifier))]
internal sealed class ExtensionTemplateResourceAssemblyIdentifier : IResourceAssemblyIdentifier
{
    public ValueTask<FontDefinition[]> GetFontDefinitionsAsync()
    {
        throw new NotImplementedException();
    }
}