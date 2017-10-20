using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Loop_Voorbeeldjes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int som = 0;
            string invoer = "";

            while (x>3)
            {
                x--;
                Console.WriteLine(x);
            }

            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(i);
            }


            
            for (int i = 0; i <= 100000000; i++)
            {
                som += i;
                Console.WriteLine(som);
                Thread.Sleep(100);
            }

            while (invoer == "Hallo")
            {
                Console.WriteLine("Hallo!");
                Console.ReadLine();

                Console.WriteLine(x);

            }

        }
    }
}
