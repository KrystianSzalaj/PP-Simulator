namespace Simulator
{
    public class Animals
    {
        private string _description = "Unknown Animal";
        private int _size = 1;

        public string Description
        {
            get => _description;
            set => _description = Validator.Shortener(value, 3, 20, '#');
        }

        public int Size
        {
            get => _size;
            set => _size = Validator.Limiter(value, 1, 10000);
        }

        public virtual string Info => $"{Description} <{Size}>";

        public override string ToString()
        {
            return $"{GetType().Name.ToUpper()}: {Info}";
        }
    }
}
