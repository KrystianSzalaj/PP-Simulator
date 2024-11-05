using System;

namespace Simulator
{
    public abstract class Creature
    {
        private string _name = "Unknown";
        private int _level = 1;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != "Unknown") return;

                string trimmedValue = value.Trim();

                if (trimmedValue.Length < 3)
                {
                    trimmedValue = trimmedValue.PadRight(3, '#');
                }
                else if (trimmedValue.Length > 25)
                {
                    trimmedValue = trimmedValue.Substring(0, 25);
                }

                if (trimmedValue.Length < 3)
                {
                    trimmedValue = trimmedValue.PadRight(3, '#');
                }

                if (char.IsLower(trimmedValue[0]))
                {
                    trimmedValue = char.ToUpper(trimmedValue[0]) + trimmedValue[1..];
                }

                _name = trimmedValue;
            }
        }

        public int Level
        {
            get => _level;
            set
            {
                if (_level != 1) return;

                if (value < 1)
                    _level = 1;
                else if (value > 10)
                    _level = 10;
                else
                    _level = value;
            }
        }

        protected Creature(string name, int level = 1)
        {
            Name = name;
            Level = level;
        }

        protected Creature() { }

        public abstract void SayHi();
        public abstract int Power { get; }

        // Oznaczamy Info jako wirtualne, aby mogło być przesłonięte
        public virtual string Info => $"{Name}, Level: {Level}";

        public void Upgrade()
        {
            if (_level < 10)
                _level++;
        }

        public class Elf : Creature
        {
            private int _agility;
            private int _singCount;

            public int Agility
            {
                get => _agility;
                private set => _agility = Math.Clamp(value, 0, 10);
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

            // Teraz Info może być przesłonięta
            public override string Info => $"{Name}, Level: {Level}, Agility: {Agility}";
        }

        public class Orc : Creature
        {
            private int _rage;
            private int _huntCount;

            public int Rage
            {
                get => _rage;
                private set => _rage = Math.Clamp(value, 0, 10);
            }

            public Orc() : base("Unknown Orc", 1)
            {
                Rage = 0;
            }

            public Orc(string name, int level = 1, int rage = 0) : base(name, level)
            {
                Rage = rage;
            }

            public void Hunt()
            {
                _huntCount++;
                if (_huntCount % 2 == 0)
                {
                    Rage++;
                }
            }

            public override void SayHi()
            {
                Console.WriteLine($"Hi, I am an Orc named {Name} with level {Level} and rage {Rage}.");
            }

            public override int Power => (7 * Level) + (3 * Rage);
        }
    }
}
