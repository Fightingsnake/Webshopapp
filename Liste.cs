using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class Liste
    {
        private Knoten first, last, brandnew;
        private int count = 0;
        public void Add(object item)
        {
            brandnew = new Knoten();
            brandnew.SetNext(null);
            brandnew.SetDaten(item);
            if (first == null)
            {
                first = brandnew;
                last = brandnew;
            }
            else
            {
                last.SetNext(brandnew);
                last = brandnew;
            }
            count++;
        }
        public void Add(object item, int stueck)
        {
            brandnew = new Knoten();
            brandnew.SetNext(null);
            brandnew.SetDaten(item);
            brandnew.SetStueckzahl(stueck);
            if (first == null)
            {
                first = brandnew;
                last = brandnew;
            }
            else
            {
                last.SetNext(brandnew);
                last = brandnew;
            }
            count++;
        }
        public Produkt GetProduktByID(int id)
        {
            Knoten current = first;
            for (int i = 1; i < id; i++)
            {
                current = current.GetNext();
            }
            return current.GetDaten();
        }
        public void Umlagern(Liste verkaeufer, Warenkorb kaeufer, Produkt artikel, int menge)
        {
            Knoten current = verkaeufer.GetFirst();
            for (int i = 0; i < verkaeufer.GetCount(); i++)
            {
                if (current.GetDaten() == artikel)
                {
                    if (current.GetStueckzahl() >= menge)
                    {
                        current.SetStueckzahl(current.GetStueckzahl() - menge);
                        kaeufer.ArtikelHinzufuegen(artikel, menge);
                        break;
                    }
                    else
                    {
                        if (current.GetStueckzahl() < menge)
                            Console.WriteLine("So viel ist nicht vorhanden");
                    }
                }
                else
                    current = current.GetNext();
            }
        }
        
        internal void ShowContent()
        {
            Knoten current = first;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(current.GetDaten());
                current = current.GetNext();
            }
        }
        internal int Search(object o)
        {
            int pos = 0;
            Knoten current;
            current = first;
            for (int i = 0; i < count; i++)
            {
                if (o == current.GetDaten())
                {
                    pos = i;
                    break;
                }
                current = current.GetNext();
            }
            return pos;
        }
        internal int GetCount()
        {
            return count;
        }
        internal Knoten GetFirst()
        {
            return first;
        }
        internal Knoten GetLast()
        {
            return last;
        }
        internal void RemoveFirst()
        {
            first = first.GetNext();
            count--;
        }
        internal void RemoveLast()
        {
            Knoten current = first;
            for (int i = 0; i < count - 2; i++)
            {
                current = current.GetNext();
            }
            current.SetNext(null);
            last = current;
            count--;
        }
        internal void RemoveCenter(string inhalt)
        {
            Knoten hilf, current;
            current = first;
            int pos = Search(inhalt);
            //Console.WriteLine(pos);
            for (int i = 0; i < pos - 1; i++)
            {
                current = current.GetNext();
                Console.WriteLine(current.GetDaten());
            }
            //Console.WriteLine(current.daten);
            Console.WriteLine(pos);
            hilf = current.GetNext().GetNext();
            current.SetNext(hilf);
            count--;
        }
    }
}
