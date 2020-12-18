using System;

namespace Problem1_1_3
{
    public class StdIn : IStdIn
    {
        public string Prompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
