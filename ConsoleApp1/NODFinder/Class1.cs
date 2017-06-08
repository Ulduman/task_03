using System;
using System.Diagnostics;

namespace NODFinder
{
    public class Class1
    {
        public string FindNOD(int a, int b, int c)
        {
            Stopwatch sw = new Stopwatch();
            TimeSpan ts = new TimeSpan();

            sw.Start();
            while (a != 0 && b != 0)
                {
                    if (a >= b) a = a % b;
                    else b = b % a;
                }
            sw.Stop();
            ts = sw.Elapsed;
            if (c > 0)
            {
                return a + b + " время затраченое на выполнение метода: " + ts.TotalMilliseconds + "миллисекунд";
            }else return a + b +"";
        }
        public string FindNOD(int a, int b, int c, int d)
        {
            Stopwatch sw = new Stopwatch();
            TimeSpan ts = new TimeSpan();

            sw.Start();
            while (a != 0 && b != 0)
            {
                if (a >= b) a = a % b;
                else b = b % a;
            }
            a = a + b;
            while (a != 0 && c != 0)
            {
                if (a >= c) a = a % c;
                else c = c % a;
            }
            sw.Stop();
            ts = sw.Elapsed;
            if (d > 0)
            {
                return a + c + " время затраченое на выполнение метода: " + ts.TotalMilliseconds + " миллисекунд";
            }
            else return a + c + "";
        }
        public string FindNOD(params int[] d)
        {
            int[] a = (int[])d.Clone();
            Stopwatch sw = new Stopwatch();
            TimeSpan ts = new TimeSpan();

            sw.Start();
            for (int i = 1; i < a.Length; i++)
            {
                while (a[0] != 0 && a[i] != 0)
                {
                    if (a[0] >= a[i]) a[0] = a[0] % a[i];
                    else a[i] = a[i] % a[0];
                }
                a[0] = a[0] + a[i];
            }
            sw.Stop();
            ts = sw.Elapsed;
            if (d[d.Length-1] > 0)
            {
                return a[0] + " время затраченое на выполнение метода: " + ts.TotalMilliseconds + " миллисекунд";
            }
            else return a[0] +  "";
        }
        public string FindNOD2(params int[] d)
        {
            int[] a = (int[])d.Clone();
            int b = 1;
            Stopwatch sw = new Stopwatch();
            TimeSpan ts = new TimeSpan();

            sw.Start();
            for (int i = 1; i < a.Length; i++)
            {
                while (a[0] != 0 && a[i] != 0)
                {
                    if (a[0] >= a[i]) a[0] = a[0] % a[i];
                    else a[i] = a[i] % a[0];
                }
                a[0] = a[0] + a[i];
            }
            sw.Stop();
            ts = sw.Elapsed;
            if (d[d.Length - 1] > 0)
            {
                return a[0] + " время затраченое на выполнение метода: " + ts.TotalMilliseconds + " миллисекунд";
            }
            else return a[0] + "";
        }
    }
}
