using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.MathLogics
{
    internal class factorial
    {
        public static int Calculate(int n)
        {
            int res = 1;
            for (int i = 0; i < n; i++)
            { 
            res *= i;
            }
            return res;
        }

    }
}
