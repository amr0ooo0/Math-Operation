using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 7;
            int var2 = 3;
            int sum = var1 + var2;
            int sub = var1 - var2;
            int mult = var1 * var2;
            float div = var1 / var2;

            Console.WriteLine("My First Num = {0} \nMy Second Num = {1} \nSum = {2} \nsub = {3} \nMult = {4} \nDiv = {5}",var1,var2,sum,sub,mult,div);
            string mYstring = "I am";
            string mYstring2 = "Smart";
            Console.WriteLine("{0} {1}", mYstring, mYstring2);

            Console.ReadKey();


        
        }
    }
}
