//Копіювання масиву, додавання елементу в масив додавання деклькох елементів масиву, дії з масивами

using System;

namespace test_app
{
    internal class Program
    {
        static int[] CombineArrays(int[] a, int[] b)
        {
            int newLength = a.Length + b.Length;
            int[] newArr = new int[newLength];

            Array.Copy(a, newArr, a.Length);
            Array.Copy(b, 0, newArr, a.Length, b.Length);

            return newArr;
        }

        static int[] ad_cell_toARR(int[] a)
        {
            int arr_size = a.Length;
            arr_size++;

            int[] newARR = new int[arr_size];

            for (int i = 0; i < arr_size - 1; i++)
            {
                newARR[i] = a[i];
            }

            newARR[arr_size - 1] = 1;

            return newARR;
        }
        
        static void print_arr(int[] a)
        {
            int arr_size = a.Length;
            for (int i = 0; i < arr_size; i++)
            {
                Console.WriteLine("елемент масиву №" + i + " " + a[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 6, 7, 8, 9, 10 };

            int[] new_arr = CombineArrays(arr1, arr2);

            print_arr(new_arr);

        }
    }
}



//static int[] adds_arays(int[] a, int[] b)
//{

//    var newLengs = a.Length + b.Length;


//    int[] new_arr = new int[newLengs];

//    for (int i = 0; i < a.Length; i++)
//    {
//        new_arr[i]= a[i];
//    }
//    for (int i = a.Length; i < newLengs; i++)
//    {
//        new_arr[i] = b[i];
//    }

//    return new_arr;
//}