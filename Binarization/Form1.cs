using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binarization
{
    public partial class Form1 : Form
    {
        private string curFileName;
        // This is a bitmap object.
        private System.Drawing.Bitmap curBitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void PickImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "All format | *.bmp; *.pcx; *.png; *.jpg; *.gif;" +
        "*.tif; *.ico; *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf";
            openFileDialog.Title = "Wybieranie obrazu";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

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
                // Tworzenie nowego obiektu Bitmap do przechowywania zbinaryzowanego obrazu
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


