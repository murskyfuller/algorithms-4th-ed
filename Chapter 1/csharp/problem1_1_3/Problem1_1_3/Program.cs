using System;

namespace Problem1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var stdIn = new StdIn();
            bool loop;

            do
            {
                // Query.
                var solution = new Solution(stdIn);
                Console.WriteLine(solution.Execute());

                // Check if they want to continue.
                var goAgain = stdIn.Prompt("Would you like to check another set? [y/n]");
                if (goAgain.ToLower() == "y") loop = true;
                else loop = false;
            } while (loop == true);

            Environment.Exit(0);
        }
    }
}
