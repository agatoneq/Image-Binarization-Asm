namespace Binarization
{
    partial class FormBinarization
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.confirmButton = new System.Windows.Forms.Button();
            this.libraryName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.asmTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CTime = new System.Windows.Forms.Label();
            this.thresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PickImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.finalPicture = new System.Windows.Forms.PictureBox();
            this.initialPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(45, 174);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(102, 23);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // libraryName
            // 
            this.libraryName.FormattingEnabled = true;
            this.libraryName.Items.AddRange(new object[] {
            "Asm",
            "C#"});
            this.libraryName.Location = new System.Drawing.Point(26, 119);
            this.libraryName.Name = "libraryName";
            this.libraryName.Size = new System.Drawing.Size(121, 24);
            this.libraryName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "C#:";
            // 
            // asmTime
            // 
            this.asmTime.AutoSize = true;
            this.asmTime.Location = new System.Drawing.Point(13, 373);
            this.asmTime.Name = "asmTime";
            this.asmTime.Size = new System.Drawing.Size(39, 17);
            this.asmTime.TabIndex = 5;
            this.asmTime.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Czas wykonania:";
            // 
            // CTime
            // 
            this.CTime.AutoSize = true;
            this.CTime.Location = new System.Drawing.Point(13, 291);
            this.CTime.Name = "CTime";
            this.CTime.Size = new System.Drawing.Size(39, 17);
            this.CTime.TabIndex = 7;
            this.CTime.Text = "Time";
            // 
            // thresholdTrackBar
            // 
            this.thresholdTrackBar.Location = new System.Drawing.Point(125, 540);
            this.thresholdTrackBar.Maximum = 255;
            this.thresholdTrackBar.Name = "thresholdTrackBar";
            this.thresholdTrackBar.Size = new System.Drawing.Size(625, 56);
            this.thresholdTrackBar.TabIndex = 10;
            this.thresholdTrackBar.Value = 128;
            this.thresholdTrackBar.Scroll += new System.EventHandler(this.thresholdTrackBar_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wybierz bibliotekę:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PickImage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.libraryName);
            this.panel1.Controls.Add(this.confirmButton);
            this.panel1.Controls.Add(this.asmTime);
            this.panel1.Controls.Add(this.CTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 425);
            this.panel1.TabIndex = 13;
            // 
            // PickImage
            // 
            this.PickImage.Location = new System.Drawing.Point(16, 12);
            this.PickImage.Name = "PickImage";
            this.PickImage.Size = new System.Drawing.Size(203, 23);
            this.PickImage.TabIndex = 14;
            this.PickImage.Text = "Wybierz obraz do binaryzacji";
            this.PickImage.UseVisualStyleBackColor = true;
            this.PickImage.Click += new System.EventHandler(this.PickImageButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Asm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.finalPicture);
            this.panel2.Controls.Add(this.initialPicture);
            this.panel2.Controls.Add(this.thresholdTrackBar);
            this.panel2.Location = new System.Drawing.Point(240, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 599);
            this.panel2.TabIndex = 14;
            // 
            // finalPicture
            // 
            this.finalPicture.Location = new System.Drawing.Point(448, 3);
            this.finalPicture.Name = "finalPicture";
            this.finalPicture.Size = new System.Drawing.Size(439, 510);
            this.finalPicture.TabIndex = 12;
            this.finalPicture.TabStop = false;
            // 
            // initialPicture
            // 
            this.initialPicture.Location = new System.Drawing.Point(3, 3);
            this.initialPicture.Name = "initialPicture";
            this.initialPicture.Size = new System.Drawing.Size(439, 510);
            this.initialPicture.TabIndex = 11;
            this.initialPicture.TabStop = false;
            // 
            // FormBinarization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormBinarization";
            this.Text = "Binarization";
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ComboBox libraryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label asmTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CTime;
        private System.Windows.Forms.TrackBar thresholdTrackBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox initialPicture;
        private System.Windows.Forms.PictureBox finalPicture;
        private System.Windows.Forms.Button PickImage;
    }
}