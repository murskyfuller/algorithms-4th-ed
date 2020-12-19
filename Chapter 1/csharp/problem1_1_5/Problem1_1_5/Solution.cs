using System.Linq;

namespace Problem1_1_5
{
    public class Solution
    {
        /// <summary>
        /// Determines whether all the provided values are strictly between 0 and 1.
        /// </summary>
        /// <param name="args">The values to check.</param>
        /// <returns>True if all the provided values are strictly between 0 and 1, otherwise false.</returns>
        public bool Execute(params double[] args)
        {
            return args.All(v => v > 0 && v < 1);
        }
    }
}
