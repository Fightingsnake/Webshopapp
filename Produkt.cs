using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class Produkt
    {
        private string bezeichner;
        private double preis;

        public Produkt(string bezeichner, double preis)
        {
            this.bezeichner = bezeichner;
            this.preis = preis;
        }
        public string GetBezeichner()
        {
            return this.bezeichner; 
        }
        public double GetPreis()
        {
            return this.preis;
        }
    }
}
