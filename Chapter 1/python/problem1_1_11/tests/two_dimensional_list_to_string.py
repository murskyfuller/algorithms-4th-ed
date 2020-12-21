import unittest
from problem1_1_11.main import two_dimensional_list_to_string


class TestTwoDimensionalListToString(unittest.TestCase):
    def test_raises_type_error(self):
        self.assertRaises(TypeError, two_dimensional_list_to_string, None)

    def test_returns_correct_string(self):
        # Arrange
        lst = [[True, True, True], [False, False, False], [True, False, True]]

        # Act
        result = two_dimensional_list_to_string(lst)

        # Assert
        self.assertEqual("  1 2 3\n1 * * *\n2      \n3 *   *", result)

    @unittest.skip("Not implemented, yet.")
    def test_correct_spacing_with_greater_than_ten_columns(self):
        # TODO returned value should adjust column width with greater header length.
        raise NotImplementedError()

    @unittest.skip("Not implemented, yet.")
    def test_correct_spacing_with_greater_than_ten_rows(self):
        # TODO returned value should adjust row header width with greater header length.
        raise NotImplementedError()

if __name__ == "__main__":
    unittest.main()
