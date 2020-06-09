using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteganographyApp
{
    abstract class Tools
    {
        public static string Reverse(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

    }
}
