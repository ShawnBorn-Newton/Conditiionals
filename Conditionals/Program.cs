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

            //    Console.WriteLine("How many people in your party?");
            //    int numberOfPeople = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Please enter in your total bill.");
            //    double totalBill = double.Parse(Console.ReadLine());


            //    double moreDiscountTotal = (totalBill - (totalBill * .10d));
            //    double lessDiscountTotal = (totalBill - (totalBill * .05d));
            //Console.WriteLine("THANK YOU");
            //Console.WriteLine("Party of:" + numberOfPeople);
            //    if (totalBill >= 50d)
            //    {
            //        Console.WriteLine("Total with discount: $" + moreDiscountTotal);
            //        Console.WriteLine("Each person will pay: " + moreDiscountTotal / numberOfPeople);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Total with discount: $" + lessDiscountTotal);
            //        Console.WriteLine("Each person will pay: " + lessDiscountTotal / numberOfPeople);
            //}

            //    Console.WriteLine("Tip:__________");
            //    Console.WriteLine("Total:__________");

            Console.WriteLine("Please Enter A Number From One To Ten In Text From");

            string number = Console.ReadLine();
            switch (number)
            {
                case "zero":
                Console.WriteLine("0");
                    break;
                case "one":
                    Console.WriteLine("1");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "five":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "ten":
                    Console.WriteLine("10");
                    break;
                default:
                    Console.WriteLine("Not in peramiters");
                    break;
            }

            }
        }
    }
