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
            Program pr = new Program();
            List<int> array = new List<int>();

            pr.FillArray(array);

            Console.WriteLine("Исходный массив:");
            pr.PrintArray(array);
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
        List<int> DeleteDuplicate(List<int> arr)
        {
            return arr;
        }
    }
}
