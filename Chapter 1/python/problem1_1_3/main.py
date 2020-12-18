def are_equal(*args: int) -> bool:
    """
    Determines whether all of the provided integers are equal.
    :param args: The integer values to check.
    :return: True if all args are equal to each other, otherwise False.
    """
    result = True

    for ix, n in enumerate(args):
        if ix == 0:
            continue

        if args[ix] != args[ix-1]:
            # If any value does not equal the preceding value
            # they are not all equal.
            result = False
            break

    return result



def solution() -> str:
    """
    Prompts the user for integer values to check and prints whether
    they are equal or not to the command line.
    :return:
    """
    text_input = input("Enter three integers to test separated by commas (e.g. '1,2,3'):")

    numbers = []
    splits = text_input.split(",")
    for ix, n in enumerate(splits):
        while True:
            try:
                numbers.append(int(n))
                break
            except ValueError:
                # If any provided value is not a valid integer, request a replacement.
                n = input(f'{n} is an invalid integer. Please provide a replacement:')

    return "equal" if are_equal(*numbers) else "not equal"


if __name__ == '__main__':
    loop = True

    while loop:
        # Prompt user for integers.
        print(solution())

        # Ask user if they want to go again.
        goAgain = input("Would you like to check another set? [y/n]:")
        if goAgain.lower() != 'y':
            loop = False
