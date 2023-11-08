using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_continuation_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            FillArray(array);

            Console.WriteLine("Исходный массив:");
            PrintArray(array);
        }
        static void FillArray(int[] arr)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 20);
            }
        }
        static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
