using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) //i++ = i+1 - шаг    если i-- > i-1
            {
                Console.WriteLine("wazuuuuup"); //($"{i}wazuuup") то перед словом будет стоять порядковый номер начиная с 0
            }
            Console.WriteLine(); // это позволяет сделать пустую строку между (отступ)

            for (int i = 0; i < 10; i++) //с 0 до 10
            {
                Console.WriteLine(i + 1); //если тут оставим i - будет 0-9, если ставим i+1 - будет 1-10
            }
            Console.WriteLine();

            for (int i = 10; i > 0; i--) //с 10 до 0
            {
                Console.WriteLine(i);
            }

        }
    }
}