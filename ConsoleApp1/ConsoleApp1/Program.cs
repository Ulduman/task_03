using NODFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x;
            string  str;
            Class1 nf = new Class1();
            int ans;

            Console.WriteLine("Введите числа через пробел");
            str = Console.ReadLine();
            x=str.Split(' ');

            int [] y = new int[x.Length];

            for (int i=0; i<x.Length; i++)
            {
                y[i] = int.Parse(x[i]);
            }
            ans=nf.FindNOD(y[0], y[1], y[2], y[3], y[4]);
            Console.Write("НОД ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(y[i] + " ");
            }
            Console.Write("чисел равно:" + ans);
            Console.ReadKey();
        }
    }
}
