using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteganographyApp
{
    public partial class MainForm : Form
    {
        public Dictionary<string, Bitmap> bitmaps;
        
        public MainForm()
        {
            InitializeComponent();
            bitmaps = new Dictionary<string, Bitmap>();
        }

        
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            odzyskiwanieToolStripMenuItem.Enabled = true;
            ukrywanieToolStripMenuItem.Enabled = true;

            if (bitmaps.Count < 10)
            {
                
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(dialog.FileName);
                    bitmaps.Add(dialog.SafeFileName, bmp);
                    PictureForm pf = new PictureForm(bmp, bitmaps) { TopLevel = false, Text = dialog.SafeFileName };
                    pContainer.Controls.Add(pf);
                    pf.Show();
                }
            }
            else { MessageBox.Show("Za dużo otwartych obrazów."); }

            fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;

        }

        private void ukrywanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideForm form = new HideForm(bitmaps, pContainer) { TopLevel = false, TopMost = true };
            pContainer.Controls.Add(form);
            form.Show();
        }

        private void odzyskiwanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecoverForm form = new RecoverForm(bitmaps) { TopLevel = false, TopMost = true };
            pContainer.Controls.Add(form);
            form.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }
    }
}
