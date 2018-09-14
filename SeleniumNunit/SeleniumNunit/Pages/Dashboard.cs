using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace SeleniumNunit
{
    class Dashboard
    {
        public void Dash(IWebDriver driver)
        {
            driver.FindElement(By.CssSelector("div.box.job.New.ui-droppable:first-of-type")).Click();
            driver.FindElement(By.Id("jobpanelclose")).Click();

            
            //Check for Dashboard Page
            driver.FindElement(By.LinkText("Dashboard")).Click();
            WebDriverWait daswait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            daswait.Until(drv => drv.FindElement(By.Id("addnewjob")));
            driver.FindElement(By.Id("maxbutton")).Click();
            driver.FindElement(By.Id("maxbutton")).Click();
            driver.FindElement(By.Id("eventbutton")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}