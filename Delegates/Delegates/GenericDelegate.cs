using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyGenericDelegate<T>(T arg);

    class GenericDelegate
    {
        public static void StringTarget(string arg)
        {
            Console.WriteLine($"StringTarget: {arg}");
        }

        public static void IntTarget(int arg)
        {
            Console.WriteLine($"IntTarget: {arg}");
        }
    }
}
