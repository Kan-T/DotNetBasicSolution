using System;

namespace C_Function_parms
{
    class NumberManipulator2
    {
        private void swapSquare(Square x, Square y)
        {
            Square temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        public void swapSquare(ref Square x, ref Square y)
        {
            Square temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        public static void demo()
        {
            NumberManipulator2 n = new NumberManipulator2();
            /* 局部变量定义 */
            Square s1 = new Square();
            s1.edge = 1;
            Square s2 = new Square();
            s2.edge = 2;

            Console.WriteLine("\n === C_Function_parms2 ===");
            Console.WriteLine("在交换之前，s1.edge 的值： {0}", s1.edge);
            Console.WriteLine("在交换之前，s2.edge 的值： {0}", s2.edge);

            /* 调用函数来交换值 */
            n.swapSquare(s1, s2);

            Console.WriteLine("在交换之后，s1.edge 的值： {0}", s1.edge);
            Console.WriteLine("在交换之后，s2.edge 的值： {0}", s2.edge);

            /* 调用函数来交换值 */
            n.swapSquare(ref s1, ref s2);

            Console.WriteLine("在swap Ref后，s1.edge 的值： {0}", s1.edge);
            Console.WriteLine("在swap Ref后，s2.edge 的值： {0}", s2.edge);
        }
    }

    class Square
    {
        public int edge;
    }
}
