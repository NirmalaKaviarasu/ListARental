using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace HorseNunit
{
    class CheckingMenus
        {
        IWebDriver driver;

        [SetUp]
        public void Intialize()
        {
            driver = new ChromeDriver();
                       
        }

        [Test]
        public void Test1()
        {
            driver.Url = "http://horse-dev.azurewebsites.net/";
        }

        [TearDown]
        public void Closing()
        {
            driver.Quit();
        }
    }
}
