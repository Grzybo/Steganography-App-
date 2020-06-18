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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HideForm));
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
            this.tbMainImageSize = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbSecretImageSize = new System.Windows.Forms.TextBox();
            this.lStep = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbMainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbHiddenImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // PbMainImage
            // 
            this.PbMainImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbMainImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbMainImage.Location = new System.Drawing.Point(147, 80);
            this.PbMainImage.Name = "PbMainImage";
            this.PbMainImage.Size = new System.Drawing.Size(389, 206);
            this.PbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMainImage.TabIndex = 0;
            this.PbMainImage.TabStop = false;
            // 
            // PbHiddenImage
            // 
            this.PbHiddenImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbHiddenImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbHiddenImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbHiddenImage.Location = new System.Drawing.Point(551, 80);
            this.PbHiddenImage.Name = "PbHiddenImage";
            this.PbHiddenImage.Size = new System.Drawing.Size(389, 206);
            this.PbHiddenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbHiddenImage.TabIndex = 2;
            this.PbHiddenImage.TabStop = false;
            // 
            // label1
            // 
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
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.PbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PbResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbResult.Location = new System.Drawing.Point(551, 378);
            this.PbResult.Name = "PbResult";
            this.PbResult.Size = new System.Drawing.Size(389, 206);
            this.PbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbResult.TabIndex = 5;
            this.PbResult.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(690, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Obraz wynikowy";
            // 
            // BtnHide
            // 
            this.BtnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnHide.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnHide.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnHide.Location = new System.Drawing.Point(551, 613);
            this.BtnHide.Name = "BtnHide";
            this.BtnHide.Size = new System.Drawing.Size(125, 39);
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
            this.cbHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(682, 613);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 39);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecover.Enabled = false;
            this.btnRecover.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRecover.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecover.Location = new System.Drawing.Point(815, 613);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(125, 39);
            this.btnRecover.TabIndex = 12;
            this.btnRecover.Text = "Odzyskaj";
            this.btnRecover.UseVisualStyleBackColor = false;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // tbMainImageSize
            // 
            this.tbMainImageSize.Location = new System.Drawing.Point(147, 297);
            this.tbMainImageSize.Name = "tbMainImageSize";
            this.tbMainImageSize.ReadOnly = true;
            this.tbMainImageSize.Size = new System.Drawing.Size(149, 20);
            this.tbMainImageSize.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbSecretImageSize
            // 
            this.tbSecretImageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSecretImageSize.Location = new System.Drawing.Point(791, 297);
            this.tbSecretImageSize.Name = "tbSecretImageSize";
            this.tbSecretImageSize.ReadOnly = true;
            this.tbSecretImageSize.Size = new System.Drawing.Size(149, 20);
            this.tbSecretImageSize.TabIndex = 15;
            // 
            // lStep
            // 
            this.lStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lStep.AutoSize = true;
            this.lStep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lStep.Location = new System.Drawing.Point(34, 378);
            this.lStep.Name = "lStep";
            this.lStep.Size = new System.Drawing.Size(55, 21);
            this.lStep.TabIndex = 16;
            this.lStep.Text = "Krok 0";
            // 
            // lDesc
            // 
            this.lDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDesc.AutoSize = true;
            this.lDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDesc.Location = new System.Drawing.Point(34, 413);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(352, 21);
            this.lDesc.TabIndex = 17;
            this.lDesc.Text = "Wybierz obrazy jakie chesz użyć i kliknij \"Ukryj\".";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(38, 613);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 39);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Wróć";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGo.Enabled = false;
            this.btnGo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGo.Location = new System.Drawing.Point(169, 613);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(125, 39);
            this.btnGo.TabIndex = 20;
            this.btnGo.Text = "Dalej";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSkip.Enabled = false;
            this.btnSkip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSkip.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSkip.Location = new System.Drawing.Point(300, 613);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(125, 39);
            this.btnSkip.TabIndex = 21;
            this.btnSkip.Text = "Przewiń";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // tbDesc
            // 
            this.tbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDesc.ForeColor = System.Drawing.SystemColors.Info;
            this.tbDesc.Location = new System.Drawing.Point(38, 456);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ReadOnly = true;
            this.tbDesc.Size = new System.Drawing.Size(498, 151);
            this.tbDesc.TabIndex = 25;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnReset.Location = new System.Drawing.Point(12, 12);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(125, 39);
            this.BtnReset.TabIndex = 26;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // HideForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1104, 654);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lStep);
            this.Controls.Add(this.tbSecretImageSize);
            this.Controls.Add(this.tbMainImageSize);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HideForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
        private System.Windows.Forms.TextBox tbMainImageSize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbSecretImageSize;
        private System.Windows.Forms.Label lStep;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Button BtnReset;
    }
}

