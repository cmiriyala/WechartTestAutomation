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
        [SetUp]
        public void Initializer()
        {
            Actions.InitializeDriver();
            Actions.LoginAsAdmin();
            NavigateTo.ManageMedia();

        }

        [Test]
        public void InsertNewMedia()
        {
            ManageMedia mediaelement = new ManageMedia();
            Assert.AreEqual(Config.MediaHeader, mediaelement.MediaHeader.Text);

        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Close();
        }
    }
}
