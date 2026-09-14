using System;
using System.Collections.Generic;
using System.Text;

public class Bodybuilder : Gymmare //skapar första arvet
{
    public string gymsplit;

    new public void Träna() //skapar en ny metod som heter samma sak som i basklassen
    {
        base.Träna(); //använder basklassens metod
        Console.WriteLine("Bodybuildern tränar");
    }

    public void optimal()
    {
        Console.WriteLine("Bodybuildern inte tränar optimalt");
    }
}
