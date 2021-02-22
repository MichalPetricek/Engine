using System;

namespace Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            string numberStr = Console.ReadLine();
            int number;
            number = int.Parse(numberStr);
            int fornumber = (number * 10) / 4;
            int ifnumber = number * 10;
            string coil1 = "1000";
            string coil2 = "0100";
            string coil3 = "0010";
            string coil4 = "0001";
            for (int i = 0; i < fornumber; i++)
            {
                Console.Write("Coil1: ");
                Console.WriteLine(coil1);
                Console.Write("Coil2: ");
                Console.WriteLine(coil2);
                Console.Write("Coil3: ");
                Console.WriteLine(coil3);
                Console.Write("Coil4: ");
                Console.WriteLine(coil4);
            }
            if (ifnumber%4 != 0)
            {
                if (ifnumber % 4 == 1)
                {
                    Console.Write("Coil1: ");
                    Console.WriteLine(coil1);

                }
                if (ifnumber % 4 == 2)
                {
                    Console.Write("Coil1: ");
                    Console.WriteLine(coil1);
                    Console.Write("Coil2: ");
                    Console.WriteLine(coil2);

                }
                if (ifnumber % 4 == 3)
                {
                    Console.Write("Coil1: ");
                    Console.WriteLine(coil1);
                    Console.Write("Coil2: ");
                    Console.WriteLine(coil2);
                    Console.Write("Coil3: ");
                    Console.WriteLine(coil3);
                }
            }
        }
    }
}
