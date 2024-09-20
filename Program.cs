using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT2105_Seatwork1_Bejosano
{
    class Program
    {
        static void Main(string[] args)
        {
            int mathgrade, enggrade, sciegrade, wrpgrade;
            Double math, english, science, Wrp, sum, avg;

            Console.WriteLine("Enter the Grade to Calculate the Average");
            Console.WriteLine("");
            Console.WriteLine("Math: ");
            String mgrade = Console.ReadLine();
            Console.WriteLine("English: ");
            String egrade = Console.ReadLine();
            Console.WriteLine("Science: ");
            String sgrade = Console.ReadLine();
            Console.WriteLine("WRP: ");
            String wgrade = Console.ReadLine();

            mathgrade = Convert.ToInt32(mgrade);
            enggrade = Convert.ToInt32(egrade);
            sciegrade = Convert.ToInt32(sgrade);
            wrpgrade = Convert.ToInt32(wgrade);

            math = Convert.ToDouble(mathgrade);
            english = Convert.ToDouble(enggrade);
            science = Convert.ToDouble(sciegrade);
            Wrp = Convert.ToDouble(wrpgrade);

            sum = math + english + science + Wrp;
            avg = sum / 4;
            Console.WriteLine("Average: " + avg);

            Console.WriteLine("");


            if (avg > 100)
            {
                Console.WriteLine("Invalid GradeS");
            }
            else if (avg >= 98)
            {
                Console.WriteLine("With Highest Honors");
            }
            else if (avg >= 95)
            {
                Console.WriteLine("With High Honors");
            }
            else if (avg >= 90)
            {
                Console.WriteLine("With With Honors");
            }
            else if (avg >= 75)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.ReadKey();



        }
    }
}
