using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class ShopFrontpage
    {
        private Liste Lagerbestand = new Liste();
        private List<Kunde> registrierteKunden = new List<Kunde>();
        private Kunde eingelogt;
        public void AddLagerbestand(Produkt Artikel, int Stueckzahl)
        {
            this.Lagerbestand.Add(Artikel, Stueckzahl);
        }
        public void GetLagerbestand()
        {
            int i = this.Lagerbestand.GetCount();
            Knoten current = this.Lagerbestand.GetFirst();
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($" -:- {current.GetDaten().GetBezeichner()} zu {current.GetDaten().GetPreis()} je Stueck/gramm/etc. <{current.GetStueckzahl()}> noch vorhanden. -:- ");
                current = current.GetNext();
            }
        }
        public void LagerAuflisten()
        {
            int i = this.Lagerbestand.GetCount();
            Knoten current = this.Lagerbestand.GetFirst();
            for (int j = 1; j < i; j++)
            {
                Console.WriteLine($" -:- [{j}] {current.GetDaten().GetBezeichner()} -:- ");
                current = current.GetNext();
            }
        }
        public Liste GetLager()
        { return this.Lagerbestand; }
        public bool GetRegistered(string kunde)
        {
            foreach (Kunde k in registrierteKunden)
                if (k.GetName() == kunde)
                {
                    Console.WriteLine("Konto gefunden");
                    this.SetLoggedIn(k);
                    return true;
                }
            Console.WriteLine("Konto nicht vorhanden");
            this.Register(new Kunde(kunde));
            return false;
        }
        public void Register(Kunde k)
        {
            this.registrierteKunden.Add(k);
        }
        public void SetLoggedIn(Kunde kunde)
        {
            this.eingelogt = kunde;
        }
        public Kunde GetLoggedIn()
        {
            return this.eingelogt;
        }
    }
}
