using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace JABinar
{
    public class BinarizationAlgorithm
    {
        public void binarize(IntPtr inputPtr, int threshold, IntPtr outputPtr, int size)
        {
            byte[] inputValues = new byte[size];
            byte[] outputValues = new byte[size];

            // Copy input values from memory to array
            System.Runtime.InteropServices.Marshal.Copy(inputPtr, inputValues, 0, size);

            for (int i = 0; i < size; i += 3)
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

            // Copy output values from array to memory
            System.Runtime.InteropServices.Marshal.Copy(outputValues, 0, outputPtr, size);
        }

    }
}
