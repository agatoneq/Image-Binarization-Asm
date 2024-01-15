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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBinarization));
            this.confirmButton = new System.Windows.Forms.Button();
            this.libraryName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.asmTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CTime = new System.Windows.Forms.Label();
            this.thresholdTrackBarCs = new System.Windows.Forms.TrackBar();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.thresholdTrackBarAsm = new System.Windows.Forms.TrackBar();
            this.threadsValue = new System.Windows.Forms.Label();
            this.csValue = new System.Windows.Forms.Label();
            this.asmValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBarCs)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPicture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBarAsm)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmButton.Location = new System.Drawing.Point(14, 221);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(193, 40);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // libraryName
            // 
            this.libraryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.libraryName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libraryName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.libraryName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.libraryName.FormattingEnabled = true;
            this.libraryName.Items.AddRange(new object[] {
            "Asm",
            "C#"});
            this.libraryName.Location = new System.Drawing.Point(14, 96);
            this.libraryName.Name = "libraryName";
            this.libraryName.Size = new System.Drawing.Size(191, 33);
            this.libraryName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "C#:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // asmTime
            // 
            this.asmTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.asmTime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.asmTime.Location = new System.Drawing.Point(1236, 140);
            this.asmTime.Name = "asmTime";
            this.asmTime.Size = new System.Drawing.Size(285, 56);
            this.asmTime.TabIndex = 5;
            this.asmTime.Text = " ";
            this.asmTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1236, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 56);
            this.label3.TabIndex = 6;
            this.label3.Text = "Czas wykonania:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CTime
            // 
            this.CTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CTime.Location = new System.Drawing.Point(1231, 78);
            this.CTime.Name = "CTime";
            this.CTime.Size = new System.Drawing.Size(290, 56);
            this.CTime.TabIndex = 7;
            this.CTime.Text = " ";
            this.CTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thresholdTrackBarCs
            // 
            this.thresholdTrackBarCs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thresholdTrackBarCs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thresholdTrackBarCs.Location = new System.Drawing.Point(228, 78);
            this.thresholdTrackBarCs.Maximum = 255;
            this.thresholdTrackBarCs.Name = "thresholdTrackBarCs";
            this.thresholdTrackBarCs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.thresholdTrackBarCs.Size = new System.Drawing.Size(874, 56);
            this.thresholdTrackBarCs.TabIndex = 10;
            this.thresholdTrackBarCs.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.thresholdTrackBarCs.Value = 128;
            this.thresholdTrackBarCs.Scroll += new System.EventHandler(this.thresholdTrackBar_Scroll);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(9, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 70);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wybierz bibliotekę początkową:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PickImage);
            this.panel1.Controls.Add(this.confirmButton);
            this.panel1.Controls.Add(this.libraryName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 524);
            this.panel1.TabIndex = 13;
            // 
            // PickImage
            // 
            this.PickImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PickImage.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PickImage.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PickImage.Location = new System.Drawing.Point(12, 143);
            this.PickImage.Name = "PickImage";
            this.PickImage.Size = new System.Drawing.Size(193, 62);
            this.PickImage.TabIndex = 14;
            this.PickImage.Text = "Wybierz obraz do binaryzacji";
            this.PickImage.UseVisualStyleBackColor = false;
            this.PickImage.Click += new System.EventHandler(this.PickImageButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 56);
            this.label2.TabIndex = 13;
            this.label2.Text = "Asembler:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.finalPicture);
            this.panel2.Controls.Add(this.initialPicture);
            this.panel2.Location = new System.Drawing.Point(240, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1311, 524);
            this.panel2.TabIndex = 14;
            // 
            // finalPicture
            // 
            this.finalPicture.Location = new System.Drawing.Point(659, 3);
            this.finalPicture.Name = "finalPicture";
            this.finalPicture.Size = new System.Drawing.Size(650, 510);
            this.finalPicture.TabIndex = 12;
            this.finalPicture.TabStop = false;
            // 
            // initialPicture
            // 
            this.initialPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.initialPicture.Location = new System.Drawing.Point(3, 3);
            this.initialPicture.Name = "initialPicture";
            this.initialPicture.Size = new System.Drawing.Size(650, 510);
            this.initialPicture.TabIndex = 11;
            this.initialPicture.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.asmValue);
            this.panel3.Controls.Add(this.csValue);
            this.panel3.Controls.Add(this.threadsValue);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.trackBar2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.asmTime);
            this.panel3.Controls.Add(this.thresholdTrackBarAsm);
            this.panel3.Controls.Add(this.thresholdTrackBarCs);
            this.panel3.Controls.Add(this.CTime);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 543);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1539, 230);
            this.panel3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 56);
            this.label4.TabIndex = 14;
            this.label4.Text = "Liczba wątków:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar2.Location = new System.Drawing.Point(228, 16);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar2.Size = new System.Drawing.Size(874, 56);
            this.trackBar2.TabIndex = 12;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar2.Value = 128;
            // 
            // thresholdTrackBarAsm
            // 
            this.thresholdTrackBarAsm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thresholdTrackBarAsm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thresholdTrackBarAsm.Location = new System.Drawing.Point(228, 140);
            this.thresholdTrackBarAsm.Maximum = 255;
            this.thresholdTrackBarAsm.Name = "thresholdTrackBarAsm";
            this.thresholdTrackBarAsm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.thresholdTrackBarAsm.Size = new System.Drawing.Size(874, 56);
            this.thresholdTrackBarAsm.TabIndex = 11;
            this.thresholdTrackBarAsm.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.thresholdTrackBarAsm.Value = 128;
            this.thresholdTrackBarAsm.Scroll += new System.EventHandler(this.thresholdTrackBarAsm_Scroll);
            // 
            // threadsValue
            // 
            this.threadsValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.threadsValue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.threadsValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.threadsValue.Location = new System.Drawing.Point(1102, 16);
            this.threadsValue.Name = "threadsValue";
            this.threadsValue.Size = new System.Drawing.Size(72, 56);
            this.threadsValue.TabIndex = 15;
            this.threadsValue.Text = " ";
            this.threadsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // csValue
            // 
            this.csValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.csValue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.csValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.csValue.Location = new System.Drawing.Point(1107, 78);
            this.csValue.Name = "csValue";
            this.csValue.Size = new System.Drawing.Size(67, 56);
            this.csValue.TabIndex = 16;
            this.csValue.Text = " ";
            this.csValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // asmValue
            // 
            this.asmValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.asmValue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.asmValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.asmValue.Location = new System.Drawing.Point(1107, 140);
            this.asmValue.Name = "asmValue";
            this.asmValue.Size = new System.Drawing.Size(67, 56);
            this.asmValue.TabIndex = 17;
            this.asmValue.Text = " ";
            this.asmValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBinarization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1579, 795);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBinarization";
            this.ShowIcon = false;
            this.Text = "Binarization";
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBarCs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.finalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBarAsm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ComboBox libraryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label asmTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CTime;
        private System.Windows.Forms.TrackBar thresholdTrackBarCs;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar thresholdTrackBarAsm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label asmValue;
        private System.Windows.Forms.Label csValue;
        private System.Windows.Forms.Label threadsValue;
    }
}