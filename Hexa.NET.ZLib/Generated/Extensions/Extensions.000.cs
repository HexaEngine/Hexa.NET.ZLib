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
	public static unsafe partial class Extensions
	{
		/// <summary>
		/// Associate a gzFile with the file descriptor fd.  File descriptors are<br/>
		/// obtained from calls like open, dup, creat, pipe or fileno (if the file has<br/>
		/// been previously opened with fopen).  The mode parameter is as in gzopen.<br/>
		/// The next call of gzclose on the returned gzFile will also close the file<br/>
		/// descriptor fd, just like fclose(fdopen(fd, mode)) closes the file descriptor<br/>
		/// fd.  If you want to keep fd open, use fd = dup(fd_keep); gz = gzdopen(fd,<br/>
		/// mode);.  The duplicated descriptor should be saved to avoid a leak, since<br/>
		/// gzdopen does not close fd if it fails.  If you are using fileno() to get the<br/>
		/// file descriptor from a FILE *, then you will have to use dup() to avoid<br/>
		/// double-close()ing the file descriptor.  Both gzclose() and fclose() will<br/>
		/// close the associated file descriptor, so they need to have different file<br/>
		/// descriptors.<br/>
		/// gzdopen returns NULL if there was insufficient memory to allocate the<br/>
		/// gzFile state, if an invalid mode was specified (an 'r', 'w', or 'a' was not<br/>
		/// provided, or '+' was provided), or if fd is -1.  The file descriptor is not<br/>
		/// used until the next gz* read, write, seek, or close operation, so gzdopen<br/>
		/// will not detect if fd is invalid (unless fd is -1).<br/>
		/// </summary>
		public static int Buffer(this GzFile file, uint size)
		{
			int ret = ZLib.BufferNative(file, size);
			return ret;
		}

		/// <summary>
		/// Set the internal buffer size used by this library's functions for file to<br/>
		/// size.  The default buffer size is 8192 bytes.  This function must be called<br/>
		/// after gzopen() or gzdopen(), and before any other calls that read or write<br/>
		/// the file.  The buffer memory allocation is always deferred to the first read<br/>
		/// or write.  Three times that size in buffer space is allocated.  A larger<br/>
		/// buffer size of, for example, 64K or 128K bytes will noticeably increase the<br/>
		/// speed of decompression (reading).<br/>
		/// The new buffer size also affects the maximum length for gzprintf().<br/>
		/// gzbuffer() returns 0 on success, or -1 on failure, such as being called<br/>
		/// too late.<br/>
		/// </summary>
		public static int Setparams(this GzFile file, int level, int strategy)
		{
			int ret = ZLib.SetparamsNative(file, level, strategy);
			return ret;
		}

		/// <summary>
		/// Dynamically update the compression level and strategy for file.  See the<br/>
		/// description of deflateInit2 for the meaning of these parameters. Previously<br/>
		/// provided data is flushed before applying the parameter changes.<br/>
		/// gzsetparams returns Z_OK if success, Z_STREAM_ERROR if the file was not<br/>
		/// opened for writing, Z_ERRNO if there is an error writing the flushed data,<br/>
		/// or Z_MEM_ERROR if there is a memory allocation error.<br/>
		/// </summary>
		public static int Read(this GzFile file, void* buf, uint len)
		{
			int ret = ZLib.ReadNative(file, buf, len);
			return ret;
		}

		/// <summary>
		/// Read and decompress up to nitems items of size size from file into buf,<br/>
		/// otherwise operating as gzread() does.  This duplicates the interface of<br/>
		/// stdio's fread(), with size_t request and return types.  If the library<br/>
		/// defines size_t, then z_size_t is identical to size_t.  If not, then z_size_t<br/>
		/// is an unsigned integer type that can contain a pointer.<br/>
		/// gzfread() returns the number of full items read of size size, or zero if<br/>
		/// the end of the file was reached and a full item could not be read, or if<br/>
		/// there was an error.  gzerror() must be consulted if zero is returned in<br/>
		/// order to determine if there was an error.  If the multiplication of size and<br/>
		/// nitems overflows, i.e. the product does not fit in a z_size_t, then nothing<br/>
		/// is read, zero is returned, and the error state is set to Z_STREAM_ERROR.<br/>
		/// In the event that the end of file is reached and only a partial item is<br/>
		/// available at the end, i.e. the remaining uncompressed data length is not a<br/>
		/// multiple of size, then the final partial item is nevertheless read into buf<br/>
		/// and the end-of-file flag is set.  The length of the partial item read is not<br/>
		/// provided, but could be inferred from the result of gztell().  This behavior<br/>
		/// is the same as the behavior of fread() implementations in common libraries,<br/>
		/// but it prevents the direct use of gzfread() to read a concurrently written<br/>
		/// file, resetting and retrying on end-of-file, when size is not 1.<br/>
		/// </summary>
		public static int Write(this GzFile file, void* buf, uint len)
		{
			int ret = ZLib.WriteNative(file, buf, len);
			return ret;
		}

		/// <summary>
		/// Compress and write nitems items of size size from buf to file, duplicating<br/>
		/// the interface of stdio's fwrite(), with size_t request and return types.  If<br/>
		/// the library defines size_t, then z_size_t is identical to size_t.  If not,<br/>
		/// then z_size_t is an unsigned integer type that can contain a pointer.<br/>
		/// gzfwrite() returns the number of full items written of size size, or zero<br/>
		/// if there was an error.  If the multiplication of size and nitems overflows,<br/>
		/// i.e. the product does not fit in a z_size_t, then nothing is written, zero<br/>
		/// is returned, and the error state is set to Z_STREAM_ERROR.<br/>
		/// </summary>
		public static int Printf(this GzFile file, byte* format)
		{
			int ret = ZLib.PrintfNative(file, format);
			return ret;
		}

		/// <summary>
		/// Compress and write nitems items of size size from buf to file, duplicating<br/>
		/// the interface of stdio's fwrite(), with size_t request and return types.  If<br/>
		/// the library defines size_t, then z_size_t is identical to size_t.  If not,<br/>
		/// then z_size_t is an unsigned integer type that can contain a pointer.<br/>
		/// gzfwrite() returns the number of full items written of size size, or zero<br/>
		/// if there was an error.  If the multiplication of size and nitems overflows,<br/>
		/// i.e. the product does not fit in a z_size_t, then nothing is written, zero<br/>
		/// is returned, and the error state is set to Z_STREAM_ERROR.<br/>
		/// </summary>
		public static int Printf(this GzFile file, ref byte format)
		{
			fixed (byte* pformat = &format)
			{
				int ret = ZLib.PrintfNative(file, (byte*)pformat);
				return ret;
			}
		}

		/// <summary>
		/// Compress and write nitems items of size size from buf to file, duplicating<br/>
		/// the interface of stdio's fwrite(), with size_t request and return types.  If<br/>
		/// the library defines size_t, then z_size_t is identical to size_t.  If not,<br/>
		/// then z_size_t is an unsigned integer type that can contain a pointer.<br/>
		/// gzfwrite() returns the number of full items written of size size, or zero<br/>
		/// if there was an error.  If the multiplication of size and nitems overflows,<br/>
		/// i.e. the product does not fit in a z_size_t, then nothing is written, zero<br/>
		/// is returned, and the error state is set to Z_STREAM_ERROR.<br/>
		/// </summary>
		public static int Printf(this GzFile file, ReadOnlySpan<byte> format)
		{
			fixed (byte* pformat = format)
			{
				int ret = ZLib.PrintfNative(file, (byte*)pformat);
				return ret;
			}
		}

		/// <summary>
		/// Compress and write nitems items of size size from buf to file, duplicating<br/>
		/// the interface of stdio's fwrite(), with size_t request and return types.  If<br/>
		/// the library defines size_t, then z_size_t is identical to size_t.  If not,<br/>
		/// then z_size_t is an unsigned integer type that can contain a pointer.<br/>
		/// gzfwrite() returns the number of full items written of size size, or zero<br/>
		/// if there was an error.  If the multiplication of size and nitems overflows,<br/>
		/// i.e. the product does not fit in a z_size_t, then nothing is written, zero<br/>
		/// is returned, and the error state is set to Z_STREAM_ERROR.<br/>
		/// </summary>
		public static int Printf(this GzFile file, string format)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (format != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(format);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(format, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = ZLib.PrintfNative(file, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// Convert, format, compress, and write the arguments (...) to file under<br/>
		/// control of the string format, as in fprintf.  gzprintf returns the number of<br/>
		/// uncompressed bytes actually written, or a negative zlib error code in case<br/>
		/// of error.  The number of uncompressed bytes written is limited to 8191, or<br/>
		/// one less than the buffer size given to gzbuffer().  The caller should assure<br/>
		/// that this limit is not exceeded.  If it is exceeded, then gzprintf() will<br/>
		/// return an error (0) with nothing written.  In this case, there may also be a<br/>
		/// buffer overflow with unpredictable consequences, which is possible only if<br/>
		/// zlib was compiled with the insecure functions sprintf() or vsprintf(),<br/>
		/// because the secure snprintf() or vsnprintf() functions were not available.<br/>
		/// This can be determined using zlibCompileFlags().<br/>
		/// </summary>
		public static int Puts(this GzFile file, byte* s)
		{
			int ret = ZLib.PutsNative(file, s);
			return ret;
		}

		/// <summary>
		/// Convert, format, compress, and write the arguments (...) to file under<br/>
		/// control of the string format, as in fprintf.  gzprintf returns the number of<br/>
		/// uncompressed bytes actually written, or a negative zlib error code in case<br/>
		/// of error.  The number of uncompressed bytes written is limited to 8191, or<br/>
		/// one less than the buffer size given to gzbuffer().  The caller should assure<br/>
		/// that this limit is not exceeded.  If it is exceeded, then gzprintf() will<br/>
		/// return an error (0) with nothing written.  In this case, there may also be a<br/>
		/// buffer overflow with unpredictable consequences, which is possible only if<br/>
		/// zlib was compiled with the insecure functions sprintf() or vsprintf(),<br/>
		/// because the secure snprintf() or vsnprintf() functions were not available.<br/>
		/// This can be determined using zlibCompileFlags().<br/>
		/// </summary>
		public static int Puts(this GzFile file, ref byte s)
		{
			fixed (byte* ps = &s)
			{
				int ret = ZLib.PutsNative(file, (byte*)ps);
				return ret;
			}
		}

		/// <summary>
		/// Convert, format, compress, and write the arguments (...) to file under<br/>
		/// control of the string format, as in fprintf.  gzprintf returns the number of<br/>
		/// uncompressed bytes actually written, or a negative zlib error code in case<br/>
		/// of error.  The number of uncompressed bytes written is limited to 8191, or<br/>
		/// one less than the buffer size given to gzbuffer().  The caller should assure<br/>
		/// that this limit is not exceeded.  If it is exceeded, then gzprintf() will<br/>
		/// return an error (0) with nothing written.  In this case, there may also be a<br/>
		/// buffer overflow with unpredictable consequences, which is possible only if<br/>
		/// zlib was compiled with the insecure functions sprintf() or vsprintf(),<br/>
		/// because the secure snprintf() or vsnprintf() functions were not available.<br/>
		/// This can be determined using zlibCompileFlags().<br/>
		/// </summary>
		public static int Puts(this GzFile file, ReadOnlySpan<byte> s)
		{
			fixed (byte* ps = s)
			{
				int ret = ZLib.PutsNative(file, (byte*)ps);
				return ret;
			}
		}

		/// <summary>
		/// Convert, format, compress, and write the arguments (...) to file under<br/>
		/// control of the string format, as in fprintf.  gzprintf returns the number of<br/>
		/// uncompressed bytes actually written, or a negative zlib error code in case<br/>
		/// of error.  The number of uncompressed bytes written is limited to 8191, or<br/>
		/// one less than the buffer size given to gzbuffer().  The caller should assure<br/>
		/// that this limit is not exceeded.  If it is exceeded, then gzprintf() will<br/>
		/// return an error (0) with nothing written.  In this case, there may also be a<br/>
		/// buffer overflow with unpredictable consequences, which is possible only if<br/>
		/// zlib was compiled with the insecure functions sprintf() or vsprintf(),<br/>
		/// because the secure snprintf() or vsnprintf() functions were not available.<br/>
		/// This can be determined using zlibCompileFlags().<br/>
		/// </summary>
		public static int Puts(this GzFile file, string s)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (s != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(s);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(s, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = ZLib.PutsNative(file, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// Compress and write the given null-terminated string s to file, excluding<br/>
		/// the terminating null character.<br/>
		/// gzputs returns the number of characters written, or -1 in case of error.<br/>
		/// </summary>
		public static byte* Gets(this GzFile file, byte* buf, int len)
		{
			byte* ret = ZLib.GetsNative(file, buf, len);
			return ret;
		}

		/// <summary>
		/// Compress and write the given null-terminated string s to file, excluding<br/>
		/// the terminating null character.<br/>
		/// gzputs returns the number of characters written, or -1 in case of error.<br/>
		/// </summary>
		public static string GetsS(this GzFile file, byte* buf, int len)
		{
			string ret = Utils.DecodeStringUTF8(ZLib.GetsNative(file, buf, len));
			return ret;
		}

		/// <summary>
		/// Compress and write the given null-terminated string s to file, excluding<br/>
		/// the terminating null character.<br/>
		/// gzputs returns the number of characters written, or -1 in case of error.<br/>
		/// </summary>
		public static byte* Gets(this GzFile file, ref byte buf, int len)
		{
			fixed (byte* pbuf = &buf)
			{
				byte* ret = ZLib.GetsNative(file, (byte*)pbuf, len);
				return ret;
			}
		}

		/// <summary>
		/// Compress and write the given null-terminated string s to file, excluding<br/>
		/// the terminating null character.<br/>
		/// gzputs returns the number of characters written, or -1 in case of error.<br/>
		/// </summary>
		public static string GetsS(this GzFile file, ref byte buf, int len)
		{
			fixed (byte* pbuf = &buf)
			{
				string ret = Utils.DecodeStringUTF8(ZLib.GetsNative(file, (byte*)pbuf, len));
				return ret;
			}
		}

		/// <summary>
		/// Compress and write the given null-terminated string s to file, excluding<br/>
		/// the terminating null character.<br/>
		/// gzputs returns the number of characters written, or -1 in case of error.<br/>
		/// </summary>
		public static byte* Gets(this GzFile file, ref string buf, int len)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (buf != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(buf);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(buf, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte* ret = ZLib.GetsNative(file, pStr0, len);
			buf = Utils.DecodeStringUTF8(pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// Compress and write the given null-terminated string s to file, excluding<br/>
		/// the terminating null character.<br/>
		/// gzputs returns the number of characters written, or -1 in case of error.<br/>
		/// </summary>
		public static string GetsS(this GzFile file, ref string buf, int len)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (buf != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(buf);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(buf, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			string ret = Utils.DecodeStringUTF8(ZLib.GetsNative(file, pStr0, len));
			buf = Utils.DecodeStringUTF8(pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// Read and decompress bytes from file into buf, until len-1 characters are<br/>
		/// read, or until a newline character is read and transferred to buf, or an<br/>
		/// end-of-file condition is encountered.  If any characters are read or if len<br/>
		/// is one, the string is terminated with a null character.  If no characters<br/>
		/// are read due to an end-of-file or len is less than one, then the buffer is<br/>
		/// left untouched.<br/>
		/// gzgets returns buf which is a null-terminated string, or it returns NULL<br/>
		/// for end-of-file or in case of error.  If there was an error, the contents at<br/>
		/// buf are indeterminate.<br/>
		/// </summary>
		public static int Putc(this GzFile file, int c)
		{
			int ret = ZLib.PutcNative(file, c);
			return ret;
		}

		/// <summary>
		/// Compress and write c, converted to an unsigned char, into file.  gzputc<br/>
		/// returns the value that was written, or -1 in case of error.<br/>
		/// </summary>
		public static int Getc(this GzFile file)
		{
			int ret = ZLib.GetcNative(file);
			return ret;
		}

		/// <summary>
		/// Push c back onto the stream for file to be read as the first character on<br/>
		/// the next read.  At least one character of push-back is always allowed.<br/>
		/// gzungetc() returns the character pushed, or -1 on failure.  gzungetc() will<br/>
		/// fail if c is -1, and may fail if a character has been pushed but not read<br/>
		/// yet.  If gzungetc is used immediately after gzopen or gzdopen, at least the<br/>
		/// output buffer size of pushed characters is allowed.  (See gzbuffer above.)<br/>
		/// The pushed character will be discarded if the stream is repositioned with<br/>
		/// gzseek() or gzrewind().<br/>
		/// </summary>
		public static int Flush(this GzFile file, int flush)
		{
			int ret = ZLib.FlushNative(file, flush);
			return ret;
		}

		/// <summary>
		/// ZEXTERN z_off_t ZEXPORT gzseek(gzFile file,<br/>
		/// z_off_t offset, int whence);<br/>
		/// Set the starting position to offset relative to whence for the next gzread<br/>
		/// or gzwrite on file.  The offset represents a number of bytes in the<br/>
		/// uncompressed data stream.  The whence parameter is defined as in lseek(2);<br/>
		/// the value SEEK_END is not supported.<br/>
		/// If the file is opened for reading, this function is emulated but can be<br/>
		/// extremely slow.  If the file is opened for writing, only forward seeks are<br/>
		/// supported; gzseek then compresses a sequence of zeroes up to the new<br/>
		/// starting position.<br/>
		/// gzseek returns the resulting offset location as measured in bytes from<br/>
		/// the beginning of the uncompressed stream, or -1 in case of error, in<br/>
		/// particular if the file is opened for writing and the new starting position<br/>
		/// would be before the current position.<br/>
		/// </summary>
		public static int Rewind(this GzFile file)
		{
			int ret = ZLib.RewindNative(file);
			return ret;
		}

		/// <summary>
		/// ZEXTERN z_off_t ZEXPORT gzoffset(gzFile file);<br/>
		/// Return the current compressed (actual) read or write offset of file.  This<br/>
		/// offset includes the count of bytes that precede the gzip stream, for example<br/>
		/// when appending or when using gzdopen() for reading.  When reading, the<br/>
		/// offset does not include as yet unused buffered input.  This information can<br/>
		/// be used for a progress indicator.  On error, gzoffset() returns -1.<br/>
		/// </summary>
		public static int Eof(this GzFile file)
		{
			int ret = ZLib.EofNative(file);
			return ret;
		}

		/// <summary>
		/// Return true (1) if the end-of-file indicator for file has been set while<br/>
		/// reading, false (0) otherwise.  Note that the end-of-file indicator is set<br/>
		/// only if the read tried to go past the end of the input, but came up short.<br/>
		/// Therefore, just like feof(), gzeof() may return false even if there is no<br/>
		/// more data to read, in the event that the last read request was for the exact<br/>
		/// number of bytes remaining in the input file.  This will happen if the input<br/>
		/// file size is an exact multiple of the buffer size.<br/>
		/// If gzeof() returns true, then the read functions will return no more data,<br/>
		/// unless the end-of-file indicator is reset by gzclearerr() and the input file<br/>
		/// has grown since the previous end of file was detected.<br/>
		/// </summary>
		public static int Direct(this GzFile file)
		{
			int ret = ZLib.DirectNative(file);
			return ret;
		}

		/// <summary>
		/// Return true (1) if file is being copied directly while reading, or false<br/>
		/// (0) if file is a gzip stream being decompressed.<br/>
		/// If the input file is empty, gzdirect() will return true, since the input<br/>
		/// does not contain a gzip stream.<br/>
		/// If gzdirect() is used immediately after gzopen() or gzdopen() it will<br/>
		/// cause buffers to be allocated to allow reading the file to determine if it<br/>
		/// is a gzip file.  Therefore if gzbuffer() is used, it should be called before<br/>
		/// gzdirect().<br/>
		/// When writing, gzdirect() returns true (1) if transparent writing was<br/>
		/// requested ("wT" for the gzopen() mode), or false (0) otherwise.  (Note:<br/>
		/// gzdirect() is not needed when writing.  Transparent writing must be<br/>
		/// explicitly requested, so the application already knows the answer.  When<br/>
		/// linking statically, using gzdirect() will include all of the zlib code for<br/>
		/// gzip file reading and decompression, which may not be desired.)<br/>
		/// </summary>
		public static int Close(this GzFile file)
		{
			int ret = ZLib.CloseNative(file);
			return ret;
		}

		/// <summary>
		/// Flush all pending output for file, if necessary, close file and<br/>
		/// deallocate the (de)compression state.  Note that once file is closed, you<br/>
		/// cannot call gzerror with file, since its structures have been deallocated.<br/>
		/// gzclose must not be called more than once on the same file, just as free<br/>
		/// must not be called more than once on the same allocation.<br/>
		/// gzclose will return Z_STREAM_ERROR if file is not valid, Z_ERRNO on a<br/>
		/// file operation error, Z_MEM_ERROR if out of memory, Z_BUF_ERROR if the<br/>
		/// last read ended in the middle of a gzip stream, or Z_OK on success.<br/>
		/// </summary>
		public static int CloseR(this GzFile file)
		{
			int ret = ZLib.CloseRNative(file);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static int CloseW(this GzFile file)
		{
			int ret = ZLib.CloseWNative(file);
			return ret;
		}

		/// <summary>
		/// Same as gzclose(), but gzclose_r() is only for use when reading, and<br/>
		/// gzclose_w() is only for use when writing or appending.  The advantage to<br/>
		/// using these instead of gzclose() is that they avoid linking in zlib<br/>
		/// compression or decompression code that is not used when only reading or only<br/>
		/// writing respectively.  If gzclose() is used, then both compression and<br/>
		/// decompression code will be included the application when linking to a static<br/>
		/// zlib library.<br/>
		/// </summary>
		public static byte* Error(this GzFile file, int* errnum)
		{
			byte* ret = ZLib.ErrorNative(file, errnum);
			return ret;
		}

		/// <summary>
		/// Same as gzclose(), but gzclose_r() is only for use when reading, and<br/>
		/// gzclose_w() is only for use when writing or appending.  The advantage to<br/>
		/// using these instead of gzclose() is that they avoid linking in zlib<br/>
		/// compression or decompression code that is not used when only reading or only<br/>
		/// writing respectively.  If gzclose() is used, then both compression and<br/>
		/// decompression code will be included the application when linking to a static<br/>
		/// zlib library.<br/>
		/// </summary>
		public static string ErrorS(this GzFile file, int* errnum)
		{
			string ret = Utils.DecodeStringUTF8(ZLib.ErrorNative(file, errnum));
			return ret;
		}

		/// <summary>
		/// Same as gzclose(), but gzclose_r() is only for use when reading, and<br/>
		/// gzclose_w() is only for use when writing or appending.  The advantage to<br/>
		/// using these instead of gzclose() is that they avoid linking in zlib<br/>
		/// compression or decompression code that is not used when only reading or only<br/>
		/// writing respectively.  If gzclose() is used, then both compression and<br/>
		/// decompression code will be included the application when linking to a static<br/>
		/// zlib library.<br/>
		/// </summary>
		public static byte* Error(this GzFile file, ref int errnum)
		{
			fixed (int* perrnum = &errnum)
			{
				byte* ret = ZLib.ErrorNative(file, (int*)perrnum);
				return ret;
			}
		}

		/// <summary>
		/// Same as gzclose(), but gzclose_r() is only for use when reading, and<br/>
		/// gzclose_w() is only for use when writing or appending.  The advantage to<br/>
		/// using these instead of gzclose() is that they avoid linking in zlib<br/>
		/// compression or decompression code that is not used when only reading or only<br/>
		/// writing respectively.  If gzclose() is used, then both compression and<br/>
		/// decompression code will be included the application when linking to a static<br/>
		/// zlib library.<br/>
		/// </summary>
		public static string ErrorS(this GzFile file, ref int errnum)
		{
			fixed (int* perrnum = &errnum)
			{
				string ret = Utils.DecodeStringUTF8(ZLib.ErrorNative(file, (int*)perrnum));
				return ret;
			}
		}

		/// <summary>
		/// Return the error message for the last error which occurred on file.<br/>
		/// errnum is set to zlib error number.  If an error occurred in the file system<br/>
		/// and not in the compression library, errnum is set to Z_ERRNO and the<br/>
		/// application may consult errno to get the exact error code.<br/>
		/// The application must not modify the returned string.  Future calls to<br/>
		/// this function may invalidate the previously returned string.  If file is<br/>
		/// closed, then the string previously returned by gzerror will no longer be<br/>
		/// available.<br/>
		/// gzerror() should be used to distinguish errors from end-of-file for those<br/>
		/// functions above that do not distinguish those cases in their return values.<br/>
		/// </summary>
		public static void Clearerr(this GzFile file)
		{
			ZLib.ClearerrNative(file);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static int Seek(this GzFile unknown0, int unknown1, int unknown2)
		{
			int ret = ZLib.SeekNative(unknown0, unknown1, unknown2);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static int Tell(this GzFile unknown0)
		{
			int ret = ZLib.TellNative(unknown0);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static int Offset(this GzFile unknown0)
		{
			int ret = ZLib.OffsetNative(unknown0);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static long Seek64(this GzFile unknown0, long unknown1, int unknown2)
		{
			long ret = ZLib.Seek64Native(unknown0, unknown1, unknown2);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static long Tell64(this GzFile unknown0)
		{
			long ret = ZLib.Tell64Native(unknown0);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static long Offset64(this GzFile unknown0)
		{
			long ret = ZLib.Offset64Native(unknown0);
			return ret;
		}

		/// <summary>
		/// Same as gzclose(), but gzclose_r() is only for use when reading, and<br/>
		/// gzclose_w() is only for use when writing or appending.  The advantage to<br/>
		/// using these instead of gzclose() is that they avoid linking in zlib<br/>
		/// compression or decompression code that is not used when only reading or only<br/>
		/// writing respectively.  If gzclose() is used, then both compression and<br/>
		/// decompression code will be included the application when linking to a static<br/>
		/// zlib library.<br/>
		/// </summary>
		public static void Error(this GzStatep unknown0, int unknown1, byte* unknown2)
		{
			ZLib.ErrorNative(unknown0, unknown1, unknown2);
		}

		/// <summary>
		/// Same as gzclose(), but gzclose_r() is only for use when reading, and<br/>
		/// gzclose_w() is only for use when writing or appending.  The advantage to<br/>
		/// using these instead of gzclose() is that they avoid linking in zlib<br/>
		/// compression or decompression code that is not used when only reading or only<br/>
		/// writing respectively.  If gzclose() is used, then both compression and<br/>
		/// decompression code will be included the application when linking to a static<br/>
		/// zlib library.<br/>
		/// </summary>
		public static void Error(this GzStatep unknown0, int unknown1, ref byte unknown2)
		{
			fixed (byte* punknown2 = &unknown2)
			{
				ZLib.ErrorNative(unknown0, unknown1, (byte*)punknown2);
			}
		}

		/// <summary>
		/// Same as gzclose(), but gzclose_r() is only for use when reading, and<br/>
		/// gzclose_w() is only for use when writing or appending.  The advantage to<br/>
		/// using these instead of gzclose() is that they avoid linking in zlib<br/>
		/// compression or decompression code that is not used when only reading or only<br/>
		/// writing respectively.  If gzclose() is used, then both compression and<br/>
		/// decompression code will be included the application when linking to a static<br/>
		/// zlib library.<br/>
		/// </summary>
		public static void Error(this GzStatep unknown0, int unknown1, ReadOnlySpan<byte> unknown2)
		{
			fixed (byte* punknown2 = unknown2)
			{
				ZLib.ErrorNative(unknown0, unknown1, (byte*)punknown2);
			}
		}

		/// <summary>
		/// Same as gzclose(), but gzclose_r() is only for use when reading, and<br/>
		/// gzclose_w() is only for use when writing or appending.  The advantage to<br/>
		/// using these instead of gzclose() is that they avoid linking in zlib<br/>
		/// compression or decompression code that is not used when only reading or only<br/>
		/// writing respectively.  If gzclose() is used, then both compression and<br/>
		/// decompression code will be included the application when linking to a static<br/>
		/// zlib library.<br/>
		/// </summary>
		public static void Error(this GzStatep unknown0, int unknown1, string unknown2)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (unknown2 != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(unknown2);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(unknown2, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			ZLib.ErrorNative(unknown0, unknown1, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

	}
}
