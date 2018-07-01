using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/// <summary>
/// C# program: Write a recursive static method that calculates the product of all digits of an integer number. 
/// Author: Faryaz
/// </summary> 

namespace Paracticle_2_Q_3
{
    class Recursion
    {
        static void Main(string[] args)
        {
            Recursion recur = new Recursion();
            Write("Enter an integer num: ");
            int num = int.Parse(ReadLine());
            WriteLine($"The product of all digits of the number {num} is {CalcProduct(num)}");

        }
        public static int CalcProduct(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                int lastdigitofnum = num % 10;
                int subdigitofnum = num / 10;
                int product = lastdigitofnum * CalcProduct(subdigitofnum);

                return product;
            }
        }
    }
}