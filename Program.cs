using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BynaryConsoleAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass.SomeMethod1();
            SomeClass.SomeMethod2();
            SomeClass.NewMethod();
        }
    }

    class SomeClass
    {
        public static string SomeMethod1()
        {
            return "Method 1";
        }

        public static string SomeMethod2()
        {
            return "Method 2";
        }

        public static string NewMethod()
        {
            return "NewMethod";
        }
    }
}
