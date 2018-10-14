using System;

namespace L_Attribute {
    public class MyClassObsolete
    {
        [Obsolete("Don't use OldMethod, use NewMethod instead", false)]
        static void oldMethod()
        {
            Console.WriteLine("It is the old method");
        }
        static void newMethod()
        {
            Console.WriteLine("It is the new method");
        }
        public static void demo()
        {
            //oldMethod();
            newMethod();
        }
    }
}