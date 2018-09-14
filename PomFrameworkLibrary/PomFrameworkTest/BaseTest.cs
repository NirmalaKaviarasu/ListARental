using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PomFrameworkLib;

namespace PomFrameworkTest
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public static void Init()
        {
            Browser.Initialize();
            LoginPage.GoTo();
            LoginPage.CanLogin();

        }




        [OneTimeTearDown]
        public void Close()
        {
            Browser.Close();

        }


    }
}

