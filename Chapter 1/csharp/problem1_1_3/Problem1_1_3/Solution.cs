using System;

namespace Problem1_1_3
{
    public class Solution
    {
        private IStdIn _stdIn;

        public Solution(IStdIn stdIn)
        {
            _stdIn = stdIn;
        }

        public bool AreEqual(params int[] args)
        {
            var result = true;

            for (int i = 1, n = args.Length; i < n; i++)
            {
                if (args[i] != args[i - 1])
                {
                    // If any value is different from the previous,
                    // not all are equal.
                    result = false;
                    break;
                }
            }

            return result;
        }

        public string Execute()
        {
            // Prompt for input.
            var input = _stdIn.Prompt("Enter three integers to test separated by a comma (e.g. '1,2,3'):");
            Console.WriteLine($"input: {input}");

            // Cast to integers.
            var inputSplits = input.Split(',');
            var numbers = new int[inputSplits.Length];
            for (int i = 0, n = inputSplits.Length; i < n; i++)
            {
                int num;
                var s = inputSplits[i];
                while (!int.TryParse(s, out num))
                {
                    // Prompt for replacement if invalid string.
                    s = _stdIn.Prompt($"{s} is an invalid integer. Please enter a replacement:");
                }

                numbers[i] = num;
            }

            // Return result.
            if (AreEqual(numbers)) return "equal";
            else return "not equal";
        }
    }
}
