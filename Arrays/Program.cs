using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, заполните массив из 5 чисел: ");
            int InputData;
            int[] NumberArray = new int[5];

            for (int i = 0; i < NumberArray.Length; i++)
            {
                InputData = int.Parse(Console.ReadLine());
                NumberArray[i] = InputData;
            }

            Console.WriteLine("Вывод массива в обратном порядке: ");

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(NumberArray[i]);
            }

            Console.WriteLine("Сумма чётных чисел в массиве: ");
            int Counter = 0;
            for (int i = 0; i < NumberArray.Length; i++)
            {
                if (NumberArray[i] % 2 == 0)
                {
                    Counter = Counter + NumberArray[i];
                }
            }

            Console.WriteLine(Counter);

            Console.WriteLine("Наименьшее число массива: ");
            int MinimalNumber = NumberArray[0];

            for (int i = 0; i < NumberArray.Length; i++)
            {
                if (NumberArray[i] <= MinimalNumber)
                {
                    MinimalNumber = NumberArray[i];
                }
            }

            Console.WriteLine(MinimalNumber);
        }
    }
}
