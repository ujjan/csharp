using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("Computer");

            book.AddGrade(99.5);
            book.AddGrade(57.5);
            book.AddGrade(34.5);
            book.AddGrade(67.5);
            book.AddGrade(99.6);
            book.ShowStatics();
        }

    }
}
