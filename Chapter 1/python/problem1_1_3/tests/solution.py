import unittest
from unittest.mock import patch
from problem1_1_3.main import solution


class TestSolution(unittest.TestCase):

    @patch('builtins.input', return_value="1,1,1")
    def test_prompts_with_console(self, mock_prompt):
        # Act
        solution()

        # Assert
        self.assertTrue(mock_prompt.called)

    @patch('builtins.input', return_value="1,1,1")
    @patch('problem1_1_3.main.are_equal', return_value=True)
    def test_prints_equal(self, mock_prompt, mock_are_equal):
        # Arrange
        expected_out = "equal"

        # Act
        result = solution()

        # Assert
        self.assertEqual(result, expected_out)

    @patch('builtins.input', return_value="1,2,2")
    @patch('problem1_1_3.main.are_equal', return_value=False)
    def test_prints_notequal(self, mock_prompt, mock_are_equal):
        # Arrange
        expected_out = "not equal"

        # Act
        result = solution()

        # Assert
        self.assertEqual(result, expected_out)


if __name__ == '__main__':
    unittest.main()
