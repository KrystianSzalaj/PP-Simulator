// Dodaj użycie Simulator.Direction
using Simulator.Maps;

public class Program
{
    static void Main()
    {
        Lab5b();
    }

    static void Lab5b()
    {
        try
        {
            Console.WriteLine("Testing SmallSquareMap:");

            // Test with valid size
            var map = new SmallSquareMap(10);
            Console.WriteLine($"Map Size: {map.Size}");

            // Test Exist
            Point insidePoint = new Point(3, 3);
            Point outsidePoint = new Point(10, 10);

            Console.WriteLine($"Exist({insidePoint}): {map.Exist(insidePoint)}"); // Expected: True
            Console.WriteLine($"Exist({outsidePoint}): {map.Exist(outsidePoint)}"); // Expected: False

            // Test Next within bounds
            Point start = new Point(5, 5);
            Console.WriteLine($"Next({start}, Simulator.Direction.Right): {map.Next(start, Simulator.Direction.Right)}"); // Expected: (6, 5)

            // Test Next outside bounds
            Point edge = new Point(9, 9);
            Console.WriteLine($"Next({edge}, Simulator.Direction.Right): {map.Next(edge, Simulator.Direction.Right)}"); // Expected: (9, 9)

            // Test NextDiagonal within bounds
            Console.WriteLine($"NextDiagonal({start}, Simulator.Direction.Up): {map.NextDiagonal(start, Simulator.Direction.Up)}"); // Expected: (6, 6)

            // Test NextDiagonal outside bounds
            Point diagonalEdge = new Point(9, 0);
            Console.WriteLine($"NextDiagonal({diagonalEdge}, Simulator.Direction.Left): {map.NextDiagonal(diagonalEdge, Simulator.Direction.Left)}"); // Expected: (9, 0)

            // Test with invalid size
            try
            {
                var invalidMap = new SmallSquareMap(3); // Should throw exception
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Caught exception: {ex.Message}");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected exception: {ex.Message}");
        }
    }
}
