using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class MathHelper
    {

        //erısım belirteci(access modifer)
        // Metotların varsayılan erısım belirteci (access modifer) : private
        int topla(int sayi1, int sayi2)  // metot
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        //string topla(int x, int y) // Error already exists
        //{
        //       int toplam = x + y;
        //       return toplam
        //}


        // Method overloading
        internal string topla(string sayi1, string sayi2)
        {
            int toplam = Convert.ToInt32(sayi1) + int.Parse(sayi2);

            return toplam.ToString();

        }
    }
}
