using System.Runtime.CompilerServices;

namespace _05_dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, Employee> personeelOpNummer = new Dictionary<int, Employee>();
        personeelOpNummer.Add(1, new Employee(1, "Jan Jansen"));
        personeelOpNummer.Add(2, new Employee(2, "Piet Pietersen"));
        Console.WriteLine(personeelOpNummer[1]);

        foreach (KeyValuePair<int, Employee> medewerker in personeelOpNummer)
        {
            Console.WriteLine($"Nummer: {medewerker.Key}, Naam: {medewerker.Value.Name}");
        }
    }
}

// Employee.cs
public class Employee
{
    public int Number { get; set; }
    public string Name { get; set; }

    public Employee(int number, string name)
    {
        Number = number;
        Name = name;
    }

    public override string ToString()
    {
        return $"Nummer: {Number}, Naam: {Name}";
    }
}
