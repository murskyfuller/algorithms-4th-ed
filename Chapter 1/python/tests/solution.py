import unittest
from io import StringIO
from unittest.mock import patch
from main import solution


class TestSolution(unittest.TestCase):

    @patch('builtins.input', return_value="1 1 1")
    def test_prompts_with_console(self, mock_prompt):
        # Act
        solution()

        # Assert
        self.assertTrue(mock_prompt.called)

    @patch('builtins.input', return_value="1 1 1")
    def test_prints_equal(self, mock_prompt):
        # Arrange
        expected_out = "equal"

        with patch('sys.stdout', new=StringIO()) as fake_out:
            # Act
            solution()

            # Assert
            self.assertEqual(fake_out.getvalue().strip(), expected_out)

    @patch('builtins.input', return_value="1 2 2")
    def test_prints_notequal(self, mock_prompt):
        # Arrange
        expected_out = "not equal"

        with patch('sys.stdout', new=StringIO()) as fake_out:
            # Act
            solution()

            # Assert
            self.assertEqual(fake_out.getvalue().strip(), expected_out)


if __name__ == '__main__':
    unittest.main()
