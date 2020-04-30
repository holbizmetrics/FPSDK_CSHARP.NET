//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack(push)
//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma pack(1)

namespace FLStudioSDK
{
    public class TILNoteParams
    {
        public int32_t Position = new int32_t(); // in PPQ
        public int32_t Length = new int32_t(); // in PPQ
        // levels
        public int32_t Pan = new int32_t(); // default=0
        public float Vol; // default=100/128
        public int16_t Note = new int16_t(); // default=60
        public int16_t Color = new int16_t(); // 0..15 (= MIDI channel)
        public int32_t Pitch = new int32_t(); // default=0
        public float FCut; // default=0
        public float FRes; // default=0
    }

    public class TILNotesParams
    {
        public int32_t Target = new int32_t(); // see NPT_PianoRoll
        public int32_t Flags = new int32_t(); // see NPF_EmptyFirst
        public int32_t PatNum = new int32_t(); // -1 for current
        public int32_t ChanNum = new int32_t(); // -1 for plugin's channel, or selected channel if plugin is an effect
        public int32_t Count = new int32_t(); // the # of notes in the structure
        public TILNoteParams[] NoteParams = Arrays.InitializeWithDefaultInstances<TILNoteParams>(1); // array of notes
    }
}