//----------------------------------------------------------------------------------------
//	This class includes methods to convert C++ rectangular arrays (jagged arrays
//	with inner arrays of the same length).
//----------------------------------------------------------------------------------------
namespace FLStudioSDK
{
    internal static class RectangularArrays
    {
        public static float[][][] RectangularFloatArray(int size1, int size2, int size3)
        {
            float[][][] newArray = new float[size1][][];
            for (int array1 = 0; array1 < size1; array1++)
            {
                newArray[array1] = new float[size2][];
                if (size3 > -1)
                {
                    for (int array2 = 0; array2 < size2; array2++)
                    {
                        newArray[array1][array2] = new float[size3];
                    }
                }
            }

            return newArray;
        }
    }
}