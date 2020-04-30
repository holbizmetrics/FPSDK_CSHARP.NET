//====================================================================================================
//The Free Edition of C++ to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-cplus-to-csharp.html
//====================================================================================================

namespace FLStudioSDK
{
#if _USE_AFX
#define VC_EXTRALEAN // Exclude rarely-used stuff from Windows headers
#endif

/*

FL Studio generator/effect plugins SDK
plugin & host classes

(99-15) gol


!!! Warnings:

-when multithreadable, a generator (not effect) adding to the output buffer, or a generator/effect adding to the send buffers, must lock the access in-between LockMix_Shared / UnlockMix_Shared




history:

(10/05/00)
- rewrote almost everything, a lot of changes & splits

(15/07/00)
- changed TVoiceParams & the way the levels are handled (Voice_Render)
- added FPF_TimeWarp

(26/07/00)
- added plugin flags combo's
- removed AlphaTable from TFruityPlugHost

(27/07/00)
- DefPoly now used

(26/09/00)
- TFruityPlugHost.MIDIOut declaration has changed
- implemented FPF_MIDITick

(27/09/00)
- added TFruityPlugHost.MIDIOut_Delayed & FPF_MIDIOut, reorganized TFruityPlugHost
- defined UseCriticalSection in FP_DelphiPlug
- updated FPE_Tempo
- added FPE_MaxPoly & FPD_KillAVoice

(11/10/00)
- added FPE_MIDI_Pan & FPE_MIDI_Vol

(01/11/00)
- updated TFruityPlugHost.Voice_Kill(Sender:Integer;KillHandle:LongBool);
  (KillHandle forces Fruity to ask back the plugin to destroy its voice, in case the plugin is still using that voice handle, or has destroyed it already, use False)

(27/11/00)
- added FPN_VoiceLevel & FPN_VoiceLevelHint to allow the plugin to define the function of the 2 extra per-voice params (filter cutoff & resonance by default)
  added FPD_UseVoiceLevels

(29/11/00)
- added TempBuffers (TFruityPlugHost)
- added AddWave_32FM_32FS_Ramp and AddWave_32FS_32FS_Ramp (TFruityPlugHost)

(13/12/00)
- updated FPE_MIDI_Vol
- added FHD_ActivateMIDI

(15/12/00)
- added FPF_MIDIIn, TFruityPlug.MIDIIn

(16/12/00)
- removed FPF_MIDIIn & FPF_MIDITick, added FHD_WantMIDIInput & FHD_WantMIDITick

(19/12/00)
- added FPD_WrapPlugin and FHD_LocatePlugin

(20/12/00)
- added FHD_KillAutomation
- added FPF_DemoVersion

(21/12/00)
- added FHD_SetNumPresets, FPN_Preset, FPD_SetPreset

(02/01/01)
- added noise wavetable
- updated PM_HQ

(15/02/01)
- added FHD_VSTiIdle
- now supports FPF_UseChanSample
- added FPD_SetCustomWaveTable

(19/03/01)
- updated FPD_WrapPlugin

(18/04/O1)
- added sample loading functions

(2/06/01)
- added FPN_OutCtrl, NumOutCtrls
- replaced FPF_EventController by FPF_WantNewTick (now implemented)

(12/07/01)
- added FHD_LocateDataFile
- fixed the implementation of TFruityPlugHost.Voice_Release in FruityLoops

(19/07/01)
- added FHD_GetParamMenuEntry
- (!) changed CurrentSDKVersion to 1

(24/07/01)
- added some info to WaveTables & TempBuffers

(29/07/01)
- added MsgIn, PlugMsg_Delayed, etc. (for the Fruity Vibrator)

(02/08/01)
- added FPF_Hybrid
- renamed FPF_UseChanSample to FPF_GetChanCustomShape & renamed FPD_SetCustomShape to FPD_ChanSampleChanged
- added FPF_GetChanSample (so that the plugin can get the sample as a custom 32FM shape, or a 16IS sample
- added FHLS_GetName
- changed & added processing mode flags (see PM_IsRendering)
- added GetSampleInfo

(13/02/02)
- removed MixingTick & MIDITick class variables

(10/07/02)
- added FPF_WantFitTime

(29/06/02)
- increased number of temp buffers to 4

(06/05/04)
- added FHLS_NoResampling

(18/07/04)
- added FPF_NewVoiceParams
  HOW TO UPDATE TO THIS:
  Step 1: Add FPF_NewVoiceParams to your plugin flags
  Step 2: Adapt your code so that you read the pitch & panning as floats instead of integers. Pitch is still in cents, and panning is in -1..1
  Note: ComputeLRVol was changed to ComputeLRVol_Old, and ComputeLRVol has been adapted to accept a -1..1 float panning parameter

(08/11/04)
- changed FPD_SetNumSends

(31/12/04)
- added FPD_SetSamplesPerTick

(21/03/05)
- added FPV_GetLength and FPV_GetColor for a plugin to retrieve voice color & length

(16/05/05)
- added (GM) and (G) comments telling from which thread(s) functions can be called
- added TFruityPlugHost.LockPlugin

(08/03/06)
- added FPF_IsDelphi (not in C++ version)

(02/11/06)
- added FPV_GetVelocity, FPV_GetRelVelocity, FPV_GetRelTime and FPV_SetLinkVelocity

(23/12/08)
- added FHD_GetNumInOut, GetInBuffer, GetOutBuffer, FPD_RoutingChanged
- GetInsBuffer now cannot use Ofs=0 (could bring problems)
So, GetInsBuffer, GetInBuffer & GetOutBuffer use Indexes that start at 1, 0 meaning the buffer during rendering

(27/01/09)
- added FHD_FloatAutomation, FPD_GetParamInfo, FPD_ProjLoaded, FPD_WrapperLoadState, FPD_ShowSettings, FPF_WantSettingsBtn

(02/11/11)
- MsgIn, PlugMsg_Delayed, PlugMsg_Kill are now deprecated. DO NOT USE THEM!

*/


//---------------------------------------------------------------------------



#if __APPLE__
#else
#endif
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WaveT_Size ( 1 << WaveT_Bits )
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WaveT_Shift ( 32 - WaveT_Bits )
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WaveT_Step 1 << WaveT_Shift
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WaveT_PMask ( 0xFFFFFFFF >> WaveT_Shift )
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define WaveT_FMask ( 0xFFFFFFFF >> WaveT_Bits )
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define MIDIMsg_PortMask 0xFFFFFF;
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define MIDIMsg_Null 0xFFFFFFFF;

#if __APPLE__
//C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define _stdcall __stdcall
#define _stdcall
//C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define BOOL int
#define BOOL
//C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define HINSTANCE intptr_t
#define HINSTANCE
//C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define HMENU intptr_t
#define HMENU
//C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define DWORD int
#define DWORD
//C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define HWND intptr_t
#define HWND
//C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define HANDLE intptr_t
#define HANDLE
#define NULL
#define MAX_PATH
//C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define RTL_CRITICAL_SECTION intptr_t
#define RTL_CRITICAL_SECTION
//C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//typedef ulong ULARGE_INTEGER;
//C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//typedef long LARGE_INTEGER;
#endif

//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack( push )
//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack( 4 )


#if __APPLE__
//C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
//ORIGINAL LINE: #define STDMETHODCALLTYPE __stdcall
#define STDMETHODCALLTYPE
public interface IStream
{
	void QueryInterface();
//C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
//ORIGINAL LINE: virtual uint __stdcall AddRef() = 0;
	uint AddRef();
//C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
//ORIGINAL LINE: virtual uint __stdcall Release() = 0;
	uint Release();
//C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
//ORIGINAL LINE: virtual int __stdcall Read(object* pv, uint cb, uint* pcbRead) = 0;
	int Read(object pv, uint cb, ref uint pcbRead);
//C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
//ORIGINAL LINE: virtual int __stdcall Write(const object* pv, uint cb, uint* pcbWritten) = 0;
	int Write(object pv, uint cb, ref uint pcbWritten);
//C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
//ORIGINAL LINE: virtual int __stdcall Seek(long dlibMove, int dwOrigin, ulong* plibNewPosition) = 0;
	int Seek(long dlibMove, int dwOrigin, ref ulong plibNewPosition);
//C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
//ORIGINAL LINE: virtual int __stdcall SetSize(ulong libNewSize) = 0;
	int SetSize(ulong libNewSize);
//C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
//ORIGINAL LINE: virtual int __stdcall CopyTo(IStream* pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten) = 0;
	int CopyTo(IStream pstm, ulong cb, ref ulong pcbRead, ref ulong pcbWritten);
//C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
//ORIGINAL LINE: virtual int __stdcall Commit(int grfCommitFlags) = 0;
	int Commit(int grfCommitFlags);
//C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
//ORIGINAL LINE: virtual int __stdcall Revert() = 0;
	int Revert();
//C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
//ORIGINAL LINE: virtual int __stdcall LockRegion(ulong libOffset, ulong cb, int dwLockType) = 0;
	int LockRegion(ulong libOffset, ulong cb, int dwLockType);
//C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
//ORIGINAL LINE: virtual int __stdcall UnlockRegion(ulong libOffset, ulong cb, int dwLockType) = 0;
	int UnlockRegion(ulong libOffset, ulong cb, int dwLockType);
//C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
//ORIGINAL LINE: virtual int __stdcall Stat(object* pstatstg, int grfStatFlag) = 0;
	int Stat(object pstatstg, int grfStatFlag);
//C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
//ORIGINAL LINE: virtual int __stdcall Clone(IStream** ppstm) = 0;
	int Clone(IStream[] ppstm);
}
#endif


// plugin info, common to all instances of the same plugin
    public class TFruityPlugInfo
    {
        public int SDKVersion; // =CurrentSDKVersion
        public string LongName; // full plugin name (should be the same as DLL name)
        public string ShortName; // & short version (for labels)
        public int Flags; // see FPF_Generator
        public int NumParams; // (maximum) number of parameters, can be overridden using FHD_SetNumParams
        public int DefPoly; // preferred (default) max polyphony (Fruity manages polyphony) (0=infinite)
        public int NumOutCtrls; // number of internal output controllers
        public int NumOutVoices; // number of internal output voices

