using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework2507
{
    public static class HomePage
    {
        public static string title;

        public static void CanGoToHomePage()
        {
            Browser.GoToURL();
        }

        public static string VerifyPageTitle()
        {
            title = Browser.ReturnPageTitle();
            return title;
        }

        public static void CloseHomeBrowser()
        {
            Browser.CloseBrowser();
        }


    }
}
