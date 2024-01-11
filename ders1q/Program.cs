using System;


namespace ders1q
{

    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elmas";
            double fiyati = 31;
            string aciklama = "elbistan elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 31;
            urun1.Aciklama = "elbistan elması";
            
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 21;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----");

            }

            Console.WriteLine(" ------ Metotlar ------ ");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil armut", 12);
            sepetManager.Ekle2("Elma", "Yesil tlma", 21);
            sepetManager.Ekle2("Karpuz", "Diyarbakir karpuzu", 31);

        }
        
    }



}