        public int[] Reserved = new int[30]; // set to zero
    }


// voice handle (can be an index or a memory pointer (must be unique, that is *not* just the semitone #))

// sample handle

// sample region
    public class TSampleRegion
    {
        public int SampleStart;
        public int SampleEnd;
        public string Name = new string(new char[256]);
        public string Info = new string(new char[256]);
        public float Time; // beat position, mainly for loop dumping (-1 if not supported)
        public int KeyNum; // linked MIDI note number (-1 if not supported)
        public int[] Reserved = new int[4];
    }

//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack( pop )


//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack( push )
//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack( 1 )

// sample info, FILL CORRECTLY
    public class TSampleInfo
    {
        public int Size; // size of this structure, MUST BE SET BY THE PLUGIN
        public object Data; // pointer to the samples
        public int Length; // length in samples
        public int SolidLength; // length without ending silence
        public int LoopStart;
        public int LoopEnd; // loop points (LoopStart=-1 if no loop points)
        public double SmpRateConv; // host samplerate*SmpRateConv = samplerate
        public int NumRegions; // number of regions in the sample (see GetSampleRegion)
        public float NumBeats; // length in beats
        public float Tempo;
        public int NumChans; // 1=mono, 2=stereo, MUST BE SET BY THE PLUGIN, to -1 if all formats are accepted
        public int Format; // 0=16I, 1=32F, MUST BE SET BY THE PLUGIN, to -1 if all formats are accepted
        public int[] Reserved = new int[13]; // future use

    }

//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack( pop )


//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack( push )
//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack( 4 )

// see FPV_GetInfo
    public class TVoiceInfo
    {
        public int Length;
        public int Color;
        public float Velocity;
        public int Flags;
        public int[] Reserved = new int[8];
    }

//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack( pop )


//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack( push )
//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack( 1 )

// see FHD_GetMixingTime
    public class TFPTime
    {
        public double t;
        public double t2;
    }

// see FHD_GetInName
    public class TNameColor
    {
        public string Name = new string(new char[256]); // user-defined name (can be empty)
        public string VisName = new string(new char[256]); // visible name (can be guessed)
        public int Color;
        public int Index; // real index of the item (can be used to translate plugin's own in/out into real mixer track #)
    }

// see GetInBuffer/GetOutBuffer
    public class TIOBuffer
    {
        public object Buffer;
        //BOOL Filled;	// only valid for GetInBuffer, indicates if buffer is not empty
        public int Flags; // see IO_Filled
    }

//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack( pop )


// level params, used both for final voice levels (voice levels+parent channel levels) & original voice levels
// note: all params can go outside their defined range

// OLD, OBSOLETE VERSION, DO NOT USE!!!
    public class TLevelParams_Old
    {
        public int Pan; // panning (-64..64)
        public float Vol; // volume/velocity (0..1)
        public int Pitch; // pitch (in cents) (semitone=Pitch/100)
        public float FCut; // filter cutoff (0..1)
        public float FRes; // filter Q (0..1)
    }

    public class TVoiceParams_Old
    {

    }
}