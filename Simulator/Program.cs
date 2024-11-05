using System;

namespace Simulator
{
    public class Program
    {
        static void Main()
        {
            Lab4a();
        }

        static void Lab4a()
        {
            Console.WriteLine("HUNT TEST\n");
            var o = new Creature.Orc("Gorbag", rage: 7);
            o.SayHi();
            for (int i = 0; i < 10; i++)
            {
                o.Hunt();
                o.SayHi();
            }

            Console.WriteLine("\nSING TEST\n");
            var e = new Creature.Elf("Legolas", agility: 2);
            e.SayHi();
            for (int i = 0; i < 10; i++)
            {
                e.Sing();
                e.SayHi();
            }

            Console.WriteLine("\nPOWER TEST\n");
            Creature[] creatures = {
                o,
                e,
                new Creature.Orc("Morgash", 3, 8),
                new Creature.Elf("Elandor", 5, 3)
            };
            foreach (Creature creature in creatures)
            {
                Console.WriteLine($"{creature.Name,-15}: {creature.Power}");
            }
        }
    }
}
