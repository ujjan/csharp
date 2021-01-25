using System;
using System.Collections.Generic;

namespace GradeBook
{
    internal class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
      private double result = 0;
      private List<double> grades;
      private string name;
      private double hiGrade = double.MinValue;
      private double lowestGrade = double.MaxValue;
       
       public double AverageGrade()
       {

            foreach (var number  in grades){
                result += number;
            }

            result = result / grades.Count;
            return result;

       }

       public void AddGrade(double num)
       {
           grades.Add(num);
       }

       public double HighGrade()
       {
           foreach (var item in grades)
           {
               hiGrade = Math.Max(item, hiGrade);
           }

           return hiGrade;
       }

       public double LowestGrade()
       {
           foreach (var item in grades)
           {
               lowestGrade = Math.Min(lowestGrade, item);
           }
           return lowestGrade;
       }

       public void ShowStatics()
       {
            System.Console.WriteLine($"The average Grade is: {AverageGrade()}");
            System.Console.WriteLine($"Highets grade: {HighGrade()}");
            System.Console.WriteLine($"Lowest grade: {LowestGrade()}");
       }
    }
}