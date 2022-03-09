using System;

namespace array
{
    class Program
    {

        static void Main(string[] args)
        {
            #region //ARRAY
            int[] arr = { 41, 25, 26, 48 };
            Min(arr);
            Console.WriteLine(Min(arr));
        }
        static int Min(int[] arr)
        {
            int Min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }
            }
            return Min;
            #endregion


        }
        #region EDEDIN reqemlerinin sayi


        static void Main(string[] args)
        {
            int num = 556;
            int count = 0;
            Console.WriteLine(count);


        }


        private static int NumLength(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;

            }
            return count;

        }


    }
 }
