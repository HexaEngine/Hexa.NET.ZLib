#define local static
#define DIST_CODE_LEN  512
#define ZLIB_DLL 
#define ZLIB_INTERNAL
#include "zconf.h"
#include "zlib.h"
#include "crc32.h"
#include "zutil.h"
#include "inftrees.h"
#include "deflate.h"
#include "inflate.h"
#include "inffast.h"
#include "inffixed.h"

#include "gzguts.h"
#include "trees.h"