using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;
using PracticeMiniProject.Controllers;
using PracticeMiniProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace PracticeMiniProject.Tests
{
    public class ControllerTests
    {
        [Theory]
        [ClassData(typeof(ProductTestData))]
        public void IndexActionReturnsCorrectBooks(Book[] books)
        {
            //Arrange
            var mock = new Mock<IRepository>();
            mock.SetupGet(m => m.Books).Returns(books);
            var controller = new HomeController { myRepository = mock.Object };

            //Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Book>;

            //Assert
            Assert.Equal(mock.Object.Books, model, Comparer.Get<Book>((b1, b2) => b1.ID == b2.ID));
        }
    }
}
