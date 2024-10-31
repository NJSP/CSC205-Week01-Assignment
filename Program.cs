using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1:");
            Console.WriteLine("  ^\n ^^^\n^^^^^");

            Console.WriteLine("\nQuestion 2:");
            Time t1 = new Time(10, 35, 59.0);
            t1.DisplayTime();
            t1.TimeSince();
            t1.TimeLeft();
            t1.TimePercent();

            Console.WriteLine("\nQuestion 3:");
            DigitMod d1 = new DigitMod(1234);
            Console.WriteLine(d1.GetSum());

            Console.WriteLine("\nQuestion 4:");
            Console.WriteLine("52,130: ushort \n-115: sbyte\n-44: sbyte\n4,825,932: int\n970.700,000: int\n-1,000,000: int\n97: byte\n224: byte\n112: byte\n-10,000: short\n20,000: short\n1,990: short\n123,456,789,123,456,789: long");

            Console.WriteLine("\nQuestion 5:");
            Console.WriteLine("C:\\Users\\njpetrone\\source\\repos\\Time");
        }

    }
}