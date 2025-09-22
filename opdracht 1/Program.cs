using System.Linq;
using System;

class Program{
    static void Main(string[] args)
    {
        //Naam van de opdracht
        Console.WriteLine("Opdracht 1 Condities en iteraties in C#");
        Console.WriteLine("");

        Console.Write("Geef jouw string in dat je wilt omkeren: ");
        string gebruikers_input = Console.ReadLine();


        //intro voor de code
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Kies één van de onderstaande methodes om jouw string om te keren");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine(" 1. for loop");
        Console.WriteLine(" 2. while loop");
        Console.WriteLine(" 3. do while loops");
        Console.WriteLine(" 4. recursie ");

        //First(); pakt eigenlijk de eerste cijfer van de getal, bv als je 897 typt pakt .First() 8 als eerst.
        char keuze_gebruiker = Console.ReadLine().First();
        string resultaat = "";


        switch (keuze_gebruiker)
        {
            //deze is de for loop methode
            case '1':

                static string forloopOmgekeerd(string fl)
                {
                    string resultaat = "";
                    for (int i = fl.Length - 1; i >= 0; i--)
                    {
                        resultaat += fl[i];
                    }
                    return resultaat;
                }
                resultaat = forloopOmgekeerd(gebruikers_input);
                break;

            //deze is de while loop methode
            case '2':

                static string whileLoopOmgekeerd(string wl)
                {
                    string resultaat = "";

                    int i = wl.Length - 1;
                    while (i >= 0)
                    {
                        resultaat += wl[i];
                        i--;
                    }
                    return resultaat;
                }

                resultaat = whileLoopOmgekeerd(gebruikers_input);
                break;

            //deze is de dowhile loop methode
            case '3':

                static string dowhileloopOmgekeerd(string dwl)
                {
                    
                    if (dwl.Length == 0) return "";
                   
                    string resultaat = "";
                    int i = dwl.Length - 1;

                    do
                    {
                        resultaat += dwl[i];
                        i--;
                    } while (i >= 0);
                    return resultaat;
                }

                resultaat = dowhileloopOmgekeerd(gebruikers_input);
                break;

            //deze is de recursie methode, ik heb deze met chatgpt gemaakt want ik wist niet hoe ik het in recursie moest doen
            case '4':
                
                static string RecursieOmgekeerd(string recursie)
                {
                    if (recursie.Length == 0) return "";
                    return recursie[recursie.Length - 1] + RecursieOmgekeerd(recursie.Substring(0, recursie.Length - 1));
                }
                resultaat = RecursieOmgekeerd(gebruikers_input);
                break;

            default:
                Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
                return;

        }

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Omgekeerde string is : " + resultaat);
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
}