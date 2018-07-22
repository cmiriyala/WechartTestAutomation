using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WechartTest.Pages;

namespace WechartTest.Scenarios
{
    class LoginAsAdmin
    {
        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ValidAdminLogin()
        {
           Actions.LoginAsAdmin();
            Thread.Sleep(1000);
            AdminDashboard admin = new AdminDashboard();            
           Assert.AreEqual(Config.Credentials.Valid.admindashboardName,admin.AdminDashboardText.Text);
            Actions.AdminLogout();
        }
        [Test]
        public void InvalidValidAdminLogin()
        {
            Actions.LoginAsAdminInvalid();
            Thread.Sleep(1000);
            AdminLogin loginPage = new AdminLogin();
            Assert.AreEqual(Config.Credentials.Invalid.notloggedin, loginPage.SignIn.GetAttribute("value"));
        }
        [TearDown]
        public void CleanUp()
        {
            
            Thread.Sleep(1000);
            Driver.driver.Quit();
        }

    }
}
