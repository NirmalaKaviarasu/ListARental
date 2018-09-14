using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework2507;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using NUnit.Framework;


namespace TestProject507
{
    [TestFixture]
    public class BasicTest
    {
        public static string PageTitle;

        [Test]
        public static void Can_Go_To_HomePage()
        {
            HomePage.CanGoToHomePage();

        }


        [Test]
        
        public static void Verify_Page_Title()
        {
            PageTitle = HomePage.VerifyPageTitle();
            Console.WriteLine(PageTitle);
            PageTitle = HomePage.VerifyPageTitle();
            string ExpectedTitle = "IndustryConnect.IO";
            Assert.AreEqual(ExpectedTitle, PageTitle, "Title is not same");
        }

        [OneTimeTearDown]
        public void CloseTestBrowser()
        {
            HomePage.CloseHomeBrowser();
        }
    }

}
