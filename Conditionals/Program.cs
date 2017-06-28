using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("How many people in your party?");
                int numberOfPeople = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter in your total bill.");
                double totalBill = double.Parse(Console.ReadLine());
                

                double moreDiscountTotal = (totalBill - (totalBill * .10d));
                double lessDiscountTotal = (totalBill - (totalBill * .05d));
            Console.WriteLine("THANK YOU");
            Console.WriteLine("Party of:" + numberOfPeople);
                if (totalBill >= 50d)
                {
                    Console.WriteLine("Total with discount: $" + moreDiscountTotal);
                    Console.WriteLine("Each person will pay: " + moreDiscountTotal / numberOfPeople);
                }
                else
                {
                    Console.WriteLine("Total with discount: $" + lessDiscountTotal);
                    Console.WriteLine("Each person will pay: " + lessDiscountTotal / numberOfPeople);
            }

                Console.WriteLine("Tip:__________");
                Console.WriteLine("Total:__________");
            }
        }
    }
