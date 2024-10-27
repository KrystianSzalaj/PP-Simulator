using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator;

public class Creature
{
    // Prywatne pola dla właściwości
    private string _name = "Unknown";
    private int _level = 1;

    // Właściwość automatyczna Name z walidacją
    public string Name
    {
        get => _name;
        set
        {
            // Upewnij się, że Name można ustawić tylko raz
            if (_name != "Unknown") return;

            // Usuwanie spacji na początku i końcu
            string trimmedValue = value.Trim();

            // Upewnij się, że ma co najmniej 3 znaki
            if (trimmedValue.Length < 3)
            {
                trimmedValue = trimmedValue.PadRight(3, '#');
            }
            // Upewnij się, że ma najwyżej 25 znaków
            else if (trimmedValue.Length > 25)
            {
                trimmedValue = trimmedValue.Substring(0, 25);
            }

            // Upewnij się, że ma co najmniej 3 znaki po przycięciu
            if (trimmedValue.Length < 3)
            {
                trimmedValue = trimmedValue.PadRight(3, '#');
            }

            // Upewnij się, że pierwszy znak jest wielką literą
            if (char.IsLower(trimmedValue[0]))
            {
                trimmedValue = char.ToUpper(trimmedValue[0]) + trimmedValue[1..];
            }

            _name = trimmedValue;
        }
    }

    // Właściwość automatyczna Level z walidacją
    public int Level
    {
        get => _level;
        set
        {
            // Upewnij się, że Level można ustawić tylko raz
            if (_level != 1) return;

            if (value < 1)
                _level = 1;
            else if (value > 10)
                _level = 10;
            else
                _level = value;
        }
    }

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

    // Metoda Upgrade
    public void Upgrade()
    {
        if (_level < 10)
            _level++;
    }
}
