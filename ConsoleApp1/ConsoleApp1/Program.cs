using NODFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x;
            string  str, ans, ans2;
            Class1 nf = new Class1();
            int a;
            int[] y;
            do
            {
                Console.WriteLine("Введите числа через пробел и не менее двух");
                str = Console.ReadLine();
                x = str.Split(' ');
            } while (x.Length < 2);
            y = new int[x.Length+1];
            for (int i=0; i<x.Length; i++)
            {
                if (x.Length > i)
                {
                    y[i] = int.Parse(x[i]);
                }
                else y[i] = 0;
            }
            while (true)
            {
                Console.WriteLine("Требуется ли подсчет времени выполнения расчетов(Да/Нет)");

                string rasch = Console.ReadLine();

                if (rasch == "Да")
                {
                    a = 1;
                    y[x.Length] = a;
                    break;
                }
                else if (rasch =="Нет")
                {
                    a = 0;
                    y[x.Length] = a;
                    break;
                }
            }
                switch (x.Length)
            {
                case 2:
                    ans = nf.FindNOD(y[0], y[1], a);
                    ans2 = nf.FindNOD2(y);
                    break;
                case 3:
                    ans = nf.FindNOD(y[0], y[1], y[2], a);
                    ans2 = nf.FindNOD2(y);
                    break;
                default:
                    ans = nf.FindNOD(y);
                    ans2 = nf.FindNOD2(y);
                    break;
            }
            Console.Write("НОД ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(y[i] + " ");
            }
            Console.Write("чисел:\nпо методу Евклида равно " + ans+"\nпо методу Стейна равно "+ans2);
            Console.Read();
        }
    }
}
