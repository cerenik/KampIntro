using System;

namespace Metotlar
{
    class Program
    {
        string urunAdi = "Elma";
        double fiyati = 50;
        string aciklama = "Amasya Elması";

        string[] meyveler = new string[] { "Elma", "Karpuz" };

        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 50;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type safe
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------------------");
            }

            Console.WriteLine("------------Metotlar-------------");
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2(urun1);
            sepetManager.Ekle2(urun2);

            sepetManager.Ekle3("armut", 12, "yeşil armut",3);
            sepetManager.Ekle3("çilek", 10, "kırmızı çilek",6);
        }
    }
}
