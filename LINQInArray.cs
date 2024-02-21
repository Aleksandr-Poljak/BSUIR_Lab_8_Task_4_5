using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR_Lab_8_Task_4_5
{
    public class LINQInArray
    {
        public Random Random = new Random();
        public int start;
        public int end;
        public LINQInArray() { }
        public LINQInArray(int start, int end) : this() { this.start = start; this.end = end; }

        public void StartTask()
        {
            // Заолнение и вывод массива.
            int[] numbers = new int[30];
            int lineCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Random.Next(start, end);
                Console.Write(numbers[i] + " ");

                lineCount++;
                if (lineCount == 10)
                {
                    Console.WriteLine();
                    lineCount = 0;
                }
            }
            Console.WriteLine();

            // Запрос с использованием LINQ
            var result = from n in numbers
                         where n < 0
                         select  n;
            Console.WriteLine($"Mаксимум среди всех отрицательных чисел, Запрос с использованием LINQ: {result.Min()}");

            // Метод расширения (лямбда-выражение)
            var result2 = numbers.Where(x => x <0 ).Min();
            Console.WriteLine($"Mаксимум среди всех отрицательных чисел, метод расширения (лямбда-выражение): {result2}");
                         
        }

    }
}
