using System;

namespace C_Function_parms
{
    class NumberManipulator
    {
        private void swap(int x, int y)
        {
            int temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        public void swap(ref int x, ref int y)
        {
            int temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        private void swapStr(String x, String y)
        {
            String temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        public void swapStr(ref String x, ref String y)
        {
            String temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        public static void demo()
        {
            NumberManipulator n = new NumberManipulator();
            /* 局部变量定义 */
            int a = 100;
            int b = 200;

            Console.WriteLine("\n === C_Function_parms ===");
            Console.WriteLine("在交换之前，a 的值： {0}", a);
            Console.WriteLine("在交换之前，b 的值： {0}", b);

            /* 调用函数来交换值 */
            n.swap(a, b);

            Console.WriteLine("在交换之后，a 的值： {0}", a);
            Console.WriteLine("在交换之后，b 的值： {0}", b);

            /* 调用函数来交换值 */
            n.swap(ref a, ref b);

            Console.WriteLine("在swapRef后，a 的值： {0}", a);
            Console.WriteLine("在swapRef后，b 的值： {0}", b);

            /* ================================================================================ */
            /* 局部变量定义 */
            String s1 = "hello 1";
            String s2 = "world 2";

            Console.WriteLine("\n === C_Function_parms ===");
            Console.WriteLine("在交换之前，s1 的值： {0}", s1);
            Console.WriteLine("在交换之前，s2 的值： {0}", s2);

            /* 调用函数来交换值 */
            n.swapStr(s1, s2);

            Console.WriteLine("在交换之后，s1 的值： {0}", s1);
            Console.WriteLine("在交换之后，s2 的值： {0}", s2);

            /* 调用函数来交换值 */
            n.swapStr(ref s1, ref s2);

            Console.WriteLine("在swapRef后，s1 的值： {0}", s1);
            Console.WriteLine("在swapRef后，s2 的值： {0}", s2);
        }
    }
}
