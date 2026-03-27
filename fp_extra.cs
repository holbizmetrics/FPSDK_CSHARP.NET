using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLStudioSDK
{
    public struct T32Bit
    {
        public int i;
        public float s;
        public byte[] buffer;
    }

    public static class Constants
    {
        public const int MaxPath = 1024;
        public const double NoteMul = 0.00057762267534;
        public const int MixSmpRate_Default = 44100;
        public const double MiddleCFreq = 523.251130601197;
        public const double MiddleCMul = 0x10000000 * MiddleCFreq * 0x10;
        public const double Div2 = 0.5;
        public const double Div4 = 0.25;
        public const double Div8 = 0.125;
        public const double Div10 = 0.1;
        public const double Div100 = 0.01;
        public const double Div128 = 1.0 / 128.0;
        public const double Div256 = 1.0 / 256.0;
        public const double Div1024 = 1.0 / 1024.0;
    }

    public static class HelperFunctions
    {
        public static int MinOf(int a, int b)
        {
            return Math.Min(a, b);
        }

        public static float VolumeToVelocity(float Volume)
        {
            // Implement the logic for VolumeToVelocity
            throw new NotImplementedException();
        }

        public static float VolumeToMIDIVelocity(float Volume)
        {
            // Implement the logic for VolumeToMIDIVelocity
            throw new NotImplementedException();
        }
    }
}
