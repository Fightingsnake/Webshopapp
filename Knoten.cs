using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class Knoten
    {
        private Knoten next;
        private object daten;
        private int stueckzahl;

        public void SetNext(Knoten next)
        { this.next = next; }
        public Knoten GetNext()
        { return this.next; }
        public void SetDaten(object daten)
        { this.daten = daten; }
        public Produkt GetDaten() 
        { return (Produkt)this.daten; }
        public void SetStueckzahl(int stueckzahl)
        { this.stueckzahl = stueckzahl; }
        public int GetStueckzahl()
        { return this.stueckzahl; }
    }
}
