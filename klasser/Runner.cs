using System;
using System.Collections.Generic;
using System.Text;

namespace Olympex.klasser
{
    abstract class Runner //abstraktion klassen med Cardio som abstrakt eftersom det är olika typer av träning flr en sprinter och en maratonlöppare
    {
        public abstract void Cardio();
    }

    class Sprinter : Runner
    {
        public string namn;
        public int ålder;
        public override void Cardio()
        {
            Console.WriteLine("Sprintern springer snabbt");
        }
    }

    class Marathonlöpare : Runner
    {
        public string namn;
        public int ålder;
        public override void Cardio()
        {
            Console.WriteLine("Marathonlöparen springer långt");
        }
    }
}
