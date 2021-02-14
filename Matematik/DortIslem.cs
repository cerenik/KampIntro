using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        //Topla(2,3)
        public void Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç :"+ toplam);
        }

        public void Carp(int num1,int num2)
        {
            int carpım = num1 * num2;
            Console.WriteLine("Equals to: "+carpım);
        }
    }
}
