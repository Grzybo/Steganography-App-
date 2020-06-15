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


namespace SteganographyApp
{
    public partial class HideForm : Form
    {

        //private Thread hiding;
        private int step, x, y;
        private string secretSize;
        public Bitmap mainImage;
        public Bitmap secretImage;
        public Bitmap resultImage;
        private Dictionary<string, Bitmap> bitmaps;
        public Panel panel;


        public HideForm(Dictionary<string, Bitmap> bitmaps, Panel panel)
        {
            InitializeComponent();

            step = x = y = 0;
            

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

        private void Hiding()
        {
            

            if (mainImage.Width < secretImage.Width || mainImage.Height < secretImage.Height)
            {
                MessageBox.Show("Obraz do ukrycia musi być mniejszy od bazowego.");
                return;
            }

            Bitmap resultImage = new Bitmap(mainImage.Width, mainImage.Height);
            Bitmap resultImageCopy = resultImage;
            //PbResult.Image = resultImageCopy;

                
                string secretSize = Convert.ToString(secretImage.Height, 2).PadLeft(12, '0') + Convert.ToString(secretImage.Width, 2).PadLeft(12, '0');

                string temp = Convert.ToString(mainImage.GetPixel(0, 0).R, 2).PadLeft(8, '0').Substring(0, 4);

                Color heightColor = Color.FromArgb(Convert.ToInt32(Convert.ToString(mainImage.GetPixel(0, 0).R, 2).PadLeft(8, '0').Substring(0, 4) +
                                                    secretSize.Substring(0, 4), 2),
                                                    Convert.ToInt32(Convert.ToString(mainImage.GetPixel(0, 0).G, 2).PadLeft(8, '0').Substring(0, 4) +
                                                    secretSize.Substring(4, 4), 2),
                                                    Convert.ToInt32(Convert.ToString(mainImage.GetPixel(0, 0).B, 2).PadLeft(8, '0').Substring(0, 4) +
                                                    secretSize.Substring(8, 4), 2));

                Color widthColor = Color.FromArgb(Convert.ToInt32(Convert.ToString(mainImage.GetPixel(0, 1).R, 2).PadLeft(8, '0').Substring(0, 4) +
                                                    secretSize.Substring(12, 4), 2),
                                                    Convert.ToInt32(Convert.ToString(mainImage.GetPixel(0, 1).G, 2).PadLeft(8, '0').Substring(0, 4) +
                                                    secretSize.Substring(16, 4), 2),
                                                    Convert.ToInt32(Convert.ToString(mainImage.GetPixel(0, 1).B, 2).PadLeft(8, '0').Substring(0, 4) +
                                                    secretSize.Substring(20, 4), 2));


                for (int i = 0; i < resultImage.Width; ++i)
                    for (int j = 0; j < resultImage.Height; ++j)
                        resultImage.SetPixel(i, j, Color.FromArgb(0, 0, 0));

                resultImage.SetPixel(0, 0, heightColor);
                resultImage.SetPixel(0, 1, widthColor);

                resultImageCopy = resultImage;
                PbResult.Image = resultImageCopy;

                // #################################

                for (int i = 1; i < mainImage.Width; ++i)
                    for (int j = 1; j < mainImage.Height; ++j)
                    {
                        if (i < secretImage.Width && j < secretImage.Height)
                        {
                            string tempR1 = Convert.ToString(mainImage.GetPixel(i, j).R, 2).PadLeft(8, '0');
                            string tempR2 = Convert.ToString(secretImage.GetPixel(i, j).R, 2).PadLeft(8, '0');
                            string tempR = "" + tempR1.Substring(0, 4) + Tools.Reverse(tempR2.Substring(0, 4));

                            string tempG1 = Convert.ToString(mainImage.GetPixel(i, j).G, 2).PadLeft(8, '0');
                            string tempG2 = Convert.ToString(secretImage.GetPixel(i, j).G, 2).PadLeft(8, '0');
                            string tempG = "" + tempG1.Substring(0, 4) + Tools.Reverse(tempG2.Substring(0, 4));

                            string tempB1 = Convert.ToString(mainImage.GetPixel(i, j).B, 2).PadLeft(8, '0');
                            string tempB2 = Convert.ToString(secretImage.GetPixel(i, j).B, 2).PadLeft(8, '0');
                            string tempB = "" + tempB1.Substring(0, 4) + Tools.Reverse(tempB2.Substring(0, 4));

                            Color tempColor = Color.FromArgb(Convert.ToInt32(tempR, 2), Convert.ToInt32(tempG, 2), Convert.ToInt32(tempB, 2));
                            lock (resultImage) { resultImage.SetPixel(i, j, tempColor); }

                            resultImageCopy = resultImage;
                            try { PbResult.Image = resultImageCopy; }
                            catch { }
                            Thread.Sleep(100);

                        }
                        else
                        {
                            resultImage.SetPixel(i, j, mainImage.GetPixel(i, j));
                        }
                    }
                PbResult.Image = resultImage;
        }

        private void BtnHide_Click(object sender, EventArgs e)
        {
            if (mainImage.Width < secretImage.Width || mainImage.Height < secretImage.Height)
            {
                MessageBox.Show("Obraz do ukrycia musi być mniejszy od bazowego.");
                return;
            }

            btnBack.Enabled = btnGo.Enabled = btnSkip.Enabled = true;
            BtnHide.Enabled = false;

            WriteSize();
            secretSize = Convert.ToString(secretImage.Height, 2).PadLeft(12, '0') + Convert.ToString(secretImage.Width, 2).PadLeft(12, '0');
            step++;
            lStep.Text = "Krok " + step;
            lDesc.Text = "Zapisywanie rozmiaru obrazu na dwóch pierwszych pikselach.";

            tbDesc.AppendText("Szerokość: " + secretImage.Width + " = " + Convert.ToString(secretImage.Width, 2).PadLeft(12, '0') + Environment.NewLine +
                                "Wyskość: " + secretImage.Height + " = " + Convert.ToString(secretImage.Height, 2).PadLeft(12, '0') + Environment.NewLine +
                                "Pixel (0, 0) = " + "R(" + Convert.ToString(mainImage.GetPixel(0, 0).R, 2).PadLeft(8, '0').Substring(0, 4) + secretSize.Substring(0, 4)
                                + ") G(" + Convert.ToString(mainImage.GetPixel(0, 0).G, 2).PadLeft(8, '0').Substring(4, 4) + secretSize.Substring(4, 4) 
                                + ") B(" + Convert.ToString(mainImage.GetPixel(0, 0).B, 2).PadLeft(8, '0').Substring(0, 4) + secretSize.Substring(8, 4) + ")"   
                                + Environment.NewLine +
                                "Pixel (0, 1) = " + "R(" + Convert.ToString(mainImage.GetPixel(0, 1).R, 2).PadLeft(8, '0').Substring(0, 4) + secretSize.Substring(12, 4)
                                + ") G(" + Convert.ToString(mainImage.GetPixel(0, 1).G, 2).PadLeft(8, '0').Substring(0, 4) + secretSize.Substring(16, 4)
                                + ") B(" + Convert.ToString(mainImage.GetPixel(0, 1).B, 2).PadLeft(8, '0').Substring(0, 4) + secretSize.Substring(20, 4) + ")");
        }

        private void WriteSize()
        {
            resultImage = new Bitmap(mainImage.Width, mainImage.Height);

            secretSize = Convert.ToString(secretImage.Height, 2).PadLeft(12, '0') + Convert.ToString(secretImage.Width, 2).PadLeft(12, '0');

            string temp = Convert.ToString(mainImage.GetPixel(0, 0).R, 2).PadLeft(8, '0').Substring(0, 4);

            Color heightColor = Color.FromArgb(Convert.ToInt32(Convert.ToString(mainImage.GetPixel(0, 0).R, 2).PadLeft(8, '0').Substring(0, 4) +
                                                secretSize.Substring(0, 4), 2),
                                                Convert.ToInt32(Convert.ToString(mainImage.GetPixel(0, 0).G, 2).PadLeft(8, '0').Substring(0, 4) +
                                                secretSize.Substring(4, 4), 2),
                                                Convert.ToInt32(Convert.ToString(mainImage.GetPixel(0, 0).B, 2).PadLeft(8, '0').Substring(0, 4) +
                                                secretSize.Substring(8, 4), 2));

            Color widthColor = Color.FromArgb(Convert.ToInt32(Convert.ToString(mainImage.GetPixel(0, 1).R, 2).PadLeft(8, '0').Substring(0, 4) +
                                                secretSize.Substring(12, 4), 2),
                                                Convert.ToInt32(Convert.ToString(mainImage.GetPixel(0, 1).G, 2).PadLeft(8, '0').Substring(0, 4) +
                                                secretSize.Substring(16, 4), 2),
                                                Convert.ToInt32(Convert.ToString(mainImage.GetPixel(0, 1).B, 2).PadLeft(8, '0').Substring(0, 4) +
                                                secretSize.Substring(20, 4), 2));

            for (int i = 0; i < resultImage.Width; ++i)
                for (int j = 0; j < resultImage.Height; ++j)
                    resultImage.SetPixel(i, j, Color.FromArgb(0, 0, 0));

            resultImage.SetPixel(0, 0, heightColor);
            resultImage.SetPixel(0, 1, widthColor);

            
            PbResult.Image = resultImage;
        } 

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (x == 0 && y == 0)
            {
                y += 2;
            }
            else if (x == mainImage.Width && y == mainImage.Height) { btnGo.Enabled = false; return; }
            else 
            {
                y++;
                if (y == mainImage.Height) { y = 0; x++; }
            }

            if (x < secretImage.Width && y < secretImage.Height)
            {
                string tempR1 = Convert.ToString(mainImage.GetPixel(x, y).R, 2).PadLeft(8, '0');
                string tempR2 = Convert.ToString(secretImage.GetPixel(x, y).R, 2).PadLeft(8, '0');
                string tempR = "" + tempR1.Substring(0, 4) + Tools.Reverse(tempR2.Substring(0, 4));

                string tempG1 = Convert.ToString(mainImage.GetPixel(x, y).G, 2).PadLeft(8, '0');
                string tempG2 = Convert.ToString(secretImage.GetPixel(x, y).G, 2).PadLeft(8, '0');
                string tempG = "" + tempG1.Substring(0, 4) + Tools.Reverse(tempG2.Substring(0, 4));

                string tempB1 = Convert.ToString(mainImage.GetPixel(x, y).B, 2).PadLeft(8, '0');
                string tempB2 = Convert.ToString(secretImage.GetPixel(x, y).B, 2).PadLeft(8, '0');
                string tempB = "" + tempB1.Substring(0, 4) + Tools.Reverse(tempB2.Substring(0, 4));

                Color tempColor = Color.FromArgb(Convert.ToInt32(tempR, 2), Convert.ToInt32(tempG, 2), Convert.ToInt32(tempB, 2));
                resultImage.SetPixel(x, y, tempColor);

                PbResult.Image = resultImage;
            }
            else
            {
                resultImage.SetPixel(x, y, mainImage.GetPixel(x, y));
                PbResult.Image = resultImage;
            }

            tbDesc.Text = "Pixel (" + x + ", " + y + " )";
            ShowRGBvalues();
            lStep.Text = "Krok " + step++;
            lDesc.Text = "Łączenie czterech pierwszych bitów i tworzenie nowego koloru.";

        } 


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (x == 0 && y == 0 || x == 0 && y == 1) { return; }
            btnGo.Enabled = true;
            resultImage.SetPixel(x, y, Color.FromArgb(0, 0, 0));
            PbResult.Image = resultImage;
            tbDesc.Text = "Pixel (" + x + ", " + y + " )";
            lStep.Text = "Krok " + step--;

