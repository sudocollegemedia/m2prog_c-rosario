using System.Runtime.CompilerServices;

namespace _05_dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();
        personeelOpNummer.Add(1, "Jan Jansen");
        personeelOpNummer.Add(2, "Piet Pietersen");
        Console.WriteLine(personeelOpNummer[1]);

        foreach (KeyValuePair<int, string> medewerker in personeelOpNummer)
        {
            Console.WriteLine($"Nummer: {medewerker.Key}, Naam: {medewerker.Value}");
        }
    }
}
