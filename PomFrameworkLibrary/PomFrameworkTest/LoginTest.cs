using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PomFrameworkLib;

namespace PomFrameworkTest
{
    
        [TestFixture()]
        public class LoginTest : BaseTest
        {
               
                          [Test(), Ignore("")]
            public void Is_Login_Successful()
            {

            Console.WriteLine(LoginPage.ReturnTitle());
            Assert.AreEqual("Dashboard - Dispatching System", LoginPage.ReturnTitle());


        }


        }
    }
