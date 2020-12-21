namespace Problem1_1_11
{
    public interface IArrayToStringConverter
    {
        /// <summary>
        /// Converts the provided array to a single line string.
        /// </summary>
        /// <param name="row">The array to convert.</param>
        /// <returns>The string representation of the array.</returns>
        string ArrayToString(bool[] row);

        /// <summary>
        /// Converts the provided two-dimensional array to a string.
        /// </summary>
        /// <param name="array">The array to convert.</param>
        /// <returns>A string grid representation of the two-dimensional array.</returns>
        string TwoDimenionsalArrayToString(bool[][] array);
    }
}
