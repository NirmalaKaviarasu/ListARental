using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;


namespace PomFrameworkLib
{
    public class PageMaterial
    {
        public static void CanCreateTimeandMaterial()
        {
            var admin = Browser.driver.FindElement(By.LinkText("Administration"));
            admin.Click();
            var timeandmaterial = Browser.driver.FindElement(By.LinkText("Time & Materials"));
            timeandmaterial.Click();
            var createbtn = Browser.driver.FindElement(By.LinkText("Create New"));
            createbtn.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            //Code
            IWebElement code = Browser.driver.FindElement(By.Id("Code"));
            Console.WriteLine("Going to find element description");
            //Description
            IWebElement Description = Browser.driver.FindElement(By.Id("Description"));
            Console.WriteLine("Going to find element Price");
            Console.WriteLine("Going to find element savebutton");
            //Locate Save Buttom
            IWebElement saveClick = Browser.driver.FindElement(By.Id("SaveButton"));
            Console.WriteLine("send keys for code");
            code.SendKeys("key_1236");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            Description.SendKeys("Prasanna veed2");
            //Price
            IWebElement Price = Browser.driver.FindElement(By.Id("Price"));
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            Price.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            Price.SendKeys("7000");
            Console.WriteLine("going to click the save button ");
            saveClick.Click();
        }
    }
}
