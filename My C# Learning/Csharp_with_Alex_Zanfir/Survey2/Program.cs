using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your firstname? ");
            var fname = Console.ReadLine();
            if (fname == "")
            {
                TryAgain();
                fname = Console.ReadLine();
            }
            Console.WriteLine("What is your surname? ");
            var lname = Console.ReadLine();
            if (lname == "")
            {
                TryAgain();
                lname = Console.ReadLine();
            }
            Console.WriteLine("How old are you? ");
            var age = Console.ReadLine();
            if (age == "")
            {
                TryAgain();
                age = Console.ReadLine();
            }
            Console.WriteLine("What is your date of birth?");
            Console.WriteLine("Day: ");
            var day = Console.ReadLine();
            if (day == "")
            {
                TryAgain();
                day = Console.ReadLine();
            }
            Console.WriteLine("Month: ");
            var month = Console.ReadLine();
            if (month == "")
            {
                TryAgain();
                month = Console.ReadLine();
            }
            Console.WriteLine("Year: ");
            var year = Console.ReadLine();
            if (year == "")
            {
                TryAgain();
                year = Console.ReadLine();
            }

            Console.WriteLine("Your details are as follows: \nName {0} {1} ", fname, lname);
            Console.WriteLine("You are {0} years of age ", age);
            Console.WriteLine("Your date of birth is: {0} / {1} / {2}", day, month, year);
            Console.ReadLine();
            if (month == "01")
            {
                Console.WriteLine("You are an Aquarius ");
                month = Console.ReadLine();
            }
            else if (month == "02")
            {
                Console.WriteLine("You are a Pisces ");
                month = Console.ReadLine();
            }
            else if (month == "03")
            {
                Console.WriteLine("You are an Aries ");
                 = Console.ReadLine();
            }
            else if (month == "04")
            {
                Console.WriteLine("You are a Taurus");
                Console.ReadLine();
            }
            else if (month == "05")
            {
                Console.WriteLine("You are a Gemini");
                Console.ReadLine();
            }
            else if (month == "06")
            {
                Console.WriteLine("You are a Cancer");
                Console.ReadLine();
            }
            else if (month == "07")
            {
                Console.WriteLine("You are a Leo");
                Console.ReadLine();
            }
            else if (month == "08")
            {
                Console.WriteLine("You are a Virgo");
                Console.ReadLine();
            }
            else if (month == "09")
            {
                Console.WriteLine("You are a Libra");
                Console.ReadLine();
            }
            else if (month == "10")
            {
                Console.WriteLine("You are a Scorpio");
                Console.ReadLine();
            }
            else if (month == "11")
            {
                Console.WriteLine("You are a Sagittarius");
                Console.ReadLine();
            }
            else if (month == "12")
            {
                Console.WriteLine("You are a Capricorn");
                Console.ReadLine();
            }
        }
        static void TryAgain()
        {
            Console.WriteLine("You haven't entered anything. Please try again:");
        }
    }
}
