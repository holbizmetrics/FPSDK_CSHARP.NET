namespace FLStudioSDK
{
    public static class GlobalMembers
    {
#if !__BORLANDC__
        //C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
        //extern intptr_t HInstance;
#endif


        //C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
        //extern char AppHint[256];
        //C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
        //extern char PluginPath[MaxPath]; // path to this DLL plugin (for loading of resources)

        public static readonly int AbsPPN = 192 / 4; // 192 PPQ

        // see ShowHintMsg_Pitch
        public static readonly int PT_Octaves = -1;
        public static readonly int PT_Semitones = 0;
        public static readonly int PT_Cents = 1;
        public static readonly int PT_Hz = 2;


#if !__BORLANDC__
        //public static intptr_t HInstance = new intptr_t();
#endif
        public static void GetPluginPath()
        {
#if !__APPLE__
            //string p = new string(new char[MaxPath]);
            //GetModuleFileNameA(HInstance, p, MaxPath);
            //PluginPath = p;
#endif
        }

        // translate a controller value (0..65536)
        public static int TranslateMidi(int Value, int Min, int Max)
        {
            int result = (int)((int)Min + (Value * 1.0f / (Max - Min + 1) * (Max - Min + 1))); //explicit cast added in front
            if (result > Max)
            {
                result = Max;
            }
            return result;
        }

#if __APPLE__
#endif

        public static string AppHint = new string(new char[256]);
        //public static string PluginPath = new string(new char[MaxPath]); // path to this DLL plugin (for loading of resources)

        // 4 byte alignment
        public static int AlignBlock_4(int Value)
        {
            int n = 3;
            return (Value + 3) & (~n);
        }

        // 16 byte alignment
        public static int AlignBlock_16(int Value)
        {
            int n = 15;
            return (Value + 15) & (~n);
        }

        // 32 byte alignment
        public static int AlignBlock_32(int Value)
        {
            int n = 31;
            return (Value + 31) & (~n);
        }


        // some constants for TAudioRenderer
        //public static readonly int Ramp_Res_Unit = (int)1.0 / 1000.0; // will take this number of samples to go from 0 to 1 at 44100Hz
        //public static readonly int Ramp_Res_Norm = Ramp_Res_Unit; // source is -1..1 normalized
        //public static readonly int Ramp_Res_Min = (int)Ramp_Res_Unit * 10.0; // source is -1..1 normalized, but quicker ramping, with minimum safety
        //public static readonly int Ramp_Res_FromInt = (int)Ramp_Res_Unit * 32768.0; // source is integer

        // adjust a common param popup (VCL version)
        public static readonly int HintPBMax = 20; // 20 steps for the hint progress bar
        public static readonly int HintPBFirst = 'a';
        public static readonly int HintPBLast = HintPBFirst + HintPBMax;

        public static readonly int CurrentSDKVersion = 1;


        // plugin flags
        public static readonly int FPF_Generator = 1; // plugin is a generator (not effect)
        public static readonly int FPF_RenderVoice = 1 << 1; // generator will render voices separately (Voice_Render) (not used yet)
        public static readonly int FPF_UseSampler = 1 << 2; // 'hybrid' generator that will stream voices into the host sampler (Voice_Render)
        public static readonly int FPF_GetChanCustomShape = 1 << 3; // generator will use the extra shape sample loaded in its parent channel (see FPD_ChanSampleChanged)
        public static readonly int FPF_GetNoteInput = 1 << 4; // plugin accepts note events (not used yet, but effects might also get note input later)
        public static readonly int FPF_WantNewTick = 1 << 5; // plugin will be notified before each mixed tick (& be able to control params (like a built-in MIDI controller) (see NewTick))
        public static readonly int FPF_NoProcess = 1 << 6; // plugin won't process buffers at all (FPF_WantNewTick, or special visual plugins (Fruity NoteBook))
        public static readonly int FPF_NoWindow = 1 << 10; // plugin will show in the channel settings window & not in its own floating window
        public static readonly int FPF_Interfaceless = 1 << 11; // plugin doesn't provide its own interface (not used yet)
        public static readonly int FPF_TimeWarp = 1 << 13; // supports timewarps, that is, can be told to change the playing position in a voice (direct from disk music tracks, ...) (not used yet)
        public static readonly int FPF_MIDIOut = 1 << 14; // plugin will send MIDI out messages (only those will be enabled when rendering to a MIDI file)
        public static readonly int FPF_DemoVersion = 1 << 15; // plugin is a demo version, & the host won't save its automation
        public static readonly int FPF_CanSend = 1 << 16; // plugin has access to the send tracks, so it can't be dropped into a send track or into the master
        public static readonly int FPF_MsgOut = 1 << 17; // plugin will send delayed messages to itself (will require the internal sync clock to be enabled)
        public static readonly int FPF_HybridCanRelease = 1 << 18; // plugin is a hybrid generator & can release its envelope by itself. If the host's volume envelope is disabled, then the sound will keep going when the voice is stopped, until the plugin has finished its own release
        public static readonly int FPF_GetChanSample = 1 << 19; // generator will use the sample loaded in its parent channel (see FPD_ChanSampleChanged)
        public static readonly int FPF_WantFitTime = 1 << 20; // fit to time selector will appear in channel settings window (see FPD_SetFitTime)
        public static readonly int FPF_NewVoiceParams = 1 << 21; // MUST BE USED - tell the host to use TVoiceParams instead of TVoiceParams_Old
        public static readonly int FPF_Reserved1 = 1 << 22; // don't use (Delphi version specific)
        public static readonly int FPF_CantSmartDisable = 1 << 23; // plugin can't be smart disabled
        public static readonly int FPF_WantSettingsBtn = 1 << 24; // plugin wants a settings button on the titlebar (mainly for the wrapper)


        // useful combo's
        public static readonly int FPF_Type_Effect = FPF_NewVoiceParams; // for an effect (Eff_Render)
        public static readonly int FPF_Type_FullGen = FPF_Generator | FPF_GetNoteInput | FPF_NewVoiceParams; // for a full standalone generator (Gen_Render)
        public static readonly int FPF_Type_HybridGen = FPF_Type_FullGen | FPF_UseSampler | FPF_NewVoiceParams; // for an hybrid generator (Voice_Render)
        public static readonly int FPF_Type_Visual = FPF_NoProcess | FPF_NewVoiceParams; // for a visual plugin that doesn't use the wave data


        // plugin dispatcher ID's
        // called from GUI thread unless specified
        public static readonly int FPD_ShowEditor = 0; // shows the editor (ParentHandle in Value)
        public static readonly int FPD_ProcessMode = 1; // sets processing mode flags (flags in value) (can be ignored)
        public static readonly int FPD_Flush = 2; // breaks continuity (empty delay buffers, filter mem, etc.) (warning: can be called from the mixing thread) (GM)
        public static readonly int FPD_SetBlockSize = 3; // max processing length (samples) (in value)
        public static readonly int FPD_SetSampleRate = 4; // sample rate in Value
        public static readonly int FPD_WindowMinMax = 5; // allows the plugin to set the editor window resizable (min/max PRect in index, sizing snap PPoint in value)
        public static readonly int FPD_KillAVoice = 6; // (in case the mixer was eating way too much CPU) the plugin is asked to kill its weakest voice & return 1 if it did something (not used yet)
        public static readonly int FPD_UseVoiceLevels = 7; // return 0 if the plugin doesn't support the default per-voice level Index
                                                           // return 1 if the plugin supports the default per-voice level Index (filter cutoff (0) or filter resonance (1))
                                                           // return 2 if the plugin supports the per-voice level Index, but for another function (then check FPN_VoiceLevel)
                                                           //=8;     (private message)
        public static readonly int FPD_SetPreset = 9; // set internal preset Index (mainly for wrapper)
        public static readonly int FPD_ChanSampleChanged = 10; // (see FPF_GetChanCustomShape) sample has been loaded into the parent channel, & given to the plugin
                                                               // either as a wavetable (FPF_GetChanCustomshape) (pointer to shape in Value, same format as WaveTables)
                                                               // or as a sample (FPF_GetChanSample) (TSampleHandle in Index)
        public static readonly int FPD_SetEnabled = 11; // the host has enabled/disabled the plugin (state in Value) (warning: can be called from the mixing thread) (GM)
        public static readonly int FPD_SetPlaying = 12; // the host is playing (song pos info is valid when playing) (state in Value) (warning: can be called from the mixing thread) (GM)
        public static readonly int FPD_SongPosChanged = 13; // song position has been relocated (by other means than by playing of course) (warning: can be called from the mixing thread) (GM)
        public static readonly int FPD_SetTimeSig = 14; // PTimeSigInfo in Value (G)
        public static readonly int FPD_CollectFile = 15; // let the plugin tell which files need to be collected or put in zip files. File # in Index, starts from 0 until no more filenames are returned (PChar in Result).
        public static readonly int FPD_SetInternalParam = 16; // (private message to known plugins, ignore) tells the plugin to update a specific, non-automated param
        public static readonly int FPD_SetNumSends = 17; // tells the plugin how many send tracks there are (fixed to 4, but could be set by the user at any time in a future update) (number in Value) (!!! will be 0 if the plugin is in the master or a send track, since it can't access sends)
        public static readonly int FPD_LoadFile = 18; // when a file has been dropped onto the parent channel's button (filename in Value)
        public static readonly int FPD_SetFitTime = 19; // set fit to time in beats (FLOAT time in value (need to typecast))
        public static readonly int FPD_SetSamplesPerTick = 20; // # of samples per tick (changes when tempo, PPQ or sample rate changes) (FLOAT in Value (need to typecast)) (warning: can be called from the mixing thread) (GM)
        public static readonly int FPD_SetIdleTime = 21; // set the freq at which Idle is called (can vary), ms time in Value
        public static readonly int FPD_SetFocus = 22; // the host has focused/unfocused the editor (focused in Value) (plugin can use this to steal keyboard focus)
        public static readonly int FPD_Transport = 23; // special transport messages, from a controller. See GenericTransport.pas for Index. Must return 1 if handled.
        public static readonly int FPD_MIDIIn = 24; // live MIDI input preview, allows the plugin to steal messages (mostly for transport purposes). Must return 1 if handled. Packed message (only note on/off for now) in Value.
        public static readonly int FPD_RoutingChanged = 25; // mixer routing changed, must check FHD_GetInOuts if necessary
        public static readonly int FPD_GetParamInfo = 26; // retrieves info about a parameter. Param number in Index, see PI_Float for the result
        public static readonly int FPD_ProjLoaded = 27; // called after a project has been loaded, to leave a chance to kill automation (that could be loaded after the plugin is created) if necessary
        public static readonly int FPD_WrapperLoadState = 28; // (private message to the plugin wrapper) load a (VST1, DX) plugin state, pointer in Index, length in Value
        public static readonly int FPD_ShowSettings = 29; // called when the settings button on the titlebar is switched. On/off in Value (1=active). See FPF_WantSettingsBtn
        public static readonly int FPD_SetIOLatency = 30; // input/output latency (Index,Value) of the output, in samples (only for information)
        public static readonly int FPD_PreferredNumIO = 32; // (message from Patcher) retrieves the preferred number (0=default, -1=none) of audio inputs (Index=0), audio outputs (Index=1) or voice outputs (Index=2)


        // GetName sections
        public static readonly int FPN_Param = 0; // retrieve name of param Index
        public static readonly int FPN_ParamValue = 1; // retrieve text label of param Index for value Value (used in event editor)
        public static readonly int FPN_Semitone = 2; // retrieve name of note Index (used in piano roll), for color (=MIDI channel) Value
        public static readonly int FPN_Patch = 3; // retrieve name of patch Index (not used yet)
        public static readonly int FPN_VoiceLevel = 4; // retrieve name of per-voice param Index (default is filter cutoff (0) & resonance (1)) (optional)
        public static readonly int FPN_VoiceLevelHint = 5; // longer description for per-voice param (works like FPN_VoiceLevels)
        public static readonly int FPN_Preset = 6; // for plugins that support internal presets (mainly for the wrapper plugin), retrieve the name for program Index
        public static readonly int FPN_OutCtrl = 7; // for plugins that output controllers, retrieve the name of output controller Index
        public static readonly int FPN_VoiceColor = 8; // retrieve name of per-voice color (MIDI channel) Index
        public static readonly int FPN_OutVoice = 9; // for plugins that output voices, retrieve the name of output voice Index


        // processing mode flags
        public static readonly int PM_Normal = 0; // realtime processing (default)
        public static readonly int PM_HQ_Realtime = 1; // high quality, but still realtime processing
        public static readonly int PM_HQ_NonRealtime = 2; // non realtime processing (CPU does not matter, quality does) (normally set when rendering only)
        public static readonly int PM_IsRendering = 16; // is rendering if this flag is set
                                                        //const int PM_IPMask             =7 << 8;  // 3 bits value for interpolation quality (0=none (obsolete), 1=linear, 2=6 point hermite (default), 3=32 points sinc, 4=64 points sinc, 5=128 points sinc, 6=256 points sinc)
        public static readonly int PM_IPMask = 0xFFFF << 8; // 16 bits value for interpolation number of points


        // ProcessParam flags
        public static readonly int REC_UpdateValue = 1; // update the value
        public static readonly int REC_GetValue = 2; // retrieves the value
        public static readonly int REC_ShowHint = 4; // updates the hint (if any)
        public static readonly int REC_UpdateControl = 16; // updates the wheel/knob
        public static readonly int REC_FromMIDI = 32; // value from 0 to 65536 has to be translated (& always returned, even if REC_GetValue isn't set)
        public static readonly int REC_NoLink = 1024; // don't check if wheels are linked (internal to plugins, useful for linked controls)
        public static readonly int REC_InternalCtrl = 2048; // sent by an internal controller - internal controllers should pay attention to those, to avoid nasty feedbacks
        public static readonly int REC_PlugReserved = 4096; // free to use by plugins


        // event ID's
        public static readonly int FPE_Tempo = 0; // FLOAT tempo in value (need to typecast), & average samples per tick in Flags (DWORD) (warning: can be called from the mixing thread) (GM)
        public static readonly int FPE_MaxPoly = 1; // max poly in value (infinite if <=0) (only interesting for standalone generators)
                                                    // since MIDI plugins, or other plugin wrappers won't support the voice system, they should be notified about channel pan, vol & pitch changes
        public static readonly int FPE_MIDI_Pan = 2; // MIDI channel panning (0..127) in EventValue + pan in -64..64 in Flags (warning: can be called from the mixing thread) (GM)
        public static readonly int FPE_MIDI_Vol = 3; // MIDI channel volume (0..127) in EventValue + volume as normalized float in Flags (need to typecast) (warning: can be called from the mixing thread) (GM)
        public static readonly int FPE_MIDI_Pitch = 4; // MIDI channel pitch in *cents* (to be translated according to current pitch bend range) in EventValue (warning: can be called from the mixing thread) (GM)


        // voice handles
        public static readonly int FVH_Null = -1;

        // TFruityPlug.Voice_ProcessEvent ID's
        public static readonly int FPV_Retrigger = 0; // monophonic mode can retrigger releasing voices (not used yet)

        // TFruityPlugHost.Voice_ProcessEvent ID's
        public static readonly int FPV_GetLength = 1; // retrieve length in ticks (not reliable) in Result (-1 if undefined)
        public static readonly int FPV_GetColor = 2; // retrieve color (0..15) in Result, can be mapped to MIDI channel
        public static readonly int FPV_GetVelocity = 3; // retrieve note on velocity (0..1) in Result (typecast as a float) (this is computed from InitLevels.Vol)
        public static readonly int FPV_GetRelVelocity = 4; // retrieve release velocity (0..1) in Result (typecast as a float) (to be called from Voice_Release) (use this if some release velocity mapping is involved)
        public static readonly int FPV_GetRelTime = 5; // retrieve release time multiplicator (0..2) in Result (typecast as a float) (to be called from Voice_Release) (use this for direct release multiplicator)
        public static readonly int FPV_SetLinkVelocity = 6; // set if velocity is linked to volume or not (in EventValue)


        // Voice_Render function results
        public static readonly int FVR_Ok = 0;
        public static readonly int FVR_NoMoreData = 1; // for sample streaming, when there's no more sample data to fill any further buffer (the voice will then be killed by the host)


        // host dispatcher ID's
        public static readonly int FHD_ParamMenu = 0; // the popup menu for each control (Index=param index, Value=popup item index (see FHP_EditEvents))
        public static readonly int FHD_GetParamMenuFlags = 1; // (OBSOLETE, see FHD_GetParamMenuEntry) before the popup menu is shown, you must ask the host to tell if items are checked or disabled (Index=param index, Value=popup item index, Result=flags (see FHP_Disabled))
        public static readonly int FHD_EditorResized = 2; // to notify the host that the editor (EditorHandle) has been resized
        public static readonly int FHD_NamesChanged = 3; // to notify the host that names (GetName function) have changed, with the type of names in Value (see the FPN_ constants)
    }
}