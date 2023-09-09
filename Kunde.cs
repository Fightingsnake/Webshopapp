using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class Kunde
    {
        private string name;
        private Warenkorb warenkorb;
        private Warenkorb wunschliste;
        public Kunde(string name)
        {
            this.name = name;
            this.warenkorb = new Warenkorb();
            this.wunschliste = new Warenkorb();
        }
        public string GetName()
        {
            return this.name;
        }
        public Warenkorb GetWarenkorb()
        {
            return this.warenkorb;
        }
        public Warenkorb GetWunschliste()
        {
            return this.wunschliste;
        }
    }
}
