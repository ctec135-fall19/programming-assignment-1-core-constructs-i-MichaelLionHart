/*
Author: Mike Hart
Date:   10/4/19
CTEC 135: Microsoft Software Development with C#

<Solution Name>

<Problem description from README.md file. Make sure the comment text is 
reformatted to fit 1-80 column display, with appropriate indentations to 
make it readable>

Example:
Prob 1: Prob 1: Variables and Printing

* region 1: variable declarations

    page 18 in Troelsen shows two different ways to declare int variables. 
    page 71 shows a third way using the "new" keyword.

    In this section declare three different double variables using each of 
    the three type declarations.
...

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region example of a code region

            double i = 0;
            System.Double j = 0;
            double m = new double();

            #endregion

            #region another code region

            bool b = true;
            byte a = 200;
            short s = 3000;
            int x = 200_000_000;
            long l = 566_754_432_456_345L;
            float f = 345.654F;
            double d = 344_987.35;
            decimal y = 320_874.74M;

            Console.WriteLine("bool b: ", b);
            Console.WriteLine("byte a in E format: {0:E}", a);
            Console.WriteLine("short s: ", s);
            Console.WriteLine("int x: ", x);
            Console.WriteLine("long l as currency: {0:c}", l);
            Console.WriteLine("float f: ", f);
            Console.WriteLine("double d: ", d);
            Console.WriteLine("decimal y: ", y);

            #endregion

            Console.WriteLine("The range of a byte is: {0} - {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("The range of a short is: {0} - {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("The range of a an int is: {0} - {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("The range of a long is: {0} - {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("The range of a float is: {0} - {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("The range of a double is: {0} - {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("The range of a decimal is: {0} - {1}", decimal.MinValue, decimal.MaxValue);      
            
            #region

            #endregion
        }
    }
}
