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
            int[] y = new int[5];

            Console.WriteLine("Введите числа через пробел");
            str = Console.ReadLine();
            x=str.Split(' ');
            for (int i=0; i<5; i++)
            {
                if (x.Length > i)
                {
                    y[i] = int.Parse(x[i]);
                }
                else y[i] = 0;
            }
            ans=nf.FindNOD(y[0], y[1], y[2], y[3], y[4]);
            Console.Write("НОД ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(y[i] + " ");
            }
            Console.Write("чисел равно:" + ans);
            Console.Read();
        }
    }
}
