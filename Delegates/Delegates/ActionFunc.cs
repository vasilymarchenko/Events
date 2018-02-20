using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class ActionFunc
    {
        public static void DoSmth(int i, string s)
        {
            Console.WriteLine($"i={i}, s={s}");
        }

        public static int Calc(int x, int y)
        {
            return x + y;
        }
    }
}
