using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int BinOp(int x, int y);
    class SimpleDelegate
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Substract(int x, int y)
        {
            return x - y;
        }

        public int Multi(int x, int y)
        {
            return x * y;
        }
    }
}
