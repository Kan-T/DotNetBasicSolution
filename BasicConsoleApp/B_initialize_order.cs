using System;

namespace B_initialize_order
{
    public class A
    {
        public static readonly int x;
        static A()
        {
            //第二步，调用B.y，此处B.y = 0，因为int类型在初始化阶段，会给赋默认值，默认值为0。最后x = 0 + 1（返回给第一步）
            x = B.y + 1;
        }
    }

    public class B
    {
        //第一步，调用A.x，然后执行类A的静态构造函数，等待返回（第二步返回的A.x = 1，所有y = 1 + 1）
        public static int y = A.x + 1;
        public static void demo()
        {
            //第三步，A.x = 1，y = 2。
            Console.WriteLine("\n === B_initialize_order ===");
            Console.WriteLine("x:{0},y:{1}。", A.x, y);
        }
    }
}

//1、首先，每一个项目有且只能有一个静态类的main函数作为入口函数。而入口函数是最先执行的。
//2、由于main函数在b类里面，首先会初始化b类。而类的初始化顺序是：类里的静态变量，然后执行静态构造函数。
//3、运行起先执行 public static int y = a.x + 1 这个，执行的时候，会先把 y 初始化为0，然后计算 y 的值。
//4、计算 y 的值的时候，调用了 a 的静态变量 x 。所以会先初始化a。
//5、初始化a时首先去执行 public static readonly int x ，先把 x 初始化为0。
//6、然后执行a的静态构造函数 x = b.y + 1 此时 y 已经初始化为0了。
//7、计算得到 x = 1。然后回到 public static int y = a.x + 1 得到 y = 2。
//8、然后再执行main函数的内容。得出结果x=1，y=2

