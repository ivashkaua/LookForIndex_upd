using System;

namespace LookForIndex_upd
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите количество элементов массива: \t");
                int ArrNumber = int.Parse(Console.ReadLine());
                int[] array = new int[ArrNumber];

                for (int l = 0; l < ArrNumber; l++)
                {
                    Console.Write($"\nВведите число с индексом {l} \t");
                    array[l] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                Console.Write("Введите число для определения индекса: \t");
                int value = int.Parse(Console.ReadLine());
                int result = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        result = i;
                    }
                }
                Console.WriteLine("\nИндекс числа в массиве: " + result);
                Console.ReadLine();
            }
        }
    }
}
