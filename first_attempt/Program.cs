using System;

namespace first_attempt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = create_arr_pow_func(2, 10);
            arr_output(arr);
            min_max_arr_swap(arr);
            arr_output(arr);
            Console.Write(arr_mean(arr).ToString());
        }
        static int[] create_arr_pow_func(int base_of_pow, int size)
        {
            int[] a = new int[size];
            a[0] = 1;
            if (size == 1) return a;
            for (int i = 1; i < size; i++)
                a[i] = a[i-1] * base_of_pow;
            return a;
        }
        static void arr_output(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i].ToString());
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        static void min_max_arr_swap(int[] a)
        {
            int min_index = 0;
            int max_index = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[min_index]) min_index = i;
                if (a[i] > a[max_index]) max_index = i;
            }
            int a_temp = a[min_index];
            a[min_index] = a[max_index];
            a[max_index] = a_temp;
        }
        static double arr_mean(int[] a)
        {
            double mean = 0;
            for (int i = 0; i < a.Length; i++)
            {
                mean += a[i];
            }
            mean = mean / a.Length;
            return mean;
        }
    }
}
