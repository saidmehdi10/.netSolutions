using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld
{
    public static class Math
    {
        public static int Factorielle(int a)
        {
            if (a <= 1)
                return 1;
            return a * Factorielle(a - 1);
        }

        public static int Addition(int a, int b)

        {
            return a + b;
        }
    }
}