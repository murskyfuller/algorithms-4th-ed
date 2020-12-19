import unittest
from problem1_1_5.main import solution


class TestSolution(unittest.TestCase):

    def test_true_when_both_in_range(self):
        self.assertTrue(solution(0.1, 0.9))

    def test_false_with_0(self):
        self.assertFalse(solution(0, 0.9))

    def test_false_with_1(self):
        self.assertFalse(solution(0.1, 1))

    def test_false_with_negative(self):
        self.assertFalse(solution(-0.1, 0.9))

    def test_false_with_greater_than_1(self):
        self.assertFalse(solution(0.1, 1.1))

    def test_false_with_both_out_of_range(self):
        self.assertFalse(solution(-0.1, 1.1))


if __name__ == '__main__':
    unittest.main()
