using System;
using System.Collections.Generic;

namespace GradeBook
{

    
    public class Book
    {

        private string name;
       private List<double> grades;
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
      
       public void AddGrade(double num)
       {
           grades.Add(num);
       }

       

       public Statistics GetStatics()
       {
            var result = new Statistics();
            result.High = double.MinValue;
            result.Low = double.MaxValue;
           

            foreach (var number  in grades)
            {
                result.Average += number;
                result.Low = Math.Min(result.Low, number);
                result.High = Math.Max( result.High, number);
            }
            result.Average = result.Average/ grades.Count;

            return result;
       
       }
    }
}