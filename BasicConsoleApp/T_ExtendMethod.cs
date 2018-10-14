using System;

namespace T_ExtendMethod
{
    static class ExtendMethod
    {
        // 1. 必须把扩展方法定义在静态类中，每个扩展方法也必须声明为静态的
        // 2. 扩展方法的第一个参数是要扩展的类型，必须要使用this关键字对第一个参数进行修饰
        public static void Fun(this string s)
        {
            // Console.WriteLine("this: " + this);          // Not allowed to use this here.
            Console.WriteLine(s);
        }
        public static int StringIndef(this string str, char tmpChar)
        {
            int index = 0;
            for (; index < str.Length; index++)
            {
                if (str[index].Equals(tmpChar))
                {
                    return index;
                }
            }
            return -1;
        }
    }

    class Demo
    {
        #region 1  
        public static void demo()
        {
            Console.WriteLine("\n === T_ExtendMethod ===");
            string s = "okokok";
            s.Fun();
            ExtendMethod.Fun(s);                // 扩展方法实质
            Console.WriteLine("\n s.StringIndef('k'):" + s.StringIndef('k'));
        }
        #endregion
    }
}