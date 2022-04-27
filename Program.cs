using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentT._1
{
    internal class Program
    {
            static void Main(string[] args)
            {// ****************equal or not 
                Console.WriteLine("Enter 1st num");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd num");
                int n2 = Convert.ToInt32(Console.ReadLine());
                if (n1 == n2)
                {
                    Console.WriteLine(n1 + " and " + n2 + " are equal");
                }
                else if (n1 != n2)
                {
                    Console.WriteLine(n1 + " and " + n2 + " are not equal");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }




                //***************positive or negative

                Console.WriteLine("Enter number");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n >= 0)
                {
                    Console.WriteLine(n + " is positive number");
                }
                else if (n < 0)
                {
                    Console.WriteLine(n + " is negative number");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }






                //******************operations
                Console.WriteLine("1st num");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2nd num");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter operator");
                int z = Convert.ToChar(Console.ReadLine());

                if (z == '+')
                {
                    Console.WriteLine("{0}+{1}={2}", x, y, x + y);
                }
                else if (z == '-')
                    Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                else if ((z == '*') || (z == '*'))
                    Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                else if (z == '/')
                    Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
                else
                    Console.WriteLine("Wrong Character");

                Console.ReadLine();
            }
        }
    }