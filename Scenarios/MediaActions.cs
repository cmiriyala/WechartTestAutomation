using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WechartTest.Pages;

namespace WechartTest.Scenarios
{
    class MediaActions
    {
        [OneTimeSetUp]
        public void Initializer()
        {
            Actions.InitializeDriver();
            Actions.LoginAsAdmin();
            NavigateTo.ManageMedia();

        }

        [Test, Order(1)]
        public void VerifyMediaPage()
        {
            ManageMedia mediaelement = new ManageMedia();
            Assert.AreEqual(Config.MediaHeader, mediaelement.MediaHeader.Text);

        }
        [Test, Order(2)]
        public void VerifyLink()
        {
            ManageMedia mediaelement = new ManageMedia();
            mediaelement.FirstMediaLink.Click();
            var browserTabs = Driver.driver.WindowHandles;
            Driver.driver.SwitchTo().Window(browserTabs[1]);
            String currentURL = Driver.driver.Url;
            Console.WriteLine(currentURL);
            Assert.AreEqual(Config.MediaLinkTest, currentURL);
            
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
