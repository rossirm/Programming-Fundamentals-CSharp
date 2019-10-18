using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string message = "";
            bool willFit = false;

            try
            {
                sbyte num = sbyte.Parse(n);
                message += "* sbyte\r\n";
                willFit = true;
            }
            catch{}
            try
            {
                byte num = byte.Parse(n);
                message += "* byte\r\n";
                willFit = true;
            }
            catch { }
            try
            {
                short num = short.Parse(n);
                message += "* short\r\n";
                willFit = true;
            }
            catch { }
            try
            {
                ushort num = ushort.Parse(n);
                message += "* ushort\r\n";
                willFit = true;
            }
            catch { }
            try
            {
                int num = int.Parse(n);
                message += "* int\r\n";
                willFit = true;
            }
            catch { }
            try
            {
                uint num = uint.Parse(n);
                message += "* uint\r\n";
                willFit = true;
            }
            catch { }
            try
            {
                long num = long.Parse(n);
                message += "* long\r\n";
                willFit = true;
            }
            catch { }
            
            if (willFit)
            {
                Console.WriteLine($"{n} can fit in:");
                Console.WriteLine(message);                
            } else
            {
                Console.WriteLine($"{n} can't fit in any type");

            }
        }
    }
}
