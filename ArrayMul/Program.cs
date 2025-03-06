using System;

namespace ArrayMul
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 6)
            {
                Console.WriteLine("Erro: são necessários exatamente 6 argumentos.");
                return;
            }

            float[,] A = new float[2, 2];
            float[] b = new float[2];
            float[] result = new float[2];

            for (int i = 0; i < 4; i++)
            {
                A[i / 2, i % 2] = float.Parse(args[i]);
            }
            for (int i = 0; i < 2; i++)
            {
                b[i] = float.Parse(args[i + 4]);
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i] += A[i, j] * b[j];
                }
            }

            foreach (float value in result)
            {
                Console.WriteLine($"| {value,7:F2} |");
            }
        }
    }
}

