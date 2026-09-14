using System;
using System.Collections.Generic;
using System.Text;

namespace Olympex.klasser
{
    public class Crossfitter : Gymmare
    {
        // Privata attribut – bara synliga inom klassen (eller Gymmare, om protected)
        private string namn;
        private int ålder;

        // Publik property för namn
        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }
        public void Wod()
        {
            Console.WriteLine($"{Namn} kör dagens WOD!");
        }
    }
}
