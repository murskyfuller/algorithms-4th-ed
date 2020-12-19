using System;

namespace Problem1_1_9
{
    public class Solution
    {
        /// <summary>
        /// Determines if the first argument is divisible by the second without a remainder.
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <param name="divisor">The number to divide by.</param>
        /// <returns>True if the first argument is evenly divisible by the second, otherwise returns false.</returns>
        public bool IsDivisibleBy(int n, int divisor)
        {
            return n % divisor == 0;
        }

        /// <summary>
        /// Generates the binary representation of a number and returns it as a string.
        /// </summary>
        /// <param name="n">The integer to convert to a binary string representation.</param>
        /// <returns>The binary string representation of the provided integer.</returns>
        public string Execute(int n)
        {
            var result = "";

            // Build the string by check each binary position's even-odd property.
            for (var i = n; i > 0; i /= 2)
                result = $"{(IsDivisibleBy(i, 2) ? "0" : "1")}{result}";

            return result;
        }
    }
}
