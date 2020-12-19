def is_divisible_by(n: int, divisor: int) -> bool:
    """
    Determines if the first argument is divisible by the second without a remainder.
    :param n: The number to check.
    :param divisor: The number to divide by.
    :return: True if the first parameter is evenly divisible by the second, otherwise False.
    """
    return n % divisor == 0

def solution(n: int) -> str:
    """
    Generates a string for the binary representation of the provided number.
    :param n: The number to get the binary representation for.
    :return: The binary representation for the provided number as a string.
    """
    result = ""

    # Build the string by checking each binary position's even-odd property.
    while n > 0:
        result = f'{"0" if is_divisible_by(n, 2) else "1"}{result}'
        n = n//2

    return result
