using System;
using System.Collections.Generic;

namespace _04_lists;

class Pickup
{
    public string Name { get; set; }
    public int Value { get; set; }
    public Pickup(string name, int value)
    {
        Name = name;
        Value = value;
    }
    public override string ToString() => $"{Name} (Value={Value})";
}

class RemoveInLoopExample
{
    public void Run()
    {
        List<Pickup> pickups = new List<Pickup>();
        for (int i = 0; i < 8; i++) pickups.Add(new Pickup($"Pickup{i}", (i + 1) * 30));

        Console.WriteLine("All pickups before picking up:");
        foreach (var p in pickups) Console.WriteLine(p);

        Console.WriteLine();
        Console.WriteLine("Picking up items with Value < 50 (iterate backwards):");
        for (int i = pickups.Count - 1; i >= 0; i--)
        {
            if (pickups[i].Value < 50)
            {
                var picked = pickups[i];
                pickups.RemoveAt(i);
                Console.WriteLine($"Picked up: {picked}");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Remaining pickups:");
        foreach (var p in pickups) Console.WriteLine(p);
    }
}
