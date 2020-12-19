import unittest
from problem1_1_9.main import is_divisible_by


class TestIsDivisibleBy(unittest.TestCase):

    def test_returns_true_for_4_2(self):
        self.assertTrue(is_divisible_by(4, 2))

    def test_returns_false_for_3_2(self):
        self.assertFalse(is_divisible_by(3, 2))

    def test_returns_true_for_9_3(self):
        self.assertFalse(is_divisible_by(9, 3))

    def _test_returns_false_for_9_4(self):
        self.assertFalse(is_divisible_by(9, 4))


if __name__ == '__main__':
    unittest.main()