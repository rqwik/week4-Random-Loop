using System;

namespace CalculateSummInLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sum = 0; //к этому числу будут суммироваться все рандомные числа
            Console.WriteLine("My random numbers:");
            for (int i = 0; i < 10; i++)
            {
                int myRandom = rnd.Next(1, 11);
                sum += myRandom;
                Console.WriteLine($"{myRandom}");
            }
            Console.WriteLine($"Total: {sum}");
        }
    }
}