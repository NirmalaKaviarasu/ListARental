using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace HorseTest
{
    public class MenuCheck
    {
       
        IWebDriver driver= new ChromeDriver();

        [SetUp]
        public void Intialize()
        {

            driver.Url = "http://horse-dev.azurewebsites.net/";
        }

        [Test]
        public void Test1()

        {
            Console.WriteLine("hello");
        }

        [TearDown]
        public void Closing()
        {
            driver.Quit();
        }

    }
}