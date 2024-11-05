namespace Simulator
{
    public class Orc : Creature
    {
        private int _rage;
        private int _huntCount;

        public int Rage
        {
            get => _rage;
            private set => _rage = Validator.Limiter(value, 0, 10);
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
        public override string Info => $"{Name} [{Level}][{Rage}]";
    }
}
