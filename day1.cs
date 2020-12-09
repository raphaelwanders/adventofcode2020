using System;

namespace AdventOfCode_D1_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = System.IO.File.ReadAllLines(@"C:\Users\rapha\OneDrive\Persoonlijk\Bureaublad\Nova College\Advent of Code 2020\AdventOfCode-D1-2020\C#\AdventOfCode-D1-2020\numbers.txt");
            int[] numbers = Array.ConvertAll(input, a => int.Parse(a));
            int e = input.Length;

            Console.WriteLine("--<= Task 1 =>--");

            for (int i = 0; i < e; i++)
            {
                for (int x = i; x < e; x++)
                {
                    int s = numbers[i] + numbers[x];
                    
                    if (s == 2020)
                    {
                        int k = numbers[i] * numbers[x];
                        Console.WriteLine($"{numbers[i]} * {numbers[x]} = {k}");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("--<= Task 2 =>--");

            for (int j = 0; j < e; j++)
            {
                for (int h = j; h < e; h++)
                {
                    for (int g = h; g < e; g++)
                    {
                        int s = numbers[j] + numbers[h] + numbers[g];

                        if (s == 2020)
                        {
                            int k = numbers[j] * numbers[h] * numbers[g];
                            Console.WriteLine($"{numbers[j]} * {numbers[h]} * {numbers[g]} = {k}");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
