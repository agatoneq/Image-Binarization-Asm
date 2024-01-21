using System;
using System.Threading.Tasks;

namespace JABinar
{
    public class BinarizationAlgorithm
    {
        public void binarize(IntPtr inputPtr, int threshold, IntPtr outputPtr, int size, ParallelOptions options)
        {
            unsafe
            {
                byte[] inputValues = new byte[size];
                byte[] outputValues = new byte[size];

                // Copy input values from memory to array
                System.Runtime.InteropServices.Marshal.Copy(inputPtr, inputValues, 0, size);

                Parallel.For(0, size, options, i =>
                {
                    if(i%3==0)
                    {
                        // Calculate grayscale value
                        int grayValue = (inputValues[i + 2] + inputValues[i + 1] + inputValues[i]) / 3;

                        // Binarize based on the threshold
                        if (grayValue > threshold)
                        {
                            outputValues[i + 2] = 255; // Set red channel to white
                            outputValues[i + 1] = 255; // Set green channel to white
                            outputValues[i] = 255;     // Set blue channel to white
                        }
                        else
                        {
                            outputValues[i + 2] = 0;   // Set red channel to black
                            outputValues[i + 1] = 0;   // Set green channel to black
                            outputValues[i] = 0;       // Set blue channel to black
                        }
                     }
                });
                
                // Copy output values from array to memory
                System.Runtime.InteropServices.Marshal.Copy(outputValues, 0, outputPtr, size);
            }
        }
    }
}