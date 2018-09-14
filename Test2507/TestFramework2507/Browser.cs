using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;


public class Browser
{
    public static string url = "http://www.industryconnect.io";



    public static IWebDriver driver = new ChromeDriver();

    public static void GoToURL()
    {
        driver.Url = url;
    }

    public static string ReturnPageTitle()
    {
        return driver.Title;
    }

    public static void CloseBrowser()
    {
        driver.Close();
        driver.Dispose();

    }
}