using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            //Accept the 3 subject marks &calculate the total &percentage. & print grade as below
            //> 75  – > A
            //50 - 75 → B
            //40 - 50 → C
            //< 40 Fail


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




            //accept a year from user & print whether it is leap year or not



            //accept 3 numbers from user & print greatest number from 3


            Console.WriteLine("Enter  a no ");
            int N = Convert.ToInt32(Console.ReadLine());

            if(N >= 3)
            {
                Console.WriteLine("Grear");
            }
            else
            {
                Console.WriteLine("Small");
            }

            //accept actual value & sell value of a product &print profit or loss



            //write a program to accept a number &print day(e.g. 0 - sunday 1 - monday, 2 - tue…)

            Console.WriteLine("Enter a No ");
            int A = Convert.ToInt32(Console.ReadLine());

            if (A == 0)
            {
                Console.WriteLine("Sunday");

            }
            else if (A == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (A == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (A == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (A == 4)
            {
                Console.WriteLine("Thruday");
            }
            else if (A == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (A == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (A == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("invalid input");
            }

        }
    }
}
