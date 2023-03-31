using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of dices you wish to have: ");
            int n = int.Parse(Console.ReadLine());

            Random random = new Random();

            Console.WriteLine($"Rolling {n} dices: ");
            for (int i = 0; i < n; i++)
            {
                int result = random.Next(1, 7);
                Console.Write(result + "");
            }
            Console.WriteLine();
        }
    }
}
