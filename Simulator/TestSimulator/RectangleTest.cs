using Microsoft.VisualBasic;

class TestRectangle(unittest.TestCase) :
    def test_creation(self):
        rect = Rectangle(Point(0, 0), Point(3, 3))
        self.assertEqual(rect.bottom_left, Point(0, 0))
        self.assertEqual(rect.top_right, Point(3, 3))

    def test_area(self):
        rect = Rectangle(Point(0, 0), Point(3, 3))
        self.assertEqual(rect.area(), 9)

    def test_intersection(self):
        rect1 = Rectangle(Point(0, 0), Point(3, 3))
        rect2 = Rectangle(Point(2, 2), Point(5, 5))
        intersection = rect1.intersection(rect2)
        self.assertEqual(intersection, Rectangle(Point(2, 2), Point(3, 3)))

    def test_no_intersection(self):
        rect1 = Rectangle(Point(0, 0), Point(3, 3))
        rect2 = Rectangle(Point(4, 4), Point(5, 5))
        self.assertIsNone(rect1.intersection(rect2))

    def test_invalid_creation(self):
        with self.assertRaises(ValueError):
            Rectangle(Point(3, 3), Point(0, 0))
