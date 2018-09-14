using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace seleniumtest1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://horse-dev.azurewebsites.net";
            driver.FindElement(By.Id ("UserName")).SendKeys("ray");
            driver.FindElement(By.Id ("Password")).SendKeys("123123");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Submit();
            driver.Close();
        }
    }
}
