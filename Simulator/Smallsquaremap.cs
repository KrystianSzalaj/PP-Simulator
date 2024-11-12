using Simulator;

namespace Simulator.Maps;

public class SmallSquareMap : Map
{
    public int Size { get; }

    public SmallSquareMap(int size)
    {
        if (size < 5 || size > 20)
        {
            throw new ArgumentOutOfRangeException(nameof(size), "Size must be between 5 and 20.");
        }
        Size = size;
    }

    public override bool Exist(Point p) =>
        p.X >= 0 && p.X < Size && p.Y >= 0 && p.Y < Size;

    public override Point Next(Point p, Direction d) // Użycie Direction bez pełnej kwalifikacji
    {
        Point nextPoint = p.Next(d);

        return Exist(nextPoint) ? nextPoint : p;
    }

    public override Point NextDiagonal(Point p, Direction d)
    {
        Point nextDiagonalPoint = p.NextDiagonal(d);

        return Exist(nextDiagonalPoint) ? nextDiagonalPoint : p;
    }
}
