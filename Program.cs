using Olympex.klasser;

namespace Olympex
{
    public class Program
    {
        static void Main(string[] args)
        {
            //första personen som gymmar, skapat första objektet
            Gymmare Bob = new Gymmare();

            Bob.namn = "Bob";
            Bob.ålder = 30;

            Bob.Träna();

            Bodybuilder Arnold = new Bodybuilder();
            Arnold.namn = "Arnold";
            Arnold.ålder = 40;

            Arnold.Träna();
            Arnold.optimal();

            Sbl Tim = new Sbl();
            Tim.namn = "Tim";
            Tim.ålder = 20;

            Tim.Träna();


        }
    }
}
