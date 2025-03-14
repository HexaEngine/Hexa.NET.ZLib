// See https://aka.ms/new-console-template for more information
using HexaGen;
using HexaGen.Core.Mapping;
using HexaGen.Patching;

BatchGenerator batch = new();
batch
    .Setup<CsCodeGenerator>("generator.json")
    .AlterConfig(c =>
    {
        EnumMapping mapping = new("inflate_mode", null, null);
        mapping.ItemMappings.Add(new("COPY_", "Copy_", null, null));
        mapping.ItemMappings.Add(new("LEN_", "Len_", null, null));
        c.EnumMappings.Add(mapping);
    })
    .AddPrePatch(new NamingPatch(["Gz", "Zlib"], NamingPatchOptions.None))
    .Generate("include/main.h", "../../../../Hexa.NET.ZLib/Generated", [.. Directory.GetFiles("include")]);