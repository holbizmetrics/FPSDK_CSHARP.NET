//====================================================================================================
//The Free Edition of C++ to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-cplus-to-csharp.html
//====================================================================================================

using System;

#if _USE_AFX
#define VC_EXTRALEAN // Exclude rarely-used stuff from Windows headers
#endif
#if __BORLANDC__
//C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
//#include <vcl/SysInit.hpp>
#endif

/*

FL Studio generator/effect plugins SDK
C++ object extension
handy functions for easier implementation of a Fruity plugin in C++

(99-15) gol, reflex

*/


//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_SERVER (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_WINTRUST (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_WEBSERVICES (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_EVENTLOGSERVICE (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_VHD (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_PERFCOUNTER (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_SECURESTARTUP (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_REMOTEFS (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_BOOTABLESKU (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_CMDTOOLS (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_DISM (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_CORESETUP (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_APPRUNTIME (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_ESENT (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_WINMGMT (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_WNV (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_CLUSTER (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_VSS (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_TRAFFIC (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_ISCSI (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_STORAGE (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_MPSSVC (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_APPXDEPLOYMENT (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PKG_WER (WINAPI_PARTITION_SERVER == 1)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_FAMILY_APP WINAPI_FAMILY_PC_APP
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_FAMILY WINAPI_FAMILY_DESKTOP_APP
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_DESKTOP (WINAPI_FAMILY == WINAPI_FAMILY_DESKTOP_APP)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_APP (WINAPI_FAMILY == WINAPI_FAMILY_DESKTOP_APP || WINAPI_FAMILY == WINAPI_FAMILY_PC_APP || WINAPI_FAMILY == WINAPI_FAMILY_PHONE_APP)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PC_APP (WINAPI_FAMILY == WINAPI_FAMILY_DESKTOP_APP || WINAPI_FAMILY == WINAPI_FAMILY_PC_APP)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PHONE_APP (WINAPI_FAMILY == WINAPI_FAMILY_PHONE_APP)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_SYSTEM (WINAPI_FAMILY == WINAPI_FAMILY_SYSTEM || WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_PARTITION_PHONE WINAPI_PARTITION_PHONE_APP
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINAPI_FAMILY_PARTITION(Partitions) (Partitions)
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define _WINAPI_DEPRECATED_DECLARATION __declspec(deprecated("This API cannot be used in the context of the caller's application type."))
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define APP_DEPRECATED_HRESULT HRESULT _WINAPI_DEPRECATED_DECLARATION
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WINMMAPI DECLSPEC_IMPORT
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define MAKEFOURCC(ch0, ch1, ch2, ch3) ((DWORD)(BYTE)(ch0) | ((DWORD)(BYTE)(ch1) << 8) | ((DWORD)(BYTE)(ch2) << 16) | ((DWORD)(BYTE)(ch3) << 24 ))

//====================================================================================================
//End of the allowed output for the Free Edition of C++ to C# Converter.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-cplus-to-csharp.html
//====================================================================================================
