using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1)
            //*****
            // ****
            //  ***
            //   **
            //    *

            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int k = 1; k < i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j = i; j <= 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //2) Print pattern 
            //1
            //12
            //123
            //1234
            //12345
            //1234
            //123
            //12
            //1

            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            //for(int i = 4; i >= 1; i--)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //3) Print pattern 
            //1
            //121
            //12321
            //1234321
            //123454321
            //1234321
            //12321
            //121
            //1


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    for(int k = i-1; k >=1; k--)
            //    {
            //        Console.Write(k);
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    for (int k = i-1; k >= 1; k--)
            //    {
            //        Console.Write(k);
            //    }
            //    Console.WriteLine();
            //}



            //4)
            //      1
            //     1 2
            //    1 2 3
            //   1 2 3 4
            //  1 2 3 4 5
            // 1 2 3 4 5 6
            //1 2 3 4 5 6 7

            //for(int i = 1; i <= 7; i++)
            //{
            //    for(int k = 7; k >= i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j+" ");
            //    }
            //    Console.WriteLine();
            //}



            // 5)
            //      1
            //     2 2
            //    3 3 3
            //   4 4 4 4
            //  5 5 5 5 5
            // 6 6 6 6 6 6
            //7 7 7 7 7 7 7


            //for(int i = 1; i <= 7; i++)
            //{
            //    for(int k = 7; k >= i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i+" ");
            //    }
            //    Console.WriteLine();


            //}



            //6.WAP to print following Pattern
            //*
            //**
            //***
            //****
            //*****
            //*****
            //****
            //***
            //**
            //*.

            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //7) WAP to print following Pattern
            //    *
            //   **
            //  ***
            // ****
            //*****
            // ****
            //  ***
            //   **
            //    *

            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int k = 4; k >= i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= 4; i++)
            //{
            //    for(int k = 1; k <=i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 4; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //8)     WAP to print following Pattern
            //        1 0 1 0 1
            //        0 1 0 1 0
            //        1 0 1 0 1
            //        0 1 0 1 0
            //        1 0 1 0 1


            //for(int i = 1; i <= 5; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("0 1 0 1 0");
            //    }
            //    else
            //    {
            //        Console.WriteLine("1 0 1 0 1");
            //    }
            //}


            //9)      ab
            //      ababab
            //    ababababab

            //for(int i = 1; i <= 5; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        for (int k = 4; k >= i; k--)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write("ab");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //Try out all the star pattern using number and alphabets also

            //10.
            //    Generate your own function to satisfy the relationship between the inputs and outputs.
            //    Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
            //    Examples
            //    832 ➞ 594
            //    51 ➞ 36

            //Console.WriteLine("Enter number");
            //int num = Convert.ToInt32(Console.ReadLine());


              



















        }
    }
}
