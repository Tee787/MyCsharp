/*In this program, we have designed a survey to ask for basic information from the user.
 We have also added an "if" statement to notify the user that they haven't entered anything.
 We had duplicate lines of "Console.WriteLines" inside our if statements that may cause problems if we were to update
 our program, or add more code in the near future.
 To rectify this problem we added another "function" outside of our "Main" function. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your firstname? ");
            var fname = Console.ReadLine();
            
            //if (fname == "")        //Our if statements 
            //{
            //    //Console.WriteLine("you have not entered anything. Please try again");
                fname = TryAgain(fname);    //Our function we developed to replace our many console.writeline duplicates
            //    //fname = Console.ReadLine(); //Used a return in our function to compress our lines of code to one single line of code
            //}

            Console.WriteLine("What is your surname? ");
            var lname = Console.ReadLine();

            //if (lname == "")
            //{
            //    //Console.WriteLine("you have not entered anything. Please try again");
                lname = TryAgain(lname);
            //    //lname = Console.ReadLine();
            //}

            Console.WriteLine("What is your age? ");
            var age = Console.ReadLine();

            //if (age == "")
            //{
            //    //Console.WriteLine("you have not entered anything. Please try again");
                age = TryAgain(age);
            //    //age = Console.ReadLine();
            //}

            Console.WriteLine("What is your date of birth? ");
            Console.WriteLine("Day: ");
            var day = Console.ReadLine();
            //if (day == "")
            //{
            //    //Console.WriteLine("you have not entered anything. Please try again");
                day = TryAgain(day);
            //    //day = Console.ReadLine();
            //}
            Console.WriteLine("Month: ");
            var month = Console.ReadLine();
            //if (month == "")
            //{
            //    //Console.WriteLine("you have not entered anything. Please try again");
                month = TryAgain(month);
            //    //month = Console.ReadLine();
            //}
            
            Console.WriteLine("Year: ");
            var year = Console.ReadLine();
            //if (year == "")
            //{
            //    //Console.WriteLine("you have not entered anything. Please try again");
                year = TryAgain(year);          //What we have done is simplified our code to just one line
            //    //year = Console.ReadLine();
            //}
            Console.WriteLine("Your name is {0} {1}", fname,  lname);
            Console.WriteLine("Your are {0} years old", age);
            Console.WriteLine("And your date of birth is {0}/{1}/{2} ", day, month, year);
            Console.ReadLine();
            

        }

        static /*void*/string TryAgain(string fname)   //Name of our function to be used in our lines of code
        {
            if (fname == "")
            {
                Console.WriteLine("you have not entered anything. Please try again");   //Line of code in our function
                return Console.ReadLine();      //return line of code
            }
            return fname;    
        }
    }
}
