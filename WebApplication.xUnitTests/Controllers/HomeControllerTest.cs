using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApplication.xUnitTests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void Contact()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Contact() as ViewResult;

            //Assert
            Assert.NotNull(result);
        }
    }
}
