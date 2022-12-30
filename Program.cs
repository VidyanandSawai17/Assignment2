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


               //Switch case using Arithmatic operation

                Console.WriteLine("1. Add");
                Console.WriteLine("2. Sub");
                Console.WriteLine("3. Mul");
                Console.WriteLine("4. Div");
                Console.WriteLine("5. Mod");
                Console.WriteLine("Select your option from 1- 5");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of A");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of B");
                int B = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Add =" + (A + B));
                        break;
                    case 2:
                        Console.WriteLine("Sub =" + (A - B));
                        break;
                    case 3:
                        Console.WriteLine("Mul =" + (A * B));
                        break;
                    case 4:
                        Console.WriteLine("Div =" + (A / B));
                        break;
                    case 5:
                        Console.WriteLine("Mod =" + (A % B));
                        break;
                    default:
                        Console.WriteLine("Wrong option select");
                        break;
                }





        }
    }
}
