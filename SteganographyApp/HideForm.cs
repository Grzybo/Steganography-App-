using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace SteganographyApp
{
    public partial class HideForm : Form
    {
        public Bitmap MainImage;
        public Bitmap HiddenImage;
        private Dictionary<string, Bitmap> bitmaps;
        public Panel panel;


        public HideForm(Dictionary<string, Bitmap> bitmaps, Panel panel)
        {
            InitializeComponent();

            this.bitmaps = bitmaps;
            
            foreach (string name in bitmaps.Keys)
                cbBase.Items.Add(name);

            foreach (string name in bitmaps.Keys)
                cbHide.Items.Add(name);

            this.panel = panel;
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
            if (MainImage.Width < HiddenImage.Width || MainImage.Height < HiddenImage.Height)
            {
                MessageBox.Show("Image to hide must be smaller.");
                return;
            }

            Bitmap resultImage = new Bitmap(MainImage.Width, MainImage.Height);
            PbResult.Image = resultImage;

            for (int i = 0; i < resultImage.Width; ++i)
                for (int j = 0; j < resultImage.Height; ++j)
                    resultImage.SetPixel(i, j, Color.FromArgb(0, 0, 0));

            for (int i = 0; i < MainImage.Width; ++i)
                for (int j = 0; j < MainImage.Height; ++j)
                {
                    if (i < HiddenImage.Width && j < HiddenImage.Height)
                    {
                        string tempR1 = Convert.ToString(MainImage.GetPixel(i, j).R, 2).PadLeft(8, '0');
                        string tempR2 = Convert.ToString(HiddenImage.GetPixel(i, j).R, 2).PadLeft(8, '0');
                        string tempR = "" + tempR1.Substring(0, 4) + Tools.Reverse(tempR2.Substring(0, 4));

                        string tempG1 = Convert.ToString(MainImage.GetPixel(i, j).G, 2).PadLeft(8, '0');
                        string tempG2 = Convert.ToString(HiddenImage.GetPixel(i, j).G, 2).PadLeft(8, '0');
                        string tempG = "" + tempG1.Substring(0, 4) + Tools.Reverse(tempG2.Substring(0, 4));

                        string tempB1 = Convert.ToString(MainImage.GetPixel(i, j).B, 2).PadLeft(8, '0');
                        string tempB2 = Convert.ToString(HiddenImage.GetPixel(i, j).B, 2).PadLeft(8, '0');
                        string tempB = "" + tempB1.Substring(0, 4) + Tools.Reverse(tempB2.Substring(0, 4));

                        Color tempColor = Color.FromArgb(Convert.ToInt32(tempR, 2), Convert.ToInt32(tempG, 2), Convert.ToInt32(tempB, 2));
                        resultImage.SetPixel(i, j, tempColor);
                    }
                    else
                    {
                        string R = Convert.ToString(MainImage.GetPixel(i, j).R, 2).PadLeft(8, '0').Substring(0, 4) + "0000";
                        string G = Convert.ToString(MainImage.GetPixel(i, j).G, 2).PadLeft(8, '0').Substring(0, 4) + "0000";
                        string B = Convert.ToString(MainImage.GetPixel(i, j).B, 2).PadLeft(8, '0').Substring(0, 4) + "0000";
                        resultImage.SetPixel(i, j, Color.FromArgb(Convert.ToInt32(R, 2), Convert.ToInt32(G, 2), Convert.ToInt32(B, 2)));
                    }
                }
                    


            PbResult.Image = resultImage;
        } 

        //####################################################################################################################
        private void mainImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainImage = LoadImage(PbMainImage);
        }

        private void imageToHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HiddenImage = LoadImage(PbHiddenImage);
        }

        private void PbMainImage_Click(object sender, EventArgs e)
        {
            MainImage = LoadImage(PbMainImage);
        }

        private void PbHiddenImage_Click(object sender, EventArgs e)
        {
            HiddenImage = LoadImage(PbHiddenImage);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            dialog.FileName = "Image";
            
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                PbResult.Image.Save(dialog.FileName);
            }

        }

        private void cbBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainImage = bitmaps[cbBase.SelectedItem.ToString()];
            PbMainImage.Image = MainImage;
        }

        private void cbHide_SelectedIndexChanged(object sender, EventArgs e)
        {
            HiddenImage = bitmaps[cbHide.SelectedItem.ToString()];
            PbHiddenImage.Image = HiddenImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            dialog.FileName = "Image";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PbResult.Image.Save(dialog.FileName);
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            RecoverForm form = new RecoverForm((Bitmap)PbResult.Image, bitmaps) { TopLevel = false };
            panel.Controls.Add(form);
            form.Show();
            this.Close();
        }
    }
}

 