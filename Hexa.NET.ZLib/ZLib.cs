namespace Hexa.NET.ZLib
{
    public static unsafe partial class ZLib
    {
        static ZLib()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            return "zlib1";
        }
    }
}
