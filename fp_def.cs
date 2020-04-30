#if !__APPLE__
#endif


// published wavetables

// interlaced stereo 32Bit float buffer


// MIDI out message structure (3 bytes standard MIDI message + port)
public class TMIDIOutMsg
{
    public byte Status;
    public byte Data1;
    public byte Data2;
    public byte Port;
}

// extended wav format
public class TWaveFormatExtensible
{
#if !__APPLE__
    //public WAVEFORMATEX WaveFormatEx = new WAVEFORMATEX();
#endif
    //C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
    //	union
    //	{
    //		struct
    //		{
    //			ushort wValidBitsPerSample; // bits of precision
    //			uint dwChannelMask; // which channels are present in stream
    //#if ! __APPLE__
    //			GUID SubFormat;
    //#endif
    //		}
    //		stream;
    //		ushort wSamplesPerBlock; // valid if wBitsPerSample==0
    //		ushort wReserved; // if neither applies, set to zero
    //	};
}


// Bar:Step:Tick
public class TSongTime
{
    public int Bar;
    public int Step;
    public int Tick;
}

// time sig info (easily converted to standard x/x time sig, but more powerful)
public class TTimeSigInfo
{
    public int StepsPerBar;
    public int StepsPerBeat;
    public int PPQ;
}