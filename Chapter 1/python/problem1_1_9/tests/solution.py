import unittest
from problem1_1_9.main import solution


class TestSolution(unittest.TestCase):

    def test_returns_correct_value_for_1(self):
        self.assertEqual("1", solution(1))

    def test_returns_correct_value_for_2(self):
        self.assertEqual("10", solution(2))

    def test_returns_correct_value_for_3(self):
        self.assertEqual("11", solution(3))

    def test_returns_correct_value_for_7(self):
        self.assertEqual("111", solution(7))

    def test_returns_correct_value_for_8(self):
        self.assertEqual("1000", solution(8))

    def test_returns_correct_value_for_13(self):
        self.assertEqual("1101", solution(13))

    def test_returns_correct_value_for_15(self):
        self.assertEqual("1111", solution(15))

    def test_returns_correct_value_for_16(self):
        self.assertEqual("10000", solution(16))

    def test_returns_correct_value_for_17(self):
        self.assertEqual("10001", solution(17))

    def test_returns_correct_value_for_54673890(self):
        self.assertEqual("11010000100100000111100010", solution(54673890))


if __name__ == '__main__':
    unittest.main()
