using System;
namespace E_ArrayApplication
{
    class MyArray
    {

        public static void demo(params int[] args)      // 参数数组
        {
            int[] list = args;

            Console.WriteLine("\n === E_ArrayApplication ===");
            Console.Write("原始数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 逆转数组
            Array.Reverse(list);                        // Array Functions
            Console.Write("逆转数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 排序数组
            Array.Sort(list);
            Console.Write("排序数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}