using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                if (arg.Length >= 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    return;
                }

                if (arg.Length > 3)
                {
                    Console.WriteLine(arg);
                }
            }
        }
    }
}
