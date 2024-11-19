using System.Drawing;

import unittest

class TestPoint(unittest.TestCase) :
    def test_creation(self):
        point = Point(2, 3)
        self.assertEqual(point.x, 2)
        self.assertEqual(point.y, 3)

    def test_equality(self):
        p1 = Point(2, 3)
        p2 = Point(2, 3)
        p3 = Point(3, 2)
        self.assertEqual(p1, p2)
        self.assertNotEqual(p1, p3)

    def test_invalid_creation(self):
        with self.assertRaises(ValueError):
            Point("a", 3)
        with self.assertRaises(ValueError):
            Point(2, None)
