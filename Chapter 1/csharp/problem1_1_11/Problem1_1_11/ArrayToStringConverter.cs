using System;
using System.Linq;

namespace Problem1_1_11
{
    public class ArrayToStringConverter : IArrayToStringConverter
    {
        public string ArrayToString(bool[] row)
        {
            if (row == null) throw new ArgumentNullException(nameof(row));

            return string.Join(' ', row.Select(v => v ? '*' : ' '));
        }

        public string TwoDimenionsalArrayToString(bool[][] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (array.Any((v) => v == null)) throw new ArgumentException("Cannot contain null items.", nameof(array));

            var result = "";

            if (array.Length > 0)
            {
                // Create the column header.
                var rowHeaderPadding = "  "; // Padding for row headers to fall under.
                var columnCount = array.First().Length;
                result += $"{rowHeaderPadding}{string.Join(" ", Enumerable.Range(1, columnCount).Select(v => v))}\n";

                // Create the grid.
                result += string.Join("\n", array.Select((row, ix) => $"{ix + 1} {ArrayToString(row)}"));
            }

            return result;
        }
    }
}
