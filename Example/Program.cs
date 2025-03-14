// See https://aka.ms/new-console-template for more information
using Hexa.NET.ZLib;
using System.Text;

unsafe
{
    string original = "Hello, this is an example of zlib compression with a C wrapper!";
    byte[] inputData = Encoding.UTF8.GetBytes(original);
    uint inputLen = (uint)inputData.Length;

    byte[] compressedData = new byte[1024];
    uint compressedSize;
    {
        ZStream stream;
        int initResult = ZLib.DeflateInit(&stream, ZLib.Z_DEFAULT_COMPRESSION, ZLib.ZLIB_VERSION, sizeof(ZStream));
        if (initResult != 0)
        {
            Console.WriteLine("DeflateInit failed!");
            return;
        }

        // Set up the ZStream for compression
        fixed (byte* inputPtr = inputData)
        fixed (byte* compressedPtr = compressedData)
        {
            stream.NextIn = inputPtr;
            stream.AvailIn = inputLen;
            stream.NextOut = compressedPtr;
            stream.AvailOut = (uint)compressedData.Length;

            // Perform compression
            int deflateResult = ZLib.Deflate(&stream, ZLib.Z_FINISH);

            if (deflateResult != ZLib.Z_STREAM_END)
            {
                Console.WriteLine("Deflate failed!");
                return;
            }

            // Get the compressed length
            uint compressedLength = stream.TotalOut;

            // Output the compressed data
            Console.WriteLine("Compressed data:");
            for (int i = 0; i < compressedLength; i++)
            {
                Console.Write(compressedData[i] + " ");
            }
            Console.WriteLine();
        }

        ZLib.DeflateEnd(&stream);

        compressedSize = stream.TotalOut;
    }

    byte[] buffer = new byte[1024];

    {
        ZStream stream;
        int initResult = ZLib.InflateInit(&stream, ZLib.ZLIB_VERSION, sizeof(ZStream));
        if (initResult != 0)
        {
            Console.WriteLine("InflateInit failed!");
            return;
        }

        // Set up the ZStream for decompression
        fixed (byte* outputPtr = buffer)
        fixed (byte* compressedPtr = compressedData)
        {
            stream.NextIn = compressedPtr;
            stream.AvailIn = compressedSize;
            stream.NextOut = outputPtr;
            stream.AvailOut = (uint)buffer.Length;

            // Perform decompression
            int deflateResult = ZLib.Inflate(&stream, ZLib.Z_FINISH);

            if (deflateResult != ZLib.Z_STREAM_END)
            {
                Console.WriteLine("Inflate failed!");
                return;
            }

            // Get the decompression length
            uint decompressedLength = stream.TotalOut;

            Console.WriteLine("Decompressed data:");
            Console.WriteLine(Encoding.UTF8.GetString(outputPtr, (int)decompressedLength));
        }

        ZLib.InflateEnd(&stream);
    }
}

