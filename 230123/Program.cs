using System;
using System.Drawing;

namespace _230123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number4 = 23;
            //Addten(ref number4);
            //Console.WriteLine(number4);

            //int number5 = 140;
            //noname(ref number5);
            //Console.WriteLine(number5);


            int num1 = 5;
            int[] numbers5 = new int[] { 34, 23, -12, 33, -23, -4, 5 };
            newerrey(ref numbers5, num1);
            for (int i = 0; i < numbers5.Length; i++)
            {
                Console.WriteLine(numbers5[i]);
            }


            //var  numbers = new int[] { 34, 23, -12, 33, -23, -4, 5 };

            //MakeEven(ref numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
        }
        static void Addten(ref int num)
        {
            num = num + 10;

        }

        static void noname(ref int num)
        {
            if (num < 0)
            {
                num = 0;
            }
            else if (num > 100)
            {
                num = 100;
            }
        }
        static void MakeEven(ref int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    count++;
            }
            int[] arrNew = new int[count];

            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrNew[j] = arr[i];
                    j++;
                }
            }

            arr = arrNew;
        }
        static void newerrey(ref int[] nums12,int num2)
        {
            int[] numbrr = new int[nums12.Length + 1];
            int j = 0;
            for (int i = 0; i < nums12.Length; i++)
            {
                numbrr[j] = nums12[i];
                j++;
            }
            numbrr[numbrr.Length - 1] = num2;
            nums12 = numbrr;
        }







    }
}
