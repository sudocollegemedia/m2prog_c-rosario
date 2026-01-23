// 06_fileio/Program.cs
using System;
using System.IO;

namespace _06_fileio;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Read & Write Files example ---\n");
        new FileIOExample().Run();

        Console.WriteLine();
        Console.WriteLine("Done. Press Enter to exit.");
        Console.ReadLine();
    }
}

// 06_fileio/FileIOExample.cs
namespace _06_fileio;

class FileIOExample
{
    private string filePath = "data.txt";

    public void Run()
    {
        // Write to file
        Console.WriteLine("Writing to file...");
        WriteToFile();

        // Read from file
        Console.WriteLine("\nReading from file...");
        ReadFromFile();

        // Append to file
        Console.WriteLine("\nAppending to file...");
        AppendToFile();

        // Read again to show appended content
        Console.WriteLine("\nReading file again after append...");
        ReadFromFile();
    }

    private void WriteToFile()
    {
        string[] lines = {
            "Line 1: Hello World",
            "Line 2: C# File I/O",
            "Line 3: Writing files"
        };

        File.WriteAllLines(filePath, lines);
        Console.WriteLine($"Written {lines.Length} lines to {filePath}");
    }

    private void ReadFromFile()
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine($"Read {lines.Length} lines:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine($"File {filePath} does not exist.");
        }
    }

    private void AppendToFile()
    {
        string newLine = "Line 4: Appended content";
        File.AppendAllText(filePath, "\n" + newLine);
        Console.WriteLine($"Appended: {newLine}");
    }
}
