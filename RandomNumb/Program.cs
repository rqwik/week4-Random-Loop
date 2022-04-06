using System;

namespace RandomNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 5; i++) //покажем 5 рандомных чисел
            {
                int myRandom = rnd.Next(1, 11); //последняя цифра всегда +1 (у нас 1-10)
                Console.WriteLine($"My random number:{myRandom}");
            }
            Console.WriteLine();

            //если мы хотим видеть наше последнее рандомное число, то мы выносим переменную из блока

            //Random rnd = new Random();
            //int myRandom = 0; //не важно чему будет равен
            //for(int i = 0; i < 5; i++) //покажем 5 рандомных чисел
            //{
            //myRandom = rnd.Next(1, 11);
            //Console.WriteLine($"My random number:{myRandom}");
            //}
            //Console.WriteLine(myRandom);
        }
    }
}