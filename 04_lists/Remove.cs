using System;
using System.Collections.Generic;

namespace _04_lists;

class RemoveExample
{
    public void Run()
    {
        List<double> numbers = new List<double> { 12.5, 342.97, 5.1, 200.0 };

        Console.WriteLine("Original numbers:");
        foreach (var n in numbers) Console.WriteLine(n);

        // remove the highest value using Remove
        double max = double.MinValue;
        foreach (var n in numbers) if (n > max) max = n;
        numbers.Remove(max);

        Console.WriteLine();
        Console.WriteLine($"After Remove(max={max}):");
        foreach (var n in numbers) Console.WriteLine(n);

        // remove first element using RemoveAt
        if (numbers.Count > 0) numbers.RemoveAt(0);

        Console.WriteLine();
        Console.WriteLine("After RemoveAt(0):");
        foreach (var n in numbers) Console.WriteLine(n);
    }
}
