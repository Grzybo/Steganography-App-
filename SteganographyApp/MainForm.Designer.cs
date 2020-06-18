namespace SteganographyApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukrywanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odzyskiwanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ukrywanieToolStripMenuItem,
            this.odzyskiwanieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.fileToolStripMenuItem.Text = "Otwórz";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.loadToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.loadToolStripMenuItem.Text = "Obraz";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // ukrywanieToolStripMenuItem
            // 
            this.ukrywanieToolStripMenuItem.Enabled = false;
            this.ukrywanieToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ukrywanieToolStripMenuItem.Name = "ukrywanieToolStripMenuItem";
            this.ukrywanieToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.ukrywanieToolStripMenuItem.Text = "Ukrywanie ";
            this.ukrywanieToolStripMenuItem.Click += new System.EventHandler(this.ukrywanieToolStripMenuItem_Click);
            // 
            // odzyskiwanieToolStripMenuItem
            // 
            this.odzyskiwanieToolStripMenuItem.Enabled = false;
            this.odzyskiwanieToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.odzyskiwanieToolStripMenuItem.Name = "odzyskiwanieToolStripMenuItem";
            this.odzyskiwanieToolStripMenuItem.Size = new System.Drawing.Size(122, 25);
            this.odzyskiwanieToolStripMenuItem.Text = "Odzyskiwanie ";
            this.odzyskiwanieToolStripMenuItem.Click += new System.EventHandler(this.odzyskiwanieToolStripMenuItem_Click);
            // 
            // pContainer
            // 
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pContainer.Location = new System.Drawing.Point(0, 29);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(899, 301);
            this.pContainer.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(899, 330);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Steganoapka";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukrywanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odzyskiwanieToolStripMenuItem;
        public System.Windows.Forms.Panel pContainer;
    }
}