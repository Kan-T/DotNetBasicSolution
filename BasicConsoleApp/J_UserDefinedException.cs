using System;
namespace J_UserDefinedException
{
    class TestTemperature
    {
        public static void demo()
        {
            Console.WriteLine("\n === J_UserDefinedException ===");

            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
                //throw e;
            }
            finally
            {
                Console.WriteLine("finally..");
            }
        }
    }
    public class TempIsZeroException : ApplicationException
    {
        public TempIsZeroException(string message) : base(message)
        {
        }
    }
    public class Temperature
    {
        int temperature = 0;
        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }
}