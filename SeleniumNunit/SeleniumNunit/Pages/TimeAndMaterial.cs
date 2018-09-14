using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;

namespace SeleniumNunit.Pages
{
    class TimeAndMaterial
    { 
    
        public void add(IWebDriver driver)
    {
        driver.FindElement(By.LinkText("Administration")).Click();
        driver.FindElement(By.LinkText("Time & Materials")).Click();

    }
           
    }
}
