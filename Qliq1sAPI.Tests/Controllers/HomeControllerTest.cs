﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qliq1sAPI;
using Qliq1sAPI.Controllers;
using System.Web.Mvc;

namespace Qliq1sAPI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
