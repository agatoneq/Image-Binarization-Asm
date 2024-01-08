using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binarization
{
    internal static class Program
    {
        [DllImport(@"C:\Users\agata\source\repos\JA_Binarization\Binarization\x64\Debug\JAAsm.dll")]
        public static extern void binarization(double[] mm0, double[] mm1, double[] result);

        [STAThread]
        static void Main()
        {
                      double[] mm0 = {0.3, 0.59, 0.11};
            double[] mm1 = {1, 2, 3};
            double[] result = new double[3];

            // OR
            binarization(mm0, mm1, result);
            Console.WriteLine("Wynik operacji:");
            foreach (double b in result)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine();

/*            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
        }
    }
}
