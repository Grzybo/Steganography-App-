using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteganographyApp
{
    public partial class RecoverForm : Form
    {
        private Bitmap MainImage;
        private Dictionary<string, Bitmap> bitmaps;

        public RecoverForm(Dictionary<string, Bitmap> bitmaps)
        {
            InitializeComponent();
            this.bitmaps = bitmaps;
            foreach (string name in bitmaps.Keys)
                cbBase.Items.Add(name);
        }

        public RecoverForm(Bitmap bmp, Dictionary<string, Bitmap> bitmaps)
        {
            InitializeComponent();
            MainImage = bmp;
            PbMainImage.Image = bmp;
            this.bitmaps = bitmaps;

            foreach (string name in bitmaps.Keys)
                cbBase.Items.Add(name);
        }

        private void PbMainImage_Click(object sender, EventArgs e)
        {
            MainImage = LoadImage(PbMainImage);

        }
        private Bitmap LoadImage(PictureBox pb)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(dialog.FileName);
                pb.Image = bmp;
                return bmp;
            }
            return null;
        }

        private void BtnHide_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = new Bitmap(MainImage.Width, MainImage.Height);
            PbRecovered.Image = resultImage;
            int width = 0;
            int height = 0;

            for (int i = 0; i < resultImage.Width; ++i)
                for (int j = 0; j < resultImage.Height; ++j)
                    resultImage.SetPixel(i, j, Color.FromArgb(0, 0, 0));

            for (int i = 0; i < MainImage.Width; ++i)
                for (int j = 0; j < MainImage.Height; ++j)
                {
                    
                    string tempR1 = Convert.ToString(MainImage.GetPixel(i, j).R, 2).PadLeft(8, '0');

                    string tempR = "" + Tools.Reverse(tempR1.Substring(4)) + "0000";

                    string tempG1 = Convert.ToString(MainImage.GetPixel(i, j).G, 2).PadLeft(8, '0');
                        
                    string tempG = "" + Tools.Reverse(tempG1.Substring(4)) + "0000";

                    string tempB1 = Convert.ToString(MainImage.GetPixel(i, j).B, 2).PadLeft(8, '0');
                        
                    string tempB = "" + Tools.Reverse(tempB1.Substring(4)) + "0000";

                    Color tempColor = Color.FromArgb(Convert.ToInt32(tempR, 2), Convert.ToInt32(tempG, 2), Convert.ToInt32(tempB, 2));
                        resultImage.SetPixel(i, j, tempColor);
                }


            for (int i = 0; i < resultImage.Width; ++i)
                if (resultImage.GetPixel(i, 0) == Color.FromArgb(0, 0, 0)) { width = i; break; }


            for (int j = 0; j < resultImage.Height; ++j)
                if (resultImage.GetPixel(0, j) == Color.FromArgb(0, 0, 0)) { height = j; break; }

            Bitmap finalImage = new Bitmap(width, height);



            for (int i = 0; i < finalImage.Width; ++i)
                for (int j = 0; j < finalImage.Height; ++j)
                    finalImage.SetPixel(i, j, resultImage.GetPixel(i, j));

            PbRecovered.Image = finalImage;
        }

        private void PbRecovered_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            dialog.FileName = "Image";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PbRecovered.Image.Save(dialog.FileName);
            }
        }

        private void cbBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainImage = bitmaps[cbBase.SelectedItem.ToString()];
            PbMainImage.Image = MainImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            dialog.FileName = "Image";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PbRecovered.Image.Save(dialog.FileName);
            }
        }
    }
}
