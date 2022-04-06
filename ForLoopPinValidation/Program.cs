using System;

namespace ForLoopPINValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter u PIN");
                string userPin = Console.ReadLine();
                if (userPin == "1234")
                {
                    Console.WriteLine("Welcome!");
                    break;//это разрывает блок - иначе будет зацикленная цепочка
                }
                else
                {
                    Console.WriteLine($"Login failed. U tried to log in {i + 1}/3");
                    if (i == 2)
                    {
                        Console.WriteLine("No attempts left. Try again later.");
                    }
                }


            }
        }
    }
}