using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestSpecflowDemoJuly
{
    [Binding]
    public class LoginSteps
    {

        IWebDriver driver = new ChromeDriver();

        [Given(@"User is on the Login Page")]
        public void GivenUserIsOnTheLoginPage()
        {
            driver.Url = "http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f";

        }

        [Given(@"User is inserting (.*) in the username textbox")]
        public void GivenUserIsInsertingRayInTheUsernameTextbox(string username)
        {
            driver.FindElement(By.CssSelector("input#UserName")).SendKeys(username);

        }

        [Given(@"User is inserting (.*) in the password textbox")]
        public void GivenUserIsInsertingInThePasswordTextbox(string password)
        {
            driver.FindElement(By.Id("Password")).SendKeys(password);
        }

        [When(@"User is clicking the in the Login Button")]
        public void WhenUserIsClickingTheInTheLoginButton()
        {
            driver.FindElement(By.CssSelector("input.btn.btn-default")).Submit();

        }


        [Then(@"User should see the Dashboard Page")]
        public void ThenUserShouldSeeTheDashboardPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.FindElement(By.Id("addnewjob")));

            IWebElement mes = driver.FindElement(By.Id("addnewjob"));
            //Assert.IsType(IWebElement, mes);
        }

        [Then(@"User should see the Login Page with Error")]
        public void ThenUserShouldSeeTheLoginPageWithError()
        {

        }


         [AfterScenario]
        public void Dispose()
        {
            driver.Dispose();
        }
    }
}