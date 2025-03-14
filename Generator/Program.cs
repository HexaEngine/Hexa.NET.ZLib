// See https://aka.ms/new-console-template for more information
using HexaGen;
using HexaGen.Patching;

List<string> headers = ["include/zconf.h", "include/zlib.h"];

BatchGenerator batch = new();
batch
    .Setup<CsCodeGenerator>("generator.json")
    .AddPrePatch(new NamingPatch(["Gz", "Zlib"], NamingPatchOptions.None))
    .Generate(headers, "../../../../Hexa.NET.ZLib/Generated");