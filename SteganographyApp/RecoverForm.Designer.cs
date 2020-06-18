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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverForm));
            this.PbMainImage = new System.Windows.Forms.PictureBox();
            this.PbRecovered = new System.Windows.Forms.PictureBox();
            this.cbBase = new System.Windows.Forms.ComboBox();
            this.BtnRecover = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lDesc = new System.Windows.Forms.Label();
            this.lStep = new System.Windows.Forms.Label();
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
            this.PbMainImage.Size = new System.Drawing.Size(389, 207);
            this.PbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMainImage.TabIndex = 1;
            this.PbMainImage.TabStop = false;
            this.PbMainImage.Click += new System.EventHandler(this.PbMainImage_Click);
            // 
            // PbRecovered
            // 
            this.PbRecovered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbRecovered.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbRecovered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbRecovered.Location = new System.Drawing.Point(562, 84);
            this.PbRecovered.Name = "PbRecovered";
            this.PbRecovered.Size = new System.Drawing.Size(399, 207);
            this.PbRecovered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbRecovered.TabIndex = 2;
            this.PbRecovered.TabStop = false;
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
            this.BtnRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRecover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRecover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnRecover.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRecover.Location = new System.Drawing.Point(610, 366);
            this.BtnRecover.Name = "BtnRecover";
            this.BtnRecover.Size = new System.Drawing.Size(125, 44);
            this.BtnRecover.TabIndex = 8;
            this.BtnRecover.Text = "Odzyskaj";
            this.BtnRecover.UseVisualStyleBackColor = false;
            this.BtnRecover.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(800, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDesc
            // 
            this.tbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDesc.ForeColor = System.Drawing.SystemColors.Info;
            this.tbDesc.Location = new System.Drawing.Point(50, 377);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ReadOnly = true;
            this.tbDesc.Size = new System.Drawing.Size(498, 151);
            this.tbDesc.TabIndex = 31;
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSkip.Enabled = false;
            this.btnSkip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSkip.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSkip.Location = new System.Drawing.Point(312, 534);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(125, 39);
            this.btnSkip.TabIndex = 30;
            this.btnSkip.Text = "Przewiń";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGo.Enabled = false;
            this.btnGo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGo.Location = new System.Drawing.Point(181, 534);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(125, 39);
            this.btnGo.TabIndex = 29;
            this.btnGo.Text = "Dalej";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(50, 534);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 39);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Wróć";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lDesc
            // 
            this.lDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDesc.AutoSize = true;
            this.lDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDesc.Location = new System.Drawing.Point(46, 334);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(189, 21);
            this.lDesc.TabIndex = 27;
            this.lDesc.Text = "Rozpocznij odkrywanie.";
            // 
            // lStep
            // 
            this.lStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lStep.AutoSize = true;
            this.lStep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lStep.Location = new System.Drawing.Point(46, 299);
            this.lStep.Name = "lStep";
            this.lStep.Size = new System.Drawing.Size(55, 21);
            this.lStep.TabIndex = 26;
            this.lStep.Text = "Krok 0";
            // 
            // RecoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(982, 633);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lStep);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbBase);
            this.Controls.Add(this.BtnRecover);
            this.Controls.Add(this.PbRecovered);
            this.Controls.Add(this.PbMainImage);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecoverForm";
            this.Text = "RecoverForm";
            ((System.ComponentModel.ISupportInitialize)(this.PbMainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRecovered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbMainImage;
        private System.Windows.Forms.PictureBox PbRecovered;
        private System.Windows.Forms.ComboBox cbBase;
        private System.Windows.Forms.Button BtnRecover;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.Label lStep;
    }
}