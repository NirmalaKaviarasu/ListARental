using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumNunit.Pages
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage()
            {
            PageFactory.InitElements(driver, this);
            }
        
        [FindsBy(How = How.CssSelector, Using = "input#UserName")]
        public IWebElement UserName { set; get; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { set; get; }

        public void NavigateUrl()
        {
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/");
        }
        public void login()
        {

            UserName.SendKeys("ray");
            Password.SendKeys("123123");
            driver.FindElement(By.CssSelector("input.btn.btn-default")).Submit();

        }
    }
    
       /* public void LoginTest()
        {
           driver.Url = "http://horse-dev.azurewebsites.net/";
           driver.Manage().Window.Maximize();
            IWebElement user = driver.FindElement(By.CssSelector("input#UserName"));
            user.SendKeys("ray");
            IWebElement pass = driver.FindElement(By.Id("Password"));
            pass.SendKeys("123123");

            //Uncheck Remember me if selected
            IWebElement rem = driver.FindElement(By.CssSelector("input[name='RememberMe'][type=checkbox]"));
            if (rem.Selected)
            {
                rem.Click();
            }
            driver.FindElement(By.CssSelector("input.btn.btn-default")).Submit();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.FindElement(By.Id("addnewjob")));

            //Check for Login Success
            //WebElement mes = driver.FindElement(By.Id("addnewjob"));
         
    //Asert.IsTrue(mes.Displayed); */
        }
    

