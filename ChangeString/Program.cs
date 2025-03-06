using System;

namespace ChangeString
{
    class Program
    {
        static void Main()
        {
            Console.Write("String: ");
            string input = Console.ReadLine() ?? "";

            Console.Write("Caráter: ");
            char? character = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Quebra de linha após entrada do caráter

            if (character.HasValue)
            {
                string result = input.Replace(character.Value, 'x');
                Console.WriteLine(result);
            }
        }
    }
}

