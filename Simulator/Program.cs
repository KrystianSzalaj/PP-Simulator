public class Program
{
    static void Main()
    {
        Lab5a();
    }

    static void Lab5a()
    {
        try
        {
            Console.WriteLine("Creating rectangles with various points and coordinates:");

            // Test with coordinates
            Rectangle rect1 = new Rectangle(2, 3, 10, 8);
            Console.WriteLine(rect1);  // Expected: (2, 3):(10, 8)

            // Test with unordered coordinates
            Rectangle rect2 = new Rectangle(10, 8, 2, 3);
            Console.WriteLine(rect2);  // Expected: (2, 3):(10, 8)

            // Test with points
            Point p1 = new Point(4, 5);
            Point p2 = new Point(12, 15);
            Rectangle rect3 = new Rectangle(p1, p2);
            Console.WriteLine(rect3);  // Expected: (4, 5):(12, 15)

            // Test collinear points exception
            try
            {
                Rectangle invalidRect = new Rectangle(5, 5, 5, 10);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }

            // Test point containment
            Point testPointInside = new Point(6, 7);
            Point testPointOutside = new Point(1, 1);
            Console.WriteLine($"rect1.Contains({testPointInside}): {rect1.Contains(testPointInside)}"); // Expected: True
            Console.WriteLine($"rect1.Contains({testPointOutside}): {rect1.Contains(testPointOutside)}"); // Expected: False
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected exception: {ex.Message}");
        }
    }
}
