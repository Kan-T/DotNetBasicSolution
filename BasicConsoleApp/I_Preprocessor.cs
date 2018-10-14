#define DEBUG
#define VC_V10
using System;

namespace I_Preprocessor
{
    public class Class
    {
        public static void demo()
        {
            Console.WriteLine("\n === I_Preprocessor ===");

        #if (DEBUG && !VC_V10)
            Console.WriteLine("DEBUG is defined");
        #elif (!DEBUG && VC_V10)
            Console.WriteLine("VC_V10 is defined");
        #elif (DEBUG && VC_V10)
            Console.WriteLine("DEBUG and VC_V10 are defined");
        #else
            Console.WriteLine("DEBUG and VC_V10 are not defined");
        #endif
        }
    }
}