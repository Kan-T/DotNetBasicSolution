using System;
namespace D_Nullable
{
    class NullablesAtShow
    {
        public static void demo()
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            // 显示值
            Console.WriteLine("\n === D_Nullable ===");

            //用法与Java中基础类型的包装类型相似
            Console.WriteLine("显示可空类型的值： {0}, {1}, {2}, {3}",
                               num1, num2, num3, num4);
            Console.WriteLine("一个可空的布尔值： {0}", boolval);

            //用法与Javascript中 || 短路运算相似
            Console.WriteLine("num1??21： {0}", num1 ?? 21);
        }
    }
}