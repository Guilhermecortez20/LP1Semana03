using System;

namespace TrapAnalyzer
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            TrapType trap = Enum.Parse<TrapType>(args[0]);
            PlayerGear gear = ParseGear(args);
            bool survives = CanSurviveTrap(trap, gear);
            DisplayResult(trap, survives);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the player gear.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The player gear.</returns>
        private static PlayerGear ParseGear(string[] args)
        {
            PlayerGear gearParsed = new PlayerGear();

            for (int i = 0; i < args.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    gearParsed ^= Enum.Parse<PlayerGear>(args[i]);
                }
            }

            return gearParsed;
        }

        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trap">The trap the player falls into.</param>
        /// <param name="gear">The gear the player has.</param>
        /// <returns>Wether the player survived the trap or not.</returns>
        private static bool CanSurviveTrap(TrapType trap, PlayerGear gear)
        {
            bool canSurvive = false;

            switch (trap)
            {
                case TrapType.FallingRocks:

                    if ((gear & PlayerGear.Helmet) == PlayerGear.Helmet)
                    {
                        canSurvive = true;
                    }
                    break;

                case TrapType.SpinningBlades:

                    if ((gear & PlayerGear.Shield) == PlayerGear.Shield)
                    {
                        canSurvive = true;
                    }
                    break;

                case TrapType.PoisonGas:

                    if ((gear & PlayerGear.Helmet) == PlayerGear.Helmet ||
                        (gear & PlayerGear.Shield) == PlayerGear.Shield)
                    {
                        canSurvive = true;
                    }
                    break;

                case TrapType.LavaPit:

                    if ((gear & PlayerGear.Boots) == PlayerGear.Boots)
                    {
                        canSurvive = true;
                    }
                    break;
            }

            return canSurvive;

        }

        /// <summary>
        /// Display information on wether the player survived the trap or not.
        /// </summary>
        /// <param name="trap">The trap the player has fallen into.</param>
        private static void DisplayResult(TrapType trap, bool survives)
        {
            if (survives)
            {
                Console.WriteLine($"Player survives {trap.ToString()}");
            }
            else
            {
                Console.WriteLine($"Player dies due to {trap.ToString()}");
            }

        }
    }
}