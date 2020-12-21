from typing import List


def list_to_string(lst: List[bool]) -> str:
    """
    Generates a string representation of the provided boolean list.
    :param lst: The boolean list to convert.
    :return: A string representing the list.
    """
    if lst is None:
        raise TypeError()

    return " ".join(["*" if v is True else " " for v in lst])


def two_dimensional_list_to_string(lst: List[List[bool]]) -> str:
    """
    Generates a string representing a grid of the two-dimensional list.
    :param lst: The two-dimensional boolean list to convert.
    :return: A string representing the two-dimensional list.
    """
    if lst is None:
        raise TypeError()

    result = ""

    if len(lst) > 0:
        # Create the column header.
        row_header_padding = "  "
        column_headers = [str(v) for v in range(1, len(lst[0]) + 1)]
        result += f'{row_header_padding}{" ".join(column_headers)}\n'

        # Create the grid.
        result += "\n".join([f'{ix + 1} {list_to_string(v)}' for ix, v in enumerate(lst)])

    return result

