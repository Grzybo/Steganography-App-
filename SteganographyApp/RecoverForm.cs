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
        private Bitmap mainImage;
        private Bitmap resultImage;
        private int x, y;
        private int step;
        private int secretHeight;
        private int secretWidth;
        private Dictionary<string, Bitmap> bitmaps;


        public RecoverForm(Dictionary<string, Bitmap> bitmaps)
        {
            InitializeComponent();
            this.bitmaps = bitmaps;
            foreach (string name in bitmaps.Keys)
                cbBase.Items.Add(name);
            step = x = y = 0; 
        }

        public RecoverForm(Bitmap bmp, Dictionary<string, Bitmap> bitmaps)
        {
            InitializeComponent();
            mainImage = bmp;
            PbMainImage.Image = bmp;
            this.bitmaps = bitmaps;

            foreach (string name in bitmaps.Keys)
                cbBase.Items.Add(name);
            step = 0;
        }

        private void PbMainImage_Click(object sender, EventArgs e)
        {
            mainImage = LoadImage(PbMainImage);

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
            if (mainImage == null) { return; }
            btnBack.Enabled = btnGo.Enabled = btnSkip.Enabled = true;


            BtnRecover.Enabled = false; 
            SecretSize();
            step++;
            lStep.Text = "Krok " + step;
            lDesc.Text = "Odczytano rozmiar ukrytego obrazu.";
            tbDesc.AppendText("Szerokość: " + secretWidth + Environment.NewLine +
                                "Wysokość : " + secretHeight);

        }

        // ################################################################################################################## 

        private void SecretSize() 
        {
            string secretSize = "" + Convert.ToString(mainImage.GetPixel(0, 0).R, 2).PadLeft(8, '0').Substring(4, 4) +
                                Convert.ToString(mainImage.GetPixel(0, 0).G, 2).PadLeft(8, '0').Substring(4, 4) +
                                Convert.ToString(mainImage.GetPixel(0, 0).B, 2).PadLeft(8, '0').Substring(4, 4) +
                                Convert.ToString(mainImage.GetPixel(0, 1).R, 2).PadLeft(8, '0').Substring(4, 4) +
                                Convert.ToString(mainImage.GetPixel(0, 1).G, 2).PadLeft(8, '0').Substring(4, 4) +
                                Convert.ToString(mainImage.GetPixel(0, 1).B, 2).PadLeft(8, '0').Substring(4, 4);

            secretHeight = Convert.ToInt32(secretSize.Substring(0, 12), 2);
            secretWidth = Convert.ToInt32(secretSize.Substring(12), 2);

            resultImage = new Bitmap(secretWidth, secretHeight);
            PbRecovered.Image = resultImage;
        }

        private void PbRecovered_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void cbBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainImage = bitmaps[cbBase.SelectedItem.ToString()];
            PbMainImage.Image = mainImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            dialog.FileName = "Image";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PbRecovered.Image.Save(dialog.FileName);
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < resultImage.Width; ++i)
                //for (int j = 0; j < resultImage.Height; ++j)
                    //resultImage.SetPixel(i, j, mainImage.GetPixel(i, j));

            for (int i = 0; i < secretWidth; ++i)
                for (int j = 0; j < secretHeight; ++j)
                {

                    string tempR1 = Convert.ToString(mainImage.GetPixel(i, j).R, 2).PadLeft(8, '0');

                    string tempR = "" + Tools.Reverse(tempR1.Substring(4)) + "0000";

                    string tempG1 = Convert.ToString(mainImage.GetPixel(i, j).G, 2).PadLeft(8, '0');

                    string tempG = "" + Tools.Reverse(tempG1.Substring(4)) + "0000";

                    string tempB1 = Convert.ToString(mainImage.GetPixel(i, j).B, 2).PadLeft(8, '0');

                    string tempB = "" + Tools.Reverse(tempB1.Substring(4)) + "0000";

                    Color tempColor = Color.FromArgb(Convert.ToInt32(tempR, 2), Convert.ToInt32(tempG, 2), Convert.ToInt32(tempB, 2));
                    resultImage.SetPixel(i, j, tempColor);
                }

            PbRecovered.Image = resultImage;
            lDesc.Text = "Obraz został odkryty!";
            step = (secretWidth - 1) * (secretHeight - 1);
            x = secretWidth - 1;
            y = secretHeight - 1;
            tbDesc.Text = "Pixel (" + x + ", " + y + " )";
            lStep.Text = "Krok " + step++;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            if (x == secretWidth - 1 && y == secretHeight - 1)
            {
                btnGo.Enabled = false;
                lDesc.Text = "Obraz został odkryty!";
                btnGo.Enabled = false;
                return;
            }
            else
            {
                y++;
                if (y == secretHeight) { y = 0; x++; }
            }

            string tempR1 = Convert.ToString(mainImage.GetPixel(x, y).R, 2).PadLeft(8, '0');
            string tempR = "" + Tools.Reverse(tempR1.Substring(4)) + "0000";
            string tempG1 = Convert.ToString(mainImage.GetPixel(x, y).G, 2).PadLeft(8, '0');
            string tempG = "" + Tools.Reverse(tempG1.Substring(4)) + "0000";
            string tempB1 = Convert.ToString(mainImage.GetPixel(x, y).B, 2).PadLeft(8, '0');
            string tempB = "" + Tools.Reverse(tempB1.Substring(4)) + "0000";
            Color tempColor = Color.FromArgb(Convert.ToInt32(tempR, 2), Convert.ToInt32(tempG, 2), Convert.ToInt32(tempB, 2));
            resultImage.SetPixel(x, y, tempColor);

            lStep.Text = "Krok " + ++step;
            lDesc.Text = "Odtwarzanie obarzu z 4 ostatnich bitów piksela.";
            PbRecovered.Image = resultImage;
            tbDesc.Text = "";
            ShowRGBvalues();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (x == 0 && y == 0) { return; }
            btnGo.Enabled = true;
            resultImage.SetPixel(x, y, Color.FromArgb(0, 0, 0));
            PbRecovered.Image = resultImage;
            
            lStep.Text = "Krok " + step--;
            lDesc.Text = "Odtwarzanie obarzu z 4 ostatnich bitów piksela.";

            if (y == 0) { y = secretHeight - 1; x--; }
            else { y--; }
            ShowRGBvalues();
        }

        private void ShowRGBvalues()
        {
            tbDesc.Text = "Pixel (" + x + ", " + y + " )";
            tbDesc.AppendText(Environment.NewLine +
                                "Orginalny :     R(" + Convert.ToString(mainImage.GetPixel(x, y).R, 2).PadLeft(8, '0')
                                + ") G(" + Convert.ToString(mainImage.GetPixel(x, y).G, 2).PadLeft(8, '0')
                                + ") B(" + Convert.ToString(mainImage.GetPixel(x, y).B, 2).PadLeft(8, '0') + ")"
                                + Environment.NewLine +
                                "Odtworzony: R(" + Convert.ToString(resultImage.GetPixel(x, y).R, 2).PadLeft(8, '0')
                                + ") G(" + Convert.ToString(resultImage.GetPixel(x, y).G, 2).PadLeft(8, '0')
                                + ") B(" + Convert.ToString(resultImage.GetPixel(x, y).B, 2).PadLeft(8, '0') + ")");
        }

        private void RecoverForm_Load(object sender, EventArgs e)
        {

        }
    }
}
