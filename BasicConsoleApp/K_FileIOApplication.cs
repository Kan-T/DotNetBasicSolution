using System;
using System.IO;

namespace K_FileIOApplication
{
    class Test
    {
        public static void demo()
        {
            Console.WriteLine("\n === K_FileIOApplication ===");

            FileStream F = new FileStream("test.dat",
            FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;

            for (int i = 1; i <= 21; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
        }
    }
}