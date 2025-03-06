using System;

namespace HeroPerk
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Erro: É necessário fornecer uma string de perks.");
                return;
            }

            string input = args[0];
            Perks playerPerks = Perks.None;

            foreach (char c in input)
            {
                switch (c)
                {
                    case 'w':
                        playerPerks ^= Perks.WarpShift;
                        break;
                    case 'a':
                        playerPerks ^= Perks.Stealth;
                        break;
                    case 's':
                        playerPerks ^= Perks.AutoHeal;
                        break;
                    case 'd':
                        playerPerks ^= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("!Unknown perk!");
                        return;
                }
            }

            if (playerPerks == Perks.None)
            {
                Console.WriteLine("!No perks at all!");
                return;
            }

            Console.WriteLine(playerPerks);

            if (playerPerks.HasFlag(Perks.Stealth) && playerPerks.HasFlag(Perks.DoubleJump))
            {
                Console.WriteLine("!Silent jumper!");
            }

            if (!playerPerks.HasFlag(Perks.AutoHeal))
            {
                Console.WriteLine("!Not gonna make it!");
            }
        }
    }
}

