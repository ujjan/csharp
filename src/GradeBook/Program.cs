using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("Computer");

            book.AddGrade(50.0);
            book.AddGrade(51.0);
            System.Console.WriteLine( book.GetStatics().High);
            System.Console.WriteLine( book.GetStatics().Low);
            System.Console.WriteLine( book.GetStatics().Average);



        }

    }
}
