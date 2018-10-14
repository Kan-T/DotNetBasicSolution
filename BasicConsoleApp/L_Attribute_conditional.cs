#define DEBUG
using System;
using System.Diagnostics;

namespace L_Attribute
{
    public class Myclass
    {
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    public class Test
    {
        static void Function1()
        {
            Myclass.Message("In Function 1.");
            Function2();
        }
        static void Function2()
        {
            Myclass.Message("In Function 2.");
        }
        public static void demo()
        {
            Console.WriteLine("\n === L_Attribute ===");

            Myclass.Message("In Main Function.");
            Function1();
        }
    }
}