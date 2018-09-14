using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using excel = Microsoft.Office.Interop.Excel;


namespace PomFrameworkLib
{
    public class LoginPage
    {
       String username1;
       String password1;

        public static string url = "http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f";

        public static void GoTo()
        {
            Browser.driver.Url = url;
        }

        public static void CanLogin()
        {
            var userName = Browser.driver.FindElement(By.XPath("//*[@id='UserName']"));
            var password = Browser.driver.FindElement(By.XPath("//*[@id='Password']"));
            var loginButton = Browser.driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));

            excel.Application xApp1 = new excel.Application();

            excel.Workbook xWrk1 = xApp1.Workbooks.Open(@"C:\Users\Mallik\source\repos\PomFrameworkLibrary\PomFramework\DemoTestData\TestData.xlsx");

            excel._Worksheet xsht1 = xWrk1.Sheets[1];

            excel.Range xrng = xsht1.UsedRange;

            int xlRowCount = 0;

            String username1;
            String password1;

            for (xlRowCount = 2; xlRowCount <= xrng.Rows.Count; xlRowCount++)
            {

                username1 = (xrng.Cells[xlRowCount, 1] as excel.Range).Text;
                password1 = (xrng.Cells[xlRowCount, 2] as excel.Range).Text;

                Console.WriteLine(username1);
                Console.WriteLine(password1);

                userName.SendKeys(username1);
                password.SendKeys(password1);

            }
            
            loginButton.Click();

        }

        public static string ReturnTitle()
        {
            return Browser.driver.Title;
        }
    }
}

