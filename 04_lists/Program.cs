namespace _04_lists;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Arrays & Lists example ---\n");
        new ArraysExample().Characters();

        Console.WriteLine();
        Console.WriteLine("--- Remove example ---\n");
        new RemoveExample().Run();

        Console.WriteLine();
        Console.WriteLine("--- Remove in loop example ---\n");
        new RemoveInLoopExample().Run();

        Console.WriteLine();
        Console.WriteLine("--- LINQ example ---\n");
        new LinqExample().Run();

        Console.WriteLine();
        Console.WriteLine("Done. Press Enter to exit.");
        Console.ReadLine();
    }
}
