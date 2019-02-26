using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Using a "while" loop to increment our count from 1 to 10

            //var count = 1;                  //Declaring our "count" variable with a value of 1 to start

            //while (count <= 10)             //Our "while" loop with our variable count less than or equal to 10

            //{
            //    Console.WriteLine(count);   //Out input to the console
            //    count++;                    //Our increment count result
            //}
            //Console.ReadLine();             //Our output to be displayed in the output window


            //Using a "for" loop to increment our count from 1 to 10

            //for (int i = 1; i < 10; i++)    //Our "for" loop 
            //{
            //    Console.WriteLine(i);       //Our input to be displayed in the console window
            //}
            //Console.ReadLine();             //Our output to be displayed

            //When we execute our code to the console window, it displays "1 to 9" 
            //We need it to count to "10", so we add a equals sign (=) infront of our less than sign (<)
            // to give the correct output from 1 to 10.

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
