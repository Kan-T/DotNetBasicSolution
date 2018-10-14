using System;
using System.IO;

namespace O_Delegate
{
    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;
        
        // 委托声明
        public delegate void DPrintString(string s);

        // 该方法打印到控制台
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }
        // 该方法打印到文件
        public static void WriteToFile(string s)
        {
            fs = new FileStream("./files/O_message.txt",
            FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        // 该方法把委托作为参数，并使用它调用方法
        // 函数可以以委托的方式，作为参数进行传递，从而实现函数式编程
        public static void sendString(DPrintString ps)
        {
            ps("Hello World");
        }
        public static void demo()
        {
            Console.WriteLine("\n === O_Delegate ===");

            DPrintString ps1 = new DPrintString(WriteToScreen);   // Delegate initialization
            DPrintString ps2 = new DPrintString(WriteToFile);     // Multicasting of a Delegate
            DPrintString ps = ps1 + ps2;
            sendString(ps);
        }
    }
}