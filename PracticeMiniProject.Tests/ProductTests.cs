using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PracticeMiniProject.Models;

namespace PracticeMiniProject.Tests
{
    public class ProductTests
    {
        [Fact]
        public void CanChangeProperties()
        {
            //Arrange
            Book b = new Book { ID = 1, Title = "Harry Potter", Author = "JK Rowling", Price = 14.99M };

            //Act
            b.ID = 5;
            b.Title = "New Title";
            b.Author = "New Author";
            b.Price = 5M;

            //Assert
            Assert.Equal(5, b.ID);
            Assert.Equal("New Title", b.Title);
            Assert.Equal("New Author", b.Author);
            Assert.Equal(5M, b.Price);
        }
    }
}
