using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math = ");
            int Math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Che = ");
            int Che = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Phy = ");
            int Phy = Convert.ToInt32(Console.ReadLine());

            if (Math >= 75)
            {
                Console.WriteLine("A");
            }
            else if (Math >= 60)
            {
                Console.WriteLine("B");
            }
            else if (Math >= 50)
            {
                Console.WriteLine("C");
            }
            else if (Math < 40)
            {
                Console.WriteLine("Fail");
            }

            if (Che >= 75)
            {
                Console.WriteLine("A");
            }
            else if (Che >= 60)
            {
                Console.WriteLine("B");
            }
            else if (Che >= 50)
            {
                Console.WriteLine("C");
            }
            else if (Che < 40)
            {
                Console.WriteLine("Fail");
            }


            if (Phy >= 75)
            {
                Console.WriteLine("A");
            }
            else if (Phy >= 60)
            {
                Console.WriteLine("B");
            }
            else if (Phy >= 50)
            {
                Console.WriteLine("C");
            }
            else if (Phy < 40)
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
