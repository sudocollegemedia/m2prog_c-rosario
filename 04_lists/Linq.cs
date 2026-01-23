using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_lists;

class Mob
{
    public string Name { get; set; }
    public int HP { get; set; }
    public bool IsDead { get; private set; }

    public Mob(string name, int hp)
    {
        Name = name;
        HP = hp;
        IsDead = false;
    }

    public void TakeDamage(int damage)
    {
        HP -= damage;
        if (HP <= 0)
        {
            HP = 0;
            IsDead = true;
        }
    }

    public override string ToString() => $"{Name} (HP={HP})";
}

class LinqExample
{
    public void Run()
    {
        var mobs = new List<Mob>
        {
            new Mob("Goblin", 50),
            new Mob("Orc", 80),
            new Mob("Troll", 120)
        };

        var rand = new Random();

        for (int round = 0; round < 100; round++)
        {
            foreach (var m in mobs)
            {
                if (rand.Next(100) < 30)
                {
                    int dmg = rand.Next(1, 21);
                    m.TakeDamage(dmg);
                }
            }
        }

        Console.WriteLine("All mobs:");
        foreach (var m in mobs) Console.WriteLine(m + (m.IsDead ? " [DEFEATED]" : ""));

        var defeated = mobs.Where(m => m.IsDead).ToList();
        Console.WriteLine();
        Console.WriteLine("Defeated mobs (Using LINQ Where):");
        foreach (var d in defeated) Console.WriteLine(d.Name);
    }
}
