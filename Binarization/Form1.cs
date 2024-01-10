using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Binarization
{
    public partial class FormBinarization : Form
    {
        [DllImport(@"C:\Users\agata\source\repos\JA_Binarization\Binarization\x64\Debug\JAAsm.dll")]
        public static extern void binarization(IntPtr ptrScanForCurBitmap, IntPtr ptrScanForFinalBitmap, int size);

        

        private string curFileName;
        // This is a bitmap object.
        private System.Drawing.Bitmap curBitmap;

        public FormBinarization()
        {
            InitializeComponent();
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
            //openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = @"C:\\Users\\agata\\OneDrive\\Pulpit\\test";

            // Pokazuje okno dialogowe i sprawdza, czy użytkownik nacisnął przycisk OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Pobranie ścieżki do wybranego pliku
                string selectedFilePath = openFileDialog.FileName;

                // Tutaj możesz wykorzystać ścieżkę do pliku
                // np. przypisać do TextBox, przekazać do innych funkcji itp.
               // Binarization binarization = new Binarization(selectedFilePath);
                //binarization.path = selectedFilePath;
                curFileName = openFileDialog.FileName;
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                try
                {
                    // Ustawienie obrazu w PictureBox
                    initialPicture.Image = Image.FromFile(selectedFilePath);

                    // Opcjonalnie, możesz dostosować rozmiar PictureBox do rozmiaru wczytanego obrazu
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

                   /* // Red
                    int iR = 0;
                    // Green
                    int iG = 0;
                    // Blue
                    int iB = 0;

                    // Lock the bitmap's bits.  
                    Rectangle rect = new Rectangle(0, 0, curBitmap.Width, curBitmap.Height);
                    System.Drawing.Imaging.BitmapData bmpData =
                        curBitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                        curBitmap.PixelFormat);

                    // Get the address of the first line.
                    IntPtr ptr = bmpData.Scan0;

                    // Declare an array to hold the bytes of the bitmap.
                    int bytes = Math.Abs(bmpData.Stride) * curBitmap.Height;
                    byte[] rgbValues = new byte[bytes];

                    // Copy the RGB values into the array.
                    System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                    // Set every third value to 255. A 24bpp bitmap will binarization.  
                    for (int counter = 0; counter < rgbValues.Length; counter += 3)
                    {
                        // Get the red channel
                        iR = rgbValues[counter + 2];
                        // Get the green channel
                        iG = rgbValues[counter + 1];
                        // Get the blue channel
                        iB = rgbValues[counter + 0];
                        // If the gray value more than threshold and then set a white pixel.
                        if ((iR + iG + iB) / 3 > 100)
                        {
                            // White pixel
                            rgbValues[counter + 2] = 255;
                            rgbValues[counter + 1] = 255;
                            rgbValues[counter + 0] = 255;
                        }
                        else
                        {
                            // Black pixel
                            rgbValues[counter + 2] = 0;
                            rgbValues[counter + 1] = 0;
                            rgbValues[counter + 0] = 0;
                        }
                    }

                    // Copy the RGB values back to the bitmap
                    System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

                    // Unlock the bits.
                    curBitmap.UnlockBits(bmpData);

                // Draw the modified image.
                finalPicture.Image = curBitmap;
                finalPicture.SizeMode = PictureBoxSizeMode.Zoom;*/

                
                /*                                // Tworzenie nowego obiektu Bitmap do przechowywania zbinaryzowanego obrazu
                                                Bitmap binaryBitmap = new Bitmap(curBitmap.Width, curBitmap.Height);

                                                // Iteracja po każdym pikselu obrazu
                                                for (int i = 0; i < curBitmap.Width; i++)
                                                {
                                                    for (int j = 0; j < curBitmap.Height; j++)
                                                    {
                                                        // Pobierz kolor piksela
                                                        Color pixelColor = curBitmap.GetPixel(i, j);

                                                        // Przekształć na odcień szarości
                                                        int grayValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);

                                                        // Binaryzacja - jeśli wartość szarości przekracza próg, ustaw na biały, w przeciwnym razie na czarny
                                                        Color newColor = (grayValue > thresholdTrackBar.Value) ? Color.White : Color.Black;

                                                        // Ustaw nowy kolor piksela na nowym obrazie
                                                        binaryBitmap.SetPixel(i, j, newColor);
                                                    }
                                                }

                                                // Przypisanie zbinaryzowanego obrazu do PictureBox
                                                finalPicture.Image = binaryBitmap;
                                                finalPicture.SizeMode = PictureBoxSizeMode.Zoom;*/





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

                                //int[] mm0 = { 11, 59, 30 };

                                DateTime startASM = DateTime.Now;
                                binarization(ptrScanForCurBitmap, ptrScanForFinalBitmap, size);
                                DateTime endASM = DateTime.Now;
                                TimeSpan tsASM = (endASM - startASM);

                                curBitmap.UnlockBits(dataOfCurBitmap);
                                finalBitmap.UnlockBits(dataOffinalBitmap);

                                finalBitmap.Save("C:\\Users\\agata\\OneDrive\\Pulpit\\test\\Result.jpg");
                                // Możemy także wyświetlić wygenerowaną liczbę

                                finalPicture.Image = finalBitmap;
                                finalPicture.SizeMode = PictureBoxSizeMode.Zoom;

            }

  

        }

        private void thresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            // thresholdLabel.Text = $"Threshold: {thresholdTrackBar.Value}";

            // Wywołaj funkcję binaryzacji przy każdej zmianie progu
            confirmButton_Click(sender, e);
        }
    }
}


