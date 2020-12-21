using System;

namespace Problem1_1_11
{
    public class Solution
    {
        private readonly IArrayToStringConverter _converter;

        public Solution(IArrayToStringConverter converter)
        {
            _converter = converter;
        }

        /// <summary>
        /// Prints the provided array as a grid in the console.
        /// </summary>
        /// <param name="arrayToConvert"></param>
        public void Execute(bool[][] arrayToConvert)
        {
            Console.Write(_converter.TwoDimenionsalArrayToString(arrayToConvert));
        }
    }
}
