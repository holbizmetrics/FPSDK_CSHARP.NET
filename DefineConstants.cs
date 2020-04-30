//namespace FLStudioSDK
//{
//    internal static class DefineConstants
//    {
//#if !__APPLE__
//        public const int WINAPI_FAMILY_PC_APP = 2; // Windows Store Applications
//#endif
//#if !__APPLE__
//        public const int WINAPI_FAMILY_PHONE_APP = 3; // Windows Phone Applications
//#endif
//#if !__APPLE__
//        public const int WINAPI_FAMILY_SYSTEM = 4; // Windows Drivers and Tools
//#endif
//#if !__APPLE__
//        public const int WINAPI_FAMILY_SERVER = 5; // Windows Server Applications
//#endif
//#if !__APPLE__
//        public const int WINAPI_FAMILY_DESKTOP_APP = 100; // Windows Desktop Applications
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int MAXPNAMELEN = 32; // max product name length (including NULL)
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int MAXERRORLENGTH = 256; // max error text length (including NULL)
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int MAX_JOYSTICKOEMVXDNAME = 260; // max oem vxd name length (including NULL)
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM) && (WINVER <= 0x0400)
//	public const int MM_MICROSOFT = 1; // Microsoft Corporation
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM) && (WINVER <= 0x0400)
//	public const int MM_MIDI_MAPPER = 1; // MIDI Mapper
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM) && (WINVER <= 0x0400)
//	public const int MM_WAVE_MAPPER = 2; // Wave Mapper
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM) && (WINVER <= 0x0400)
//	public const int MM_SNDBLST_MIDIOUT = 3; // Sound Blaster MIDI output port
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM) && (WINVER <= 0x0400)
//	public const int MM_SNDBLST_MIDIIN = 4; // Sound Blaster MIDI input port
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM) && (WINVER <= 0x0400)
//	public const int MM_SNDBLST_SYNTH = 5; // Sound Blaster internal synthesizer
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM) && (WINVER <= 0x0400)
//	public const int MM_SNDBLST_WAVEOUT = 6; // Sound Blaster waveform output
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM) && (WINVER <= 0x0400)
//	public const int MM_SNDBLST_WAVEIN = 7; // Sound Blaster waveform input
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM) && (WINVER <= 0x0400)
//	public const int MM_ADLIB = 9; // Ad Lib-compatible synthesizer
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM) && (WINVER <= 0x0400)
//	public const int MM_MPU401_MIDIOUT = 10; // MPU401-compatible MIDI output port
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM) && (WINVER <= 0x0400)
//	public const int MM_MPU401_MIDIIN = 11; // MPU401-compatible MIDI input port
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM) && (WINVER <= 0x0400)
//	public const int MM_PC_JOYSTICK = 12; // Joystick adapter
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int TIME_MS = 0x0001; // time in milliseconds
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int TIME_SAMPLES = 0x0002; // number of wave samples
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int TIME_BYTES = 0x0004; // current byte offset
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int TIME_SMPTE = 0x0008; // SMPTE time
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int TIME_MIDI = 0x0010; // MIDI time
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int TIME_TICKS = 0x0020; // Ticks within MIDI stream
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int MM_JOY1MOVE = 0x3A0; // joystick
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int MM_JOY2MOVE = 0x3A1;
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int MM_JOY1ZMOVE = 0x3A2;
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int MM_JOY2ZMOVE = 0x3A3;
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int MM_JOY1BUTTONDOWN = 0x3B5;
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int MM_JOY2BUTTONDOWN = 0x3B6;
//#endif
//#if !__APPLE__ && WINAPI_FAMILY_PARTITION(WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_SYSTEM)
//	public const int MM_JOY1BUTTONUP = 0x3B7;
//#endif
//    }
//}