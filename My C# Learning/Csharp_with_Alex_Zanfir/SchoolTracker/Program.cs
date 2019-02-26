using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //var student1Grade = 80;
            //var student2Grade = 77;

            //A shorter way of using our varibles is using an 'Array"

            var studentGrades = new int[] { 80, 77, 45, 87, 53, 43, 67, 28, 33, 50};
            //instead of typing out all of the stundent grades for each student as set out below, 
            //we can set out the grades in our array as set out above in the baces.

            //studentGrades[0] = 80;
            //studentGrades[1] = 77;
            //studentGrades[2] = 45;
            //studentGrades[3] = 87;
            //studentGrades[4] = 53;
            //studentGrades[5] = 43;
            //studentGrades[6] = 67;
            //studentGrades[7] = 28;
            //studentGrades[8] = 33;
            //studentGrades[9] = 50;

            //We then add our stundent grades inside our console input, for the output to be displayed in the console window.
            //Console.WriteLine(studentGrades);
            //Console.ReadLine();

            //Another way is to use a "foreach" loop to our student grades as set out below

            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }
            
        }
    }
}
