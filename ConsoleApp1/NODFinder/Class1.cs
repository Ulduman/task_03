using System;

namespace NODFinder
{
    public class Class1
    {
        public int FindNOD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a >= b) a = a % b;
                else b = b % a;
            }
            return a + b;

        }
        public int FindNOD(int a, int b, int c)
        {
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
            return a + c;
        }
        public int FindNOD(params int[] a)
        {

            for (int i = 1; i < a.Length; i++)
            {
                while (a[0] != 0 && a[i] != 0)
                {
                    if (a[0] >= a[i]) a[0] = a[0] % a[i];
                    else a[i] = a[i] % a[0];
                }
                a[0] = a[0] + a[i];
            }
            return a[0];
        }
    }
}
