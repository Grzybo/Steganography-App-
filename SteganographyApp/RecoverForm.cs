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


        public void Init(Dictionary<string, Bitmap> bitmaps)
        {
            InitializeComponent();
            this.bitmaps = bitmaps;
            foreach (string name in bitmaps.Keys)
                cbBase.Items.Add(name);
            step = x = y = 0;
        }

        public RecoverForm(Dictionary<string, Bitmap> bitmaps)
        {
            Init(bitmaps);
        }

        public RecoverForm(Bitmap bmp, Dictionary<string, Bitmap> bitmaps)
        {
            Init(bitmaps);
            mainImage = bmp;
            PbMainImage.Image = bmp;
        }

        private void PbMainImage_Click(object sender, EventArgs e)
        {
            mainImage = Tools.LoadImage(PbMainImage);
        }
     
        private void BtnHide_Click(object sender, EventArgs e)
        {
            if (mainImage == null) { return; }
            btnBack.Enabled = btnGo.Enabled = btnSkip.Enabled = true;

            BtnRecover.Enabled = cbBase.Enabled =  false; 
            SecretSize();
            step++;
            lStep.Text = "Krok " + step;
            lDesc.Text = "Odczytano rozmiar ukrytego obrazu.";
            tbDesc.AppendText("Szerokość: " + secretWidth + Environment.NewLine +
                                "Wysokość : " + secretHeight);

        }

        // ################################################################################################################## 

        // odczytywanie rozmiaru obrazu 
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


        // metoda obsługująca wybierani obrazu z combo boxa 
        private void cbBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mainImage = bitmaps[cbBase.SelectedItem.ToString()];
                PbMainImage.Image = mainImage;
            }
            catch { bitmaps.Remove(cbBase.SelectedItem.ToString()); }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Tools.SaveImage(PbRecovered);
        }
        
        // odczytywanie obrazu do konca 
        private void btnSkip_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < secretWidth; ++i)
                for (int j = 1; j < secretHeight; ++j)
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


        //odczytywanie obrazu po jednym piksesu
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


        // piksel do tylu
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

        // wypisywanie obecnego piksela 
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
    }
}
