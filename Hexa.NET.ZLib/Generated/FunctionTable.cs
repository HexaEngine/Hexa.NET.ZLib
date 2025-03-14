// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.ZLib
{
	public unsafe partial class ZLib
	{
		internal static FunctionTable funcTable;

		/// <summary>
		/// Initializes the function table, automatically called. Do not call manually, only after <see cref="FreeApi"/>.
		/// </summary>
		public static void InitApi(INativeContext context)
		{
			funcTable = new FunctionTable(context, 96);
			funcTable.Load(0, "zlibVersion");
			funcTable.Load(1, "deflate");
			funcTable.Load(2, "deflateEnd");
			funcTable.Load(3, "inflate");
			funcTable.Load(4, "inflateEnd");
			funcTable.Load(5, "deflateSetDictionary");
			funcTable.Load(6, "deflateGetDictionary");
			funcTable.Load(7, "deflateCopy");
			funcTable.Load(8, "deflateReset");
			funcTable.Load(9, "deflateParams");
			funcTable.Load(10, "deflateTune");
			funcTable.Load(11, "deflateBound");
			funcTable.Load(12, "deflatePending");
			funcTable.Load(13, "deflatePrime");
			funcTable.Load(14, "deflateSetHeader");
			funcTable.Load(15, "inflateSetDictionary");
			funcTable.Load(16, "inflateGetDictionary");
			funcTable.Load(17, "inflateSync");
			funcTable.Load(18, "inflateCopy");
			funcTable.Load(19, "inflateReset");
			funcTable.Load(20, "inflateReset2");
			funcTable.Load(21, "inflatePrime");
			funcTable.Load(22, "inflateMark");
			funcTable.Load(23, "inflateGetHeader");
			funcTable.Load(24, "inflateBack");
			funcTable.Load(25, "inflateBackEnd");
			funcTable.Load(26, "zlibCompileFlags");
			funcTable.Load(27, "compress");
			funcTable.Load(28, "compress2");
			funcTable.Load(29, "compressBound");
			funcTable.Load(30, "uncompress");
			funcTable.Load(31, "uncompress2");
			funcTable.Load(32, "gzdopen");
			funcTable.Load(33, "gzbuffer");
			funcTable.Load(34, "gzsetparams");
			funcTable.Load(35, "gzread");
			funcTable.Load(36, "gzfread");
			funcTable.Load(37, "gzwrite");
			funcTable.Load(38, "gzfwrite");
			funcTable.Load(39, "gzprintf");
			funcTable.Load(40, "gzputs");
			funcTable.Load(41, "gzgets");
			funcTable.Load(42, "gzputc");
			funcTable.Load(43, "gzgetc");
			funcTable.Load(44, "gzungetc");
			funcTable.Load(45, "gzflush");
			funcTable.Load(46, "gzrewind");
			funcTable.Load(47, "gzeof");
			funcTable.Load(48, "gzdirect");
			funcTable.Load(49, "gzclose");
			funcTable.Load(50, "gzclose_r");
			funcTable.Load(51, "gzclose_w");
			funcTable.Load(52, "gzerror");
			funcTable.Load(53, "gzclearerr");
			funcTable.Load(54, "adler32");
			funcTable.Load(55, "adler32_z");
			funcTable.Load(56, "crc32");
			funcTable.Load(57, "crc32_z");
			funcTable.Load(58, "crc32_combine_op");
			funcTable.Load(59, "deflateInit_");
			funcTable.Load(60, "inflateInit_");
			funcTable.Load(61, "deflateInit2_");
			funcTable.Load(62, "inflateInit2_");
			funcTable.Load(63, "inflateBackInit_");
			funcTable.Load(64, "gzopen");
			funcTable.Load(65, "gzseek");
			funcTable.Load(66, "gztell");
			funcTable.Load(67, "gzoffset");
			funcTable.Load(68, "adler32_combine");
			funcTable.Load(69, "crc32_combine");
			funcTable.Load(70, "crc32_combine_gen");
			funcTable.Load(71, "zError");
			funcTable.Load(72, "inflateSyncPoint");
			funcTable.Load(73, "get_crc_table");
			funcTable.Load(74, "inflateUndermine");
			funcTable.Load(75, "inflateValidate");
			funcTable.Load(76, "inflateCodesUsed");
			funcTable.Load(77, "inflateResetKeep");
			funcTable.Load(78, "deflateResetKeep");
			funcTable.Load(79, "gzopen_w");
			funcTable.Load(80, "zcalloc");
			funcTable.Load(81, "zcfree");
			funcTable.Load(82, "inflate_table");
			funcTable.Load(83, "_tr_init");
			funcTable.Load(84, "_tr_tally");
			funcTable.Load(85, "_tr_flush_block");
			funcTable.Load(86, "_tr_flush_bits");
			funcTable.Load(87, "_tr_align");
			funcTable.Load(88, "_tr_stored_block");
			funcTable.Load(89, "inflate_fast");
			funcTable.Load(90, "gzopen64");
			funcTable.Load(91, "gzseek64");
			funcTable.Load(92, "gztell64");
			funcTable.Load(93, "gzoffset64");
			funcTable.Load(94, "gz_error");
			funcTable.Load(95, "gz_intmax");
		}

		public static void FreeApi()
		{
			funcTable.Free();
		}
	}
}
