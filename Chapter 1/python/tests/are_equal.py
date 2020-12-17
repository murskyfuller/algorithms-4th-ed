import unittest
from main import are_equal


class TestAreEqual(unittest.TestCase):

    def test_are_equal_false(self):
        self.assertFalse(are_equal(1, 2, 2))

    def test_are_equal_true(self):
        self.assertFalse((are_equal(2, 2, 2)))


if __name__ == '__main__':
    unittest.main()
