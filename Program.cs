using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            // this is not change in to new line 
            Console.Write("I learing c#");
            /*
             * this is multiple
             * line comment
             */
            int num = 56;
            Console.WriteLine("King C++++ = C# ....");
            Console.WriteLine("Number is 1 = " + num);

            
            // Data Types in c#
            int n1 = 100;
            float f1 = 20.99f;
            float f2 = n1;
            char c1 = 'd';
            bool b1 = true;
            double d1 = 1_000_0000_000_000.9999D; //  better then float
            long l1 = 1_000_0000_000_000;  ///  better then int 
            String s1 = "Hello world"; // 2bytes/char =>Space (it is object of type String)

            Console.WriteLine("int= " + n1);
            Console.WriteLine("float= " + f1);
            Console.WriteLine("float= " + f2);
            Console.WriteLine("char= " + c1);
            Console.WriteLine("boolean= " + b1);
            Console.WriteLine("double= " + d1);
            Console.WriteLine("long= " + l1);
            Console.WriteLine("string= " + s1);
            Console.WriteLine(); // for the space only 

            // explicit typeCasting
            // need to write ->(int) this
            float f = 99.99f;
            int a = (int)f;
            Console.WriteLine(a);  // 99

            // implicit type casting (it is done by the comiler)
            // char  ->int -> long -> float -> double

            char c3 = 'A';
            Console.WriteLine("Char = " + c3); // A
            int i3 = c3;
            Console.WriteLine(" Int= " + i3);  //65
            long l3 = i3;
            Console.WriteLine("  Long = " + l3);  //65
            float f3 = l3;
            Console.WriteLine("   Float= " + f3);  //65
            double d3 = f3;
            Console.WriteLine("    Double= " + d3);  //65

            //explicit type casting  (we need to do this )
            float f4 = (float)d3;
            Console.WriteLine("    float = " + f4);  //65
            long l4 = (long)f4;
            Console.WriteLine("   long = " + l4);   //65
            int i4 = (int)l4;
            Console.WriteLine("  int = " + i4);   //65
            char c4 = (char)d3;
            Console.WriteLine(" Char = " + c4);   //A


            // built in method for other typecasing
            int var1 = Convert.ToInt32(3.51);
            int var2 = Convert.ToInt32(3.50);
            int var3 = Convert.ToInt32(3.49);

            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);


            /*
             * USER INPUT Learning.....
             */
            Console.Write("Enyter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("welcome => " + name);

            Console.Write("How many candy you need=>");
            String can = Console.ReadLine();
            Console.WriteLine("you will gat 4 more candy" + (Convert.ToInt64(can) + 4));










            // this is alwasy in last to stop the console 
            Console.ReadLine();
        }
    }
}
