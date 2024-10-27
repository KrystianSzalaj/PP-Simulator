using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator;

public class Creature
{
    // Właściwości automatyczne
    public string Name { get; set; }
    public int Level { get; set; } = 1; // Wartość domyślna 1

    // Konstruktor przyjmujący wartości początkowe
    public Creature(string name, int level = 1)
    {
        Name = name;
        Level = level;
    }

    // Bezparametrowy konstruktor
    public Creature()
    {
        // Nie robi nic
    }

    // Metoda SayHi
    public void SayHi()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am level {Level}.");
    }

    // Właściwość do odczytu Info
    public string Info => $"{Name}, Level: {Level}";
}
