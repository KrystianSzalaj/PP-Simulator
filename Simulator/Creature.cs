namespace Simulator;

public class Creature
{
    private string _name = "Unknown";
    private int _level = 1;

    public string Name
    {
        get => _name;
        set
        {
            // Only allow setting the name if it is still the default
            if (_name != "Unknown") return;

            string trimmedValue = value.Trim();

            // Minimum length handling
            if (trimmedValue.Length < 3)
            {
                trimmedValue = trimmedValue.PadRight(3, '#');
            }
            else if (trimmedValue.Length > 25)
            {
                trimmedValue = trimmedValue.Substring(0, 25);
            }

            // Ensure it's at least 3 characters after trimming and padding
            if (trimmedValue.Length < 3)
            {
                trimmedValue = trimmedValue.PadRight(3, '#');
            }

            // Capitalize the first character if it's lowercase
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
            // Only allow setting the level if it is still the default
            if (_level != 1) return;

            // Clamp the level to the range of 1-10
            if (value < 1)
                _level = 1;
            else if (value > 10)
                _level = 10;
            else
                _level = value;
        }
    }

    // Constructors
    public Creature(string name, int level = 1)
    {
        Name = name;
        Level = level; // Note: this will set the level to the default if not in range
    }

    public Creature() { }

    // Methods
    public void SayHi()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am level {Level}.");
    }

    public string Info => $"{Name}, Level: {Level}";

    public void Upgrade()
    {
        if (_level < 10)
            _level++;
    }

    public void Go(Direction direction)
    {
        Console.WriteLine($"{Name} goes {direction.ToString().ToLower()}.");
    }

    public void Go(Direction[] directions)
    {
        foreach (var direction in directions)
        {
            Go(direction);
        }
    }

    public void Go(string directions)
    {
        var directionArray = DirectionParser.Parse(directions);
        Go(directionArray);
    }
}
