using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            double result = 0;
            List<double> grades = new List<double>() {12.4, 23.6, 13.5};

                grades.Add(.5);

            foreach (var number  in grades){
                result += number;
            }

            result = result / grades.Count;

            System.Console.WriteLine($"The average Grade is: {result:N2}");


        }

    }
}
