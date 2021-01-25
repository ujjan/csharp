using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {

            //Arrange

            Book book = new Book("");
            book.AddGrade(99.9);
            book.AddGrade(80.5);
            book.AddGrade(70.3);



            //Act
            
           // var average = book.AverageGrade();




            //Assert

            Assert.Equal(70.3, book.GetStatics().Low);
            Assert.Equal(99.9, book.GetStatics().High);
            Assert.Equal(83.6, book.GetStatics().Average, 1);



        
        }
         
}
}
