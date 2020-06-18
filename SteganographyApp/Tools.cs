using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.NetworkInformation;

namespace SteganographyApp
{
    abstract class Tools
    {
        // metoda odrwacjająca kolejność str - używana przy ukrywaniu i odkrywaniu  
        public static string Reverse(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

        // zapisywanie obrazu 
        public static void SaveImage(PictureBox pb)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            dialog.FileName = "Image";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pb.Image.Save(dialog.FileName);
            }
        }

        // ładowanie obrazu 
        public static Bitmap LoadImage(PictureBox pb)
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


    }
}
