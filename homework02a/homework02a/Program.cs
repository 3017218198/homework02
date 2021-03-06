﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02a
{
    // create a new class "HelloClass"
    public class HelloClass
    {
        // method Print() is used to print "hello world";
        public void Print()
        {
            Console.WriteLine("Hello world!");
        }

        /* method PrintWithCommandLine(String, String) is used to print "hello world" and the arguments of command line;
         * the number of command line arguments should be two, or the result would be wrong;
         * the default arguments are "argument01" and "argument02"
         */
        public void PrintWithCommandLine(String arg0, String arg1)
        {
            Console.WriteLine("Hello world, the input arguments of command line are {0} and {1}", arg0, arg1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //install an object "object01" of HelloClass 
            HelloClass object01 = new HelloClass();

            // firstly print "hello world" with the method Print()
            object01.Print();

            // if the number of arguments is 2, print with the method PrintWithCommandLine()
            // if the number of arguments is not 2, print "Error, the number of arguments of command line should be 2."
            if (args.Length == 2)
            {
                object01.PrintWithCommandLine(args[0], args[1]);
            }
            else
            {
                Console.WriteLine("Error, the number of arguments of command line should be 2.");
            }

        }
    }
}
