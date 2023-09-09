using System;
using System.Threading;

namespace Webshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShopFrontpage Amazona = new ShopFrontpage();
            Amazona.AddLagerbestand(new Produkt("Tee", 1.5), 30);
            Amazona.AddLagerbestand(new Produkt("Kokain", 75), 150);
            Amazona.AddLagerbestand(new Produkt("Hackfleisch",8.30/1000),15000);
            Amazona.AddLagerbestand(new Produkt("Lumpen",15.21),13);
            Amazona.AddLagerbestand(new Produkt("Zigaretten",.20),105);
            Amazona.AddLagerbestand(new Produkt("Feuerzeug",1.25),3);
            Amazona.AddLagerbestand(new Produkt("Platzhalter",10.34),2);
            Amazona.AddLagerbestand(new Produkt("Platzhalter",10.34),2);
            Amazona.AddLagerbestand(new Produkt("Platzhalter",10.34),2);
            Amazona.AddLagerbestand(new Produkt("Platzhalter",10.34),2);
            Amazona.AddLagerbestand(new Produkt("Platzhalter",10.34),2);
            Amazona.Register(new Kunde("Ferhat"));
            Amazona.Register(new Kunde("Naeem"));
            Amazona.Register(new Kunde("Tescht"));
            Amazona.Register(new Kunde("Ceylan"));
            Amazona.Register(new Kunde("Fatih"));
            while (true)
            {
                Console.WriteLine("Was moechten Sie tun?");
                Console.WriteLine("[1] Einloggen/Registrieren");
                Console.WriteLine("[2] Warenkorb ansehen");
                Console.WriteLine("[3] Angebote ansehen");
                Console.WriteLine("[4] Clear");
                Console.WriteLine("[5] Artikel bestellen");
                Console.WriteLine("[6] Amazona verlassen");
                int antwort = Convert.ToInt32(Console.ReadLine());
                switch (antwort)
                {
                    case 1:
                        Console.Write("Bitte geben Sie Ihren Namen ein:\n==>  ");
                        string name = Console.ReadLine();
                        if (!Amazona.GetRegistered(name))
                            Console.WriteLine("Konto wurde angelegt");
                        else
                            Console.WriteLine("Willkommen zurueck");
                        Console.WriteLine("\n\n\n");
                        break;
                    case 2:
                        if (Amazona.GetLoggedIn() != null)
                            Amazona.GetLoggedIn().GetWarenkorb().WarenkorbAnzeigen();
                        else
                            Console.WriteLine("Du musst dich zuerst einloggen");
                        Console.WriteLine("\n\n\n");
                        break;
                    case 3:
                        Amazona.GetLagerbestand();
                        Console.WriteLine("\n\n\n");
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    case 5:
                        if (Amazona.GetLoggedIn() != null)
                        {
                            Amazona.LagerAuflisten();
                            Console.Write("Welchen Artikel moechtest du kaufen?\n==>  ");
                            int art = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wie viele davon?\n==>  ");
                            int menge = Convert.ToInt32(Console.ReadLine());
                            //Amazona.GetLoggedIn().GetWarenkorb().ArtikelHinzufuegen(Amazona.GetLager().GetProduktByID(art));
                            Amazona.GetLager().Umlagern(Amazona.GetLager(), Amazona.GetLoggedIn().GetWarenkorb(), Amazona.GetLager().GetProduktByID(art), menge);
                        }
                        else
                            Console.WriteLine("Logge dich vorher ein.");
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Bis demnaechst!");
                        Random random = new Random();
                        Thread.Sleep(random.Next(2427,4262));
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
