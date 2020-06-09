namespace SteganographyApp
{
    partial class HideForm
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
            this.PbMainImage = new System.Windows.Forms.PictureBox();
            this.PbHiddenImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PbResult = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnHide = new System.Windows.Forms.Button();
            this.cbBase = new System.Windows.Forms.ComboBox();
            this.cbHide = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbMainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbHiddenImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // PbMainImage
            // 
            this.PbMainImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbMainImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbMainImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbMainImage.Location = new System.Drawing.Point(147, 80);
            this.PbMainImage.Name = "PbMainImage";
            this.PbMainImage.Size = new System.Drawing.Size(389, 211);
            this.PbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMainImage.TabIndex = 0;
            this.PbMainImage.TabStop = false;
            this.PbMainImage.Click += new System.EventHandler(this.PbMainImage_Click);
            // 
            // PbHiddenImage
            // 
            this.PbHiddenImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbHiddenImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbHiddenImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbHiddenImage.Location = new System.Drawing.Point(551, 80);
            this.PbHiddenImage.Name = "PbHiddenImage";
            this.PbHiddenImage.Size = new System.Drawing.Size(389, 211);
            this.PbHiddenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbHiddenImage.TabIndex = 2;
            this.PbHiddenImage.TabStop = false;
            this.PbHiddenImage.Click += new System.EventHandler(this.PbHiddenImage_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(277, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Obraz bazowy";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(691, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Obraz do ukrycia";
            // 
            // PbResult
            // 
            this.PbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbResult.Location = new System.Drawing.Point(353, 347);
            this.PbResult.Name = "PbResult";
            this.PbResult.Size = new System.Drawing.Size(389, 211);
            this.PbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbResult.TabIndex = 5;
            this.PbResult.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(492, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Obraz wynikowy";
            // 
            // BtnHide
            // 
            this.BtnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnHide.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnHide.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnHide.Location = new System.Drawing.Point(353, 582);
            this.BtnHide.Name = "BtnHide";
            this.BtnHide.Size = new System.Drawing.Size(125, 44);
            this.BtnHide.TabIndex = 7;
            this.BtnHide.Text = "Ukryj";
            this.BtnHide.UseVisualStyleBackColor = false;
            this.BtnHide.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // cbBase
            // 
            this.cbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbBase.FormattingEnabled = true;
            this.cbBase.Location = new System.Drawing.Point(12, 156);
            this.cbBase.Name = "cbBase";
            this.cbBase.Size = new System.Drawing.Size(129, 28);
            this.cbBase.TabIndex = 8;
            this.cbBase.Text = "Wybierz obraz";
            this.cbBase.SelectedIndexChanged += new System.EventHandler(this.cbBase_SelectedIndexChanged);
            // 
            // cbHide
            // 
            this.cbHide.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbHide.FormattingEnabled = true;
            this.cbHide.Location = new System.Drawing.Point(946, 155);
            this.cbHide.Name = "cbHide";
            this.cbHide.Size = new System.Drawing.Size(146, 29);
            this.cbHide.TabIndex = 10;
            this.cbHide.Text = "Wybierz obraz";
            this.cbHide.SelectedIndexChanged += new System.EventHandler(this.cbHide_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(484, 582);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 44);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecover.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRecover.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecover.Location = new System.Drawing.Point(617, 582);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(125, 44);
            this.btnRecover.TabIndex = 12;
            this.btnRecover.Text = "Odzyskaj";
            this.btnRecover.UseVisualStyleBackColor = false;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // HideForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1104, 659);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbHide);
            this.Controls.Add(this.cbBase);
            this.Controls.Add(this.BtnHide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbHiddenImage);
            this.Controls.Add(this.PbMainImage);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "HideForm";
            this.Text = "Steganography by Grzybo";
            ((System.ComponentModel.ISupportInitialize)(this.PbMainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbHiddenImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbMainImage;
        private System.Windows.Forms.PictureBox PbHiddenImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnHide;
        private System.Windows.Forms.ComboBox cbBase;
        private System.Windows.Forms.ComboBox cbHide;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRecover;
    }
}

