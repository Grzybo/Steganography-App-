namespace SteganographyApp
{
    partial class RecoverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PbMainImage = new System.Windows.Forms.PictureBox();
            this.PbRecovered = new System.Windows.Forms.PictureBox();
            this.cbBase = new System.Windows.Forms.ComboBox();
            this.BtnRecover = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbMainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRecovered)).BeginInit();
            this.SuspendLayout();
            // 
            // PbMainImage
            // 
            this.PbMainImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbMainImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbMainImage.Location = new System.Drawing.Point(147, 84);
            this.PbMainImage.Name = "PbMainImage";
            this.PbMainImage.Size = new System.Drawing.Size(389, 211);
            this.PbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMainImage.TabIndex = 1;
            this.PbMainImage.TabStop = false;
            this.PbMainImage.Click += new System.EventHandler(this.PbMainImage_Click);
            // 
            // PbRecovered
            // 
            this.PbRecovered.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbRecovered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbRecovered.Location = new System.Drawing.Point(557, 84);
            this.PbRecovered.Name = "PbRecovered";
            this.PbRecovered.Size = new System.Drawing.Size(389, 211);
            this.PbRecovered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbRecovered.TabIndex = 2;
            this.PbRecovered.TabStop = false;
            this.PbRecovered.Click += new System.EventHandler(this.PbRecovered_Click);
            // 
            // cbBase
            // 
            this.cbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbBase.FormattingEnabled = true;
            this.cbBase.Location = new System.Drawing.Point(12, 167);
            this.cbBase.Name = "cbBase";
            this.cbBase.Size = new System.Drawing.Size(129, 28);
            this.cbBase.TabIndex = 9;
            this.cbBase.Text = "Wybierz obraz";
            this.cbBase.SelectedIndexChanged += new System.EventHandler(this.cbBase_SelectedIndexChanged);
            // 
            // BtnRecover
            // 
            this.BtnRecover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRecover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnRecover.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRecover.Location = new System.Drawing.Point(411, 332);
            this.BtnRecover.Name = "BtnRecover";
            this.BtnRecover.Size = new System.Drawing.Size(125, 44);
            this.BtnRecover.TabIndex = 8;
            this.BtnRecover.Text = "Odzyskaj";
            this.BtnRecover.UseVisualStyleBackColor = false;
            this.BtnRecover.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(557, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RecoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(967, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbBase);
            this.Controls.Add(this.BtnRecover);
            this.Controls.Add(this.PbRecovered);
            this.Controls.Add(this.PbMainImage);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "RecoverForm";
            this.Text = "RecoverForm";
            ((System.ComponentModel.ISupportInitialize)(this.PbMainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRecovered)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbMainImage;
        private System.Windows.Forms.PictureBox PbRecovered;
        private System.Windows.Forms.ComboBox cbBase;
        private System.Windows.Forms.Button BtnRecover;
        private System.Windows.Forms.Button button1;
    }
}