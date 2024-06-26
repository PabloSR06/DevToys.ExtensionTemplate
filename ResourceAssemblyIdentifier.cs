﻿using DevToys.Api;
using System.ComponentModel.Composition;

namespace ExtensionTemplate;

[Export(typeof(IResourceAssemblyIdentifier))]
[Name(nameof(ResourceAssemblyIdentifier))]
internal sealed class ResourceAssemblyIdentifier : IResourceAssemblyIdentifier
{
    public ValueTask<FontDefinition[]> GetFontDefinitionsAsync()
    {
        throw new NotImplementedException();
    }
}