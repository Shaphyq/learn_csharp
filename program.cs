using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome1
{
    class Program
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Sartuday };

        #region struct
        struct Coffee
        {
            public string Name { get; set; }
            public string Bean { get; set; }
            public string CountyOfOrigin { get; set; }
            public int Strength { get; set; }
            public string grind;

        }

        #endregion
        static void Main(string[] args)
        {
            #region using a struct

            Coffee coffee1 = new Coffee();
            coffee1.Name = "Fourth Coffee Quencher";
            coffee1.CountyOfOrigin = "Indonesia";
            coffee1.Strength = 3;
            coffee1.grind = "fine";
            Console.WriteLine("Name: {0}", coffee1.Name);
            Console.WriteLine("Country of Origin: {0}", coffee1.CountyOfOrigin);
            Console.WriteLine("Strength: {0}", coffee1.Strength);
            Console.WriteLine("The grind is: {0}", coffee1.grind);

            #endregion

            #region enum

            //int x = (int)Days.Sunday;
            //int y = (int)Days.Friday;
            //Console.WriteLine("Sun = {0}", x);
            //Console.WriteLine("Fri = {0}", y);

            #endregion

            #region Variables, Operators & Expressions

            //int condition1;
            //int condition2;
            //int switchCondition;
            #endregion

            #region Decision Statements

            ////if sample
            //condition1 = 1;
            //if (condition1 == 1)
            //{
            //    Console.WriteLine("comparison evaluated to true.");
            //}

            //Console.WriteLine("This executes after the if, regardles of what has taken place.");

            //if-else sample
            //condition1 = 3;
            //if (condition1 == 1)
            //{
            //    Console.WriteLine("comparison evaluated to true");
            //}
            //else
            //{
            //    Console.WriteLine("comparison evaluate to false.");
            //}

            //if-else-if sample
            //condition1 = 1;
            //condition2 = 2;
            //if (condition1 == 3)
            //{
            //    Console.WriteLine("condition1 is true.");
            //}
            //else if (condition2 == 1)
            //{
            //    Console.WriteLine("condition2 is true.");
            //}
            //else
            //{
            //    Console.WriteLine("Neither condition is true.");
            //}

            //switch sample
            //switchCondition = 2;

            //switch (switchCondition)
            //{
            //    case 1:
            //        Console.WriteLine("value is 1.");
            //        break;

            //    case 2:
            //        Console.WriteLine("value is 2");
            //        break;

            //    case 3:
            //        Console.WriteLine("value is 3");
            //        break;

            //    default:
            //        Console.WriteLine("value is " + switchCondition);
            //        break;
            //}
            #endregion

            #region Repetion Statements

            //int whileCounter = 0;
            //int doCounter = 0;

            //for loop sample
            //Console.WriteLine("for loop");
            //Console.WriteLine();

            //for (int forCounter = 0; forCounter < 10; forCounter++)
            //{
            //    Console.WriteLine("forCounter is at" + forCounter);
            //}

            //while loop sample
            //Console.WriteLine();
            //Console.WriteLine("while loop");
            //Console.WriteLine();

            //while(whileCounter < 5)
            //{
            //    Console.WriteLine("whileCounter is at " + whileCounter);
            //    whileCounter++;
            //}

            //do-while sample
            //Console.WriteLine();
            //Console.WriteLine("do-while loop");
            //Console.WriteLine();

            //do
            //{
            //    Console.WriteLine("doCounter is at " + doCounter);
            //    doCounter++;
            //} while (doCounter < 5);

            //recursion sample
            //Console.WriteLine();
            //Console.WriteLine("recursion");
            //Console.WriteLine();

            //long value = Factorial(10);
            //Console.WriteLine(value);
            #endregion

            #region methods

            //Demostrating methods
            //First method returns nothing and accepts nothing parameters
            //PrintSomething();
             
            //Create some variables for use in a method call
            //int first = 10;
            //int second = 2;
            //string sValue;

            //This method call will expect a single value returned
            //So the return value must be assigned to something
            //We also pass in two arguments to the method
            //int result = Sum(first, second);
            //Console.WriteLine("The sum of {0} and {1} is: {2}", first, second, result);

            //C# methods typically only return a single value
            //You can use out or ref as a way of returning multiple items from a method
            //Using out
            //ReturnMultiOut(out first, out sValue);
            //Console.WriteLine("{0}, {1}", first.ToString(), sValue);
            
            //Using ref requires that the variables be initialized first
            //sValue = "";
            //ReturnMultiRef(ref first, ref sValue);
            //Console.WriteLine("{0}, {1}", first.ToString(), sValue);

            //Using named parameters
            //Area(length: 30, width: 50);

            //Using optional parameters
            //OptionalParams(10, 20);

            #endregion

            #region Exception Handling

            //double a = 98, b = 0;
            //double result = 0;

            //try
            //{
            //    result = SafeDivision(a, b);
            //    Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Attempted divide by zero.");
            //}
            #endregion

            #region Arrays
            ////Integer array of size 10
            //int[] intArray = new int[10];

            ////integer array of size 5 by initializing
            //int[] newArray = { 1, 2, 3, 4, 5 };

            //for(int counter = 0; counter < newArray.Length; counter++)
            //{
            //    Console.WriteLine(newArray[counter]);
            //}

            //create 2 dimensional array and iterate over it.
            //int[,] twoDArray = { { 3, 2 }, { 4, 5 }, { 5, 6 } };

            //for (int x = 0; x < twoDArray.GetLength(0); x++)
            //{
            //    for (int y = 0; y < twoDArray.GetLength(1); y++)
            //    {
            //        int value = twoDArray[x, y];
            //        Console.WriteLine(value.ToString());
            //    }
            //}
            #endregion
        }

        #region functions

        //static long Factorial(int n)
        //{
        //    if (n == 0)
        //    {
        //        return 1;
        //    }

        //    return n * Factorial(n - 1);
        //}
        #endregion

        #region Called Methods
        static void PrintSomething()
        {
            Console.WriteLine("PrintSomething() method was called.");
        }

        static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        static void ReturnMultiOut(out int i, out string s)
        {
            i = 25;
            s = "using out";
        }

        static void ReturnMultiRef(ref int i, ref string s)
        {
            i = 50;
            s = "using ref";
        }

        static void Area(int length, int width)
        {
            Console.WriteLine("The area is {0}", length * width);
        }

        static void OptionalParams(int one, int two, string s = "default text")
        {
            Console.WriteLine("{0}, {1}, {2}", one, two, s);
        }

        static double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
        }
        #endregion
    }
}
