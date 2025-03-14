namespace Hexa.NET.ZLib
{
    using HexaGen.Runtime;
    using System.Diagnostics;

    public static class ZLibConfig
    {
        public static bool AotStaticLink;
    }

    public static unsafe partial class ZLib
    {
        static ZLib()
        {
            if (ZLibConfig.AotStaticLink)
            {
                InitApi(new NativeLibraryContext(Process.GetCurrentProcess().MainModule!.BaseAddress));
            }
            else
            {
                InitApi(new NativeLibraryContext(LibraryLoader.LoadLibrary(GetLibraryName, null)));
            }
        }

        public static string GetLibraryName()
        {
            return "zlib";
        }
    }
}
