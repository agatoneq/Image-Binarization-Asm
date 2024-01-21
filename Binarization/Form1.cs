using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using JABinar;

namespace Binarization
{
    public partial class FormBinarization : Form
    {
        [DllImport(@"C:\Users\agata\source\repos\JA_Binarization\Binarization\x64\Debug\JAAsm.dll")]
        public static extern void binarization(IntPtr ptrScanForFinalBitmap, int[] tabR, int[] tabG, int[] tabB, int size, int threshold);

        private string curFileName;
        private System.Drawing.Bitmap curBitmap;

        public FormBinarization()
        {
            InitializeComponent();
            threadsBar.Value = Environment.ProcessorCount;
            asmValue.Text = thresholdTrackBarAsm.Value.ToString();
            csValue.Text = thresholdTrackBarCs.Value.ToString();
            threadsValue.Text = threadsBar.Value.ToString();
        }

        private void binarizeCs()
        {
            unsafe
            {
                if (curBitmap != null)
                {
                    ParallelOptions options = new ParallelOptions
                    {
                        MaxDegreeOfParallelism = threadsBar.Value
                    };
                   
                        Bitmap finalBitmap = new Bitmap(curBitmap.Width, curBitmap.Height);

                    // Lock the bitmap's bits.  
                    Rectangle rectOfCurBitmap = new Rectangle(0, 0, finalBitmap.Width, finalBitmap.Height);
                    BitmapData dataOfCurBitmap = curBitmap.LockBits(rectOfCurBitmap, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    int size = Math.Abs(dataOfCurBitmap.Stride) * curBitmap.Height;
                    // Get the address of the first line.
                    IntPtr ptrScanForCurBitmap = dataOfCurBitmap.Scan0;

                    // Lock the bitmap's bits.  
                    Rectangle rectOffinalBitmap = new Rectangle(0, 0, finalBitmap.Width, finalBitmap.Height);
                    BitmapData dataOffinalBitmap = finalBitmap.LockBits(rectOffinalBitmap, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    // Get the address of the first line.

                    IntPtr ptrScanForFinalBitmap = dataOffinalBitmap.Scan0;

                    int thresholdCs = thresholdTrackBarCs.Value;

                    DateTime startCs = DateTime.Now;
                    BinarizationAlgorithm algorithm = new BinarizationAlgorithm();
                    algorithm.binarize(ptrScanForCurBitmap, thresholdCs, ptrScanForFinalBitmap, size, options);
                    DateTime endCs = DateTime.Now;
                    TimeSpan timeCs = (endCs - startCs);
                    CTime.Text = timeCs.ToString();
                    
                    curBitmap.UnlockBits(dataOfCurBitmap);
                    finalBitmap.UnlockBits(dataOffinalBitmap);

                    finalBitmap.Save("C:\\Users\\agata\\OneDrive\\Pulpit\\test\\result.jpg");

                    finalPicture.Image = finalBitmap;
                    finalPicture.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void binarizeAsm()
        {
            unsafe
            {
                if (curBitmap != null)
                {
                    Bitmap finalBitmap = new Bitmap(curBitmap.Width, curBitmap.Height);

                    // Lock the bitmap's bits.
                    Rectangle rectOfCurBitmap = new Rectangle(0, 0, finalBitmap.Width, finalBitmap.Height);
                    BitmapData dataOfCurBitmap = curBitmap.LockBits(rectOfCurBitmap, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    int size = Math.Abs(dataOfCurBitmap.Stride) * curBitmap.Height;
                    // Get the address of the first line.
                    IntPtr ptrScanForCurBitmap = dataOfCurBitmap.Scan0;

                    // Lock the bitmap's bits.
                    Rectangle rectOffinalBitmap = new Rectangle(0, 0, finalBitmap.Width, finalBitmap.Height);
                    BitmapData dataOffinalBitmap = finalBitmap.LockBits(rectOffinalBitmap, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    // Get the address of the first line.
                    IntPtr ptrScanForFinalBitmap = dataOffinalBitmap.Scan0;

                    curBitmap.UnlockBits(dataOfCurBitmap);


                    int thresholdAsm = thresholdTrackBarAsm.Value;

                    DateTime startAsm = DateTime.Now;

                    int[] redChannel = new int[size / 3];
                    int[] greenChannel = new int[size / 3];
                    int[] blueChannel = new int[size / 3];

                    int index = 0;
                    int index2 = 0;
                    int index3 = 0;


                    // Iteruj po pikselach obrazu
                    for (int y = 0; y < curBitmap.Height; y++)
                    {
                        for (int x = 0; x < curBitmap.Width; x++)
                        {
                            // Pobierz wartości składowych koloru piksela
                            Color pixel = curBitmap.GetPixel(x, y);

                            if (index < redChannel.Length)
                                redChannel[index++] = (int)pixel.R;
                            if (index2 < greenChannel.Length)
                                greenChannel[index2++] = (int)pixel.G;
                            if (index3 < blueChannel.Length)
                                blueChannel[index3++] = (int)pixel.B;

                        }
                    }

                    binarization(ptrScanForFinalBitmap, redChannel, greenChannel, blueChannel, size+size/3, thresholdAsm);

                    DateTime endAsm = DateTime.Now;
                    TimeSpan timeAsm = (endAsm - startAsm);
                    asmTime.Text = timeAsm.ToString();

                    //curBitmap.UnlockBits(dataOfCurBitmap);
                    finalBitmap.UnlockBits(dataOffinalBitmap);

                    finalBitmap.Save("C:\\Users\\agata\\OneDrive\\Pulpit\\test\\result.jpg");
                    finalPicture.Image = finalBitmap;
                    finalPicture.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }


        private void PickImageButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "All format | *.bmp; *.pcx; *.png; *.jpg; *.gif;" +
        "*.tif; *.ico; *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf";
            openFileDialog.Title = "Wybieranie obrazu";
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = @"C:\\Users\\agata\\OneDrive\\Pulpit\\test";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                curFileName = openFileDialog.FileName;
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                try
                {
                    initialPicture.Image = Image.FromFile(selectedFilePath);

                    initialPicture.SizeMode = PictureBoxSizeMode.Zoom;
                    curBitmap = (Bitmap)Image.FromFile(curFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas wczytywania obrazu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (curBitmap != null)
            {
                if (libraryName.Text == "C#")
                {
                    binarizeCs();
                }

                else if (libraryName.Text == "Asm")
                {
                    binarizeAsm();
                }
            }
        }

        private void thresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            csValue.Text = thresholdTrackBarCs.Value.ToString();
            binarizeCs();
        }

        private void thresholdTrackBarAsm_Scroll(object sender, EventArgs e)
        {
            asmValue.Text = thresholdTrackBarAsm.Value.ToString();
            binarizeAsm();
        }

        private void threadsBar_Scroll(object sender, EventArgs e)
        {
            threadsValue.Text = threadsBar.Value.ToString();
            binarizeCs();
        }
    }
}