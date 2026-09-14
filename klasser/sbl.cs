using System;
using System.Collections.Generic;
using System.Text;

namespace Olympex.klasser
{
    public class Sbl : Gymmare //ny klass för att öve polymorfism
    {
        public override void Träna()
        {
            Console.WriteLine("Gymmaren tränar optimalt för den följer sbl");
        }
    }
}
