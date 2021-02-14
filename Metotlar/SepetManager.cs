using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention-isimlendirme kuralı
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi "+urun.Adi+" " +urun.Fiyati+" TL");
        }
        public void Ekle2(Urun urun)
        {
            Console.WriteLine("Sepete eklendi " + urun.Adi + " " + urun.Fiyati + " TL");
        }
        
        public void Ekle3(string urunAdi,double fiyati,string aciklama,int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi " + urunAdi);
        }
    }
}
