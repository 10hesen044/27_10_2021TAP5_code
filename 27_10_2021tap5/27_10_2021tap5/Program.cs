using System;

namespace _27_10_2021tap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, -5, -7, 2, -1 };
            ChangeNegative(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        static void ChangeNegative(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }

            }

        }
    }
}
