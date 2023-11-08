using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Array_continuation_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            List<int> array = new List<int>();

            pr.FillArray(array);

            Console.WriteLine("Исходный массив:");
            pr.PrintArray(array);
            
            Console.Write("Введите число для поиска: ");
            int num = Int32.Parse(Console.ReadLine());

            Task task1 = new Task(() => 
            {
                Console.WriteLine("Удалены дубликаты:");
                pr.DeleteDuplicate(ref array);
                pr.PrintArray(array);
            });

            Task task2 = task1.ContinueWith(o =>
            {
                Console.WriteLine("Отсортированный массив:");
                pr.SortArray(array);
                pr.PrintArray(array);
            });

            Task<int> task3 = task2.ContinueWith(o => pr.BinarySearchArray(array, num));

            task1.Start();

            int index = task3.Result;

            if (index >= 0)
            {
                Console.WriteLine($"Число найдено под индексом: {index}");
            }
            else
            {
                Console.WriteLine("Число не найдено");
            }
        }
        void FillArray(List<int> arr)
        {
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                arr.Add(rnd.Next(1, 20));
            }
        }
        void PrintArray(List<int> arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
        void DeleteDuplicate(ref List<int> arr)
        {
            var nums = arr.Distinct();

            List<int> newArr = new List<int>();

            newArr.AddRange(nums);
            arr = newArr;
        }
        void SortArray(List<int> arr)
        {
            arr.Sort();
        }
        int BinarySearchArray(List<int> arr, int num)
        {
            return arr.BinarySearch(num);
        }
    }
}
