using System;

namespace O_Delegate
{
    class FuncDemo
    {
        public static string sayHello(string str)
        {
            return "hello " + str;
        }
        public static void printStr(string str)
        {
            Console.WriteLine("print " + str);
        }
        public static void acceptAction(Action<String> action, String str)
        {
            Console.WriteLine("In action: ");
            action(str);
        }

        public static void demo()
        {
            Console.WriteLine("\n === O_Delegate_Func ===");
            Func<string, string> say = sayHello;
            string str = say("abc");
            Console.WriteLine(str);     //输出abcabc

            Action<String> print = printStr;
            print("aaa");

            acceptAction(print, "def");
        }
    }
}