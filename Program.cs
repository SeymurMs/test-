using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3};
            int number1 = 4; 
            task1( arr,  number1);
           foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            //int num = 25;
            //task3(ref num);
            //Console.WriteLine(num);

            //string str = "Sey mur sey mur";
            //task2(ref str);
            //Console.WriteLine(str);



        }
        static string task2(ref string str)
        {
            str = str.Replace(" ", String.Empty);
            return str;
        }
        static void task3(ref int number2)
        {
            int index = 0;
            while (index * index <= number2)
            {
                index++;
            }
            index = index - 1;
            number2 = index;
        }

        static void task1(  int[] arr,  int number)
        {
            int[] newArr = new int[arr.Length];
             
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i]=arr[i];
            }
            newArr=new int[number];
        }
    }
}
