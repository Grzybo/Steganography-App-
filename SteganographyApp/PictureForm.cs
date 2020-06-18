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
    public partial class PictureForm : Form
    {

        public Dictionary<string, Bitmap> bitmaps;

        public PictureForm(Bitmap bmp, Dictionary<string, Bitmap> bitmaps)
        {
            InitializeComponent();
            pb.Image = bmp;
            this.bitmaps = bitmaps;
        }

        private void PictureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            bitmaps.Remove(this.Text); 
        }
    }
}
