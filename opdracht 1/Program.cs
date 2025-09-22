using System.Linq.Expressions;

class Program{
    static void Main(string[] args)
    {
        //Naam van de opdracht
        Console.WriteLine("Opdracht 1 Condities en iteraties in C#");


        //intro voor de code
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Kies één van de onderstaande methodes om te testen");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine(" 1. for loop");
        Console.WriteLine(" 2. while loop");
        Console.WriteLine(" 3. do while loops");
        Console.WriteLine(" 4. recursie ");

        //First pakt eigenlijk de eerste cijfer van de getal, bv als je 897 typt pakt .First() 8 als eerst.
        char keuze_gebruiker = Console.ReadLine().First();

        switch (keuze_gebruiker)
        {
            case '1':

                break;
                
        }


    }
}