using System;
using System.Collections.Generic;

namespace _04_lists;

class ArraysExample
{
    public void Characters()
    {
        string[] characters = new string[] {
            "Pac-Man",
            "Samus",
            "Crash Bandicoot",
            "Spyro the Dragon",
            "Donkey Kong",
            "Mario",
            "Luigi",
            "Astro",
            "Solid Snake",
            "Master Chief",
            "Kratos",
            "Sonic the Hedgehog",
            "Link"
        };

        List<string> characterList = new List<string>();

        // add characters from the array to the list
        for (int i = 0; i < characters.Length; i++)
        {
            characterList.Add(characters[i]);
        }

        // add one more character that's not in the array
        characterList.Add("Pikachu");

        Console.WriteLine("Characters (for loop):");
        for (int i = 0; i < characterList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {characterList[i]}");
        }

        Console.WriteLine();
        Console.WriteLine("Characters (foreach):");
        foreach (var c in characterList)
        {
            Console.WriteLine(c);
        }
    }
}
