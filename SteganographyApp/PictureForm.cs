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
        public PictureForm(Bitmap bmp)
        {
            InitializeComponent();
            pb.Image = bmp;
        }
    }
}