            if (y == 0) { y = mainImage.Height - 1; x--; }
            else { y--; }
            ShowRGBvalues();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mainImage.Width; ++i)
                for (int j = 0; j < mainImage.Height; ++j)
                {
                    if (i == 0 && j == 0 || i == 0 && j == 1)
                    {
                        continue;
                    }

                        if (i < secretImage.Width && j < secretImage.Height)
                        {
                            string tempR1 = Convert.ToString(mainImage.GetPixel(i, j).R, 2).PadLeft(8, '0');
                            string tempR2 = Convert.ToString(secretImage.GetPixel(i, j).R, 2).PadLeft(8, '0');
                            string tempR = "" + tempR1.Substring(0, 4) + Tools.Reverse(tempR2.Substring(0, 4));

                            string tempG1 = Convert.ToString(mainImage.GetPixel(i, j).G, 2).PadLeft(8, '0');
                            string tempG2 = Convert.ToString(secretImage.GetPixel(i, j).G, 2).PadLeft(8, '0');
                            string tempG = "" + tempG1.Substring(0, 4) + Tools.Reverse(tempG2.Substring(0, 4));

                            string tempB1 = Convert.ToString(mainImage.GetPixel(i, j).B, 2).PadLeft(8, '0');
                            string tempB2 = Convert.ToString(secretImage.GetPixel(i, j).B, 2).PadLeft(8, '0');
                            string tempB = "" + tempB1.Substring(0, 4) + Tools.Reverse(tempB2.Substring(0, 4));

                            Color tempColor = Color.FromArgb(Convert.ToInt32(tempR, 2), Convert.ToInt32(tempG, 2), Convert.ToInt32(tempB, 2));
                            lock (resultImage) { resultImage.SetPixel(i, j, tempColor); }

                            PbResult.Image = resultImage;
                        }
                        else
                        {
                            resultImage.SetPixel(i, j, mainImage.GetPixel(i, j));
                        }
                    
                }
            PbResult.Image = resultImage;
            btnRecover.Enabled = true;
            btnGo.Enabled = false;
            step = (mainImage.Width - 1) * (mainImage.Height - 1);
            x = mainImage.Width - 1;
            y = mainImage.Height - 1;
            tbDesc.Text = "Pixel (" + x + ", " + y + " )";
            lDesc.Text = "Obraz ukryty.";
            lStep.Text = "Krok " + step++;
            ShowRGBvalues();
        }
        //####################################################################################################################
        private void ShowRGBvalues()
        {
            tbDesc.AppendText(Environment.NewLine +
                                "Bazowy    : R(" + Convert.ToString(mainImage.GetPixel(x, y).R, 2).PadLeft(8, '0')
                                + ") G(" + Convert.ToString(mainImage.GetPixel(x, y).G, 2).PadLeft(8, '0')
                                + ") B(" + Convert.ToString(mainImage.GetPixel(x, y).B, 2).PadLeft(8, '0') + ")");

            if (x < secretImage.Width && y < secretImage.Height)
            {
                tbDesc.AppendText(Environment.NewLine
                                + "Ukrywany: R(" + Convert.ToString(secretImage.GetPixel(x, y).R, 2).PadLeft(8, '0')
                                + ") G(" + Convert.ToString(secretImage.GetPixel(x, y).G, 2).PadLeft(8, '0')
                                + ") B(" + Convert.ToString(secretImage.GetPixel(x, y).B, 2).PadLeft(8, '0') + ")"
                                + Environment.NewLine
                                + "Nowy        : R(" + Convert.ToString(resultImage.GetPixel(x, y).R, 2).PadLeft(8, '0')
                                + ") G(" + Convert.ToString(resultImage.GetPixel(x, y).G, 2).PadLeft(8, '0')
                                + ") B(" + Convert.ToString(resultImage.GetPixel(x, y).B, 2).PadLeft(8, '0') + ")");
            }
        } 
        
        private void mainImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainImage = LoadImage(PbMainImage);
        }

        private void imageToHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secretImage = LoadImage(PbHiddenImage);
        }

        private void PbMainImage_Click(object sender, EventArgs e)
        {
            mainImage = LoadImage(PbMainImage);
        }

        private void PbHiddenImage_Click(object sender, EventArgs e)
        {
            secretImage = LoadImage(PbHiddenImage);
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
            mainImage = bitmaps[cbBase.SelectedItem.ToString()];
            PbMainImage.Image = mainImage;
            tbMainImageSize.Text = "" + mainImage.Width + " x " + mainImage.Height;
        }

        private void cbHide_SelectedIndexChanged(object sender, EventArgs e)
        {
            secretImage = bitmaps[cbHide.SelectedItem.ToString()];
            PbHiddenImage.Image = secretImage;
            tbSecretImageSize.Text = "" + secretImage.Width + " x " + secretImage.Height;
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

 