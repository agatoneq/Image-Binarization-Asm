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
using JABinar;

namespace Binarization
{
    public partial class FormBinarization : Form
    {
        [DllImport(@"C:\Users\agata\source\repos\JA_Binarization\Binarization\x64\Debug\JAAsm.dll")]
        public static extern void binarization(IntPtr ptrScanForCurBitmap, int x, IntPtr ptrScanForFinalBitmap, int size);

        private string curFileName;
        // This is a bitmap object.
        private System.Drawing.Bitmap curBitmap;

        public FormBinarization()
        {
            InitializeComponent();
            asmValue.Text = thresholdTrackBarAsm.Value.ToString();
            csValue.Text = thresholdTrackBarCs.Value.ToString();
        }

        private void binarizeCs()
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

                int thresholdCs = thresholdTrackBarCs.Value;

                    DateTime startCs = DateTime.Now;
                    BinarizationAlgorithm algorithm = new BinarizationAlgorithm();
                    algorithm.binarize(ptrScanForCurBitmap, thresholdCs, ptrScanForFinalBitmap, size);
                    DateTime endCs = DateTime.Now;
                    TimeSpan timeCs = (endCs - startCs);
                    CTime.Text = timeCs.ToString();
                
                curBitmap.UnlockBits(dataOfCurBitmap);
                finalBitmap.UnlockBits(dataOffinalBitmap);

                finalBitmap.Save("C:\\Users\\agata\\OneDrive\\Pulpit\\test\\result.jpg");
                // Możemy także wyświetlić wygenerowaną liczbę

                finalPicture.Image = finalBitmap;
                finalPicture.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void binarizeAsm()
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

                int thresholdAsm = thresholdTrackBarAsm.Value;

                    DateTime startAsm = DateTime.Now;
                    binarization(ptrScanForCurBitmap, thresholdAsm, ptrScanForFinalBitmap, size);
                    DateTime endAsm = DateTime.Now;
                    TimeSpan timeAsm = (endAsm - startAsm);
                    asmTime.Text = timeAsm.ToString();
                
                curBitmap.UnlockBits(dataOfCurBitmap);
                finalBitmap.UnlockBits(dataOffinalBitmap);

                finalBitmap.Save("C:\\Users\\agata\\OneDrive\\Pulpit\\test\\result.jpg");
                // Możemy także wyświetlić wygenerowaną liczbę

                finalPicture.Image = finalBitmap;
                finalPicture.SizeMode = PictureBoxSizeMode.Zoom;
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
            //confirmButton_Click(sender, e);
            binarizeCs();
        }

        private void thresholdTrackBarAsm_Scroll(object sender, EventArgs e)
        {
            asmValue.Text = thresholdTrackBarAsm.Value.ToString();
            //confirmButton_Click(sender, e);
            binarizeAsm();
        }

    }
}


