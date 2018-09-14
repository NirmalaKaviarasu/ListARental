using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace seleniumtest1
{
    class Start
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
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
    }

    }
