﻿namespace Simulator
{
    public class Elf : Creature
    {
        private int _agility;
        private int _singCount;

        public int Agility
        {
            get => _agility;
            private set => _agility = Validator.Limiter(value, 0, 10);
        }

        public Elf() : base("Unknown Elf", 1)
        {
            Agility = 0;
        }

        public Elf(string name, int level = 1, int agility = 0) : base(name, level)
        {
            Agility = agility;
        }

        public void Sing()
        {
            _singCount++;
            if (_singCount % 3 == 0)
            {
                Agility++;
            }
        }

        public override void SayHi()
        {
            Console.WriteLine($"Hi, I am an Elf named {Name} with level {Level} and agility {Agility}.");
        }

        public override int Power => (8 * Level) + (2 * Agility);
        public override string Info => $"{Name} [{Level}][{Agility}]";
    }
}