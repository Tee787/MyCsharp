//Loop counting challenge
//
//Count from 1 to 10, and then back to 1, repeat 5 times
//
//Cannont use "if" statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloop_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 1; j <=5; j++)         //Our MAIN / PARENT for loop for repeating our loops 5 times
            {
                for (int i = 1; i <= 10; i++)   //Our 1st loop for count 1 to 10
                {
                    Console.WriteLine(i);
                }
                for (int i = 10; i >= 1; i--)   //Our 2nd loop for counting backwards from 10 to 1
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            //NOTE: 
            //1. We nested our counting loops nested inside our main / parent loop to acheive our challenge result.
            //2. We have to change our main loop variable letter from "i" to "j" becuse of a conflict with "i" used in our 
            //nested for loops.
            
        }
    }
}
