using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urun = new Urun[] { urun1, urun2 };
            //typesafe - tip güvenliği
            //encapsulation
            foreach (Urun urunler in urun)
            {
                Console.WriteLine(urunler.Adi);
                Console.WriteLine(urunler.Fiyati);
                Console.WriteLine(urunler.Aciklama);
                Console.WriteLine("----------------");
            }
            Console.WriteLine("------------Metotlar---------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            
        }
        
    }
}

//Don't repeat yourself - DRY - Clean Code - Best Practice
//Ortak operasyonları metot olarak adlandırırız()mesela sepete ekle butonu 
//classların içine yazarız






foreach (Client clients in client)
{
    Console.WriteLine("Client Name:" + client.Name);
    Console.WriteLine("client Surname:" + client.Surname);
    Console.WriteLine("Client Id:" + client.Id);
    Console.WriteLine("Client Account Number:" + client.AccountNo);
}