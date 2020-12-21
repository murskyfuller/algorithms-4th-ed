import unittest
from problem1_1_11.main import list_to_string


class TestListToString(unittest.TestCase):
    def test_raises_type_error(self):
        self.assertRaises(TypeError, list_to_string, None)

    def test_returns_correctly_all_true(self):
        # Arrange
        lst = [True, True, True]

        # Act
        result = list_to_string(lst)

        # Assert
        self.assertEqual("* * *", result)

    def test_returns_correctly_all_false(self):
        # Arrange
        lst = [False, False, False]

        # Act
        result = list_to_string(lst)

        # Assert
        self.assertEqual("     ", result)

    def test_returns_correctly_mixed_values(self):
        # Arrange
        lst = [True, False, True]

        # Act
        result = list_to_string(lst)

        # Assert
        self.assertEqual("*   *", result)


if __name__ == "__main__":
    unittest.main()
