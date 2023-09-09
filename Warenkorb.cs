using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class Warenkorb
    {
        private Liste einkaufsliste = new Liste();
        private double zwischensumme = 0;

        public void zwischensummeBerechnen()
        {
            int i = this.einkaufsliste.GetCount();
            Knoten current = this.einkaufsliste.GetFirst();
            for (int j = 0; j < i; j++)
            {
                zwischensumme += current.GetStueckzahl() * current.GetDaten().GetPreis();
                current = current.GetNext();
            }
        }
        public void WarenkorbAnzeigen()
        {
            int i = this.einkaufsliste.GetCount();
            if (i > 0)
            {
                Knoten current = this.einkaufsliste.GetFirst();
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine($"{j + 1}: {current.GetDaten().GetBezeichner()} ; {current.GetStueckzahl()} Stueck zu {current.GetDaten().GetPreis()} Euro ;" +
                                      $" {current.GetStueckzahl() * current.GetDaten().GetPreis()} Euro insgesamt.");
                    zwischensumme += current.GetStueckzahl() * current.GetDaten().GetPreis();
                    current = current.GetNext();
                }
                Console.WriteLine($"{zwischensumme} Euro insgesamt.");
            }
            else
                Console.WriteLine("Der Warenkorb ist leer.");
        }
        public Liste GetListe()
        {
            return this.einkaufsliste;
        }
        public void ArtikelHinzufuegen(Produkt artikel, int menge)
        {
            this.einkaufsliste.Add(artikel, menge);
        }

    }
}
