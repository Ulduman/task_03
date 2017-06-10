using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void FindNOD()
        {
            int a = 10, b = 20, c = 1;
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
        }
    }
}
