using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace Seleniumframework
{
    class Nunit1
    {
        IWebDriver driver;


        [SetUp]

        public void Initialize()
        {
            driver = new ChromeDriver();

        }

        [Test]
        public void Login()
        {
            driver.Url = "http://horse-dev.azurewebsites.net";
            driver.FindElement(By.Id("UserName")).SendKeys("ray");
            driver.FindElement(By.Id("Password")).SendKeys("123123");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement mes = driver.FindElement(By.LinkText("Dashboard"));
            if (mes.Text.Contains("Dashboard"))
            {

                Console.WriteLine("Home Page Displayed");
            }
            else
                Console.WriteLine("Home page not Displayed");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            driver.Close();
        }
        /*[TearDown]
        public void Closing()
        {

            driver.Close();

        }
        */
    }
}


