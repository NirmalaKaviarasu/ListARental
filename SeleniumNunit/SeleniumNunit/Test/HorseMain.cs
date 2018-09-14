using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using SeleniumNunit.Pages;

namespace SeleniumNunit.Test
{
    class HorseMain
    {
        private IWebDriver driver;
        [SetUp]
        public void init()
        {
            driver = new ChromeDriver();

        }

        [Test]
        public void loginTest()
        {
            LoginPage logobj = new LoginPage();
            logobj.NavigateUrl();
            logobj.login();
       
         //   Dashboard dasobj = new Dashboard();
          //  dasobj.Dash(driver);
        
           // TimeAndMaterial timeobj = new TimeAndMaterial();
            //timeobj.add(driver);
        }
    }
}
