using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int []arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-5, 20);
                Console.WriteLine(arr[i]);
            }
            int index = 0;
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    index = i;
                }
                
            }
            Console.WriteLine(index);
            int sum = 0;
            int arit_mean;
            for (int i = index; i < arr.Length; i++)
            {
                sum = sum + arr[i];

            }
            Console.WriteLine(sum);
            arit_mean = (int)(sum / arr.Length);
            Console.WriteLine(arit_mean);
        }
    }
}
