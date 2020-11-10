using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using NUnit.Framework;
using WebAppGitDemo;
using WebAppGitDemo.Controllers;

namespace WebAppGitDemo.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void IndexTest()
        {
            // Arrange
            var controller = new HomeController();


            // Act
            var result = controller.Index();

            // Assert
            Assert.IsNotNull(result);
        }

        
    }
}
