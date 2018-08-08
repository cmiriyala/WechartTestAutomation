using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using WechartTest.Pages;

namespace WechartTest.Scenarios
{
    class AdminEditProfile
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            Actions.LoginAsAdmin();
            NavigateTo.EditProfile();
    
        }

        [Test]
        public void EditProfileValid()
        {
            Actions.EditProfileValid();
            EditProfile editProfile = new EditProfile();
            Assert.AreEqual(editProfile.SuccessMessage.Text,Config.EditProfileDetails.ValidEditProfileDetails.success);
        }
        [Test]
        public void UpdatepasswordValid()
        {
            Actions.UpdatePasswordValid();
            EditProfile editProfile = new EditProfile();
            Assert.AreEqual(editProfile.SuccessMessage.Text, Config.UpdatePasswordDetails.UpdatePasswordValid.validmessage);
        }
        [Test]
        public void UpdatepasswordInValid()
        {
            Actions.UpdatePasswordInValid();
            EditProfile editProfile = new EditProfile();
            Assert.AreEqual(editProfile.ErrorMessageInvalid.Text, Config.UpdatePasswordDetails.UpdatePasswordInvalid.invalidmessage);
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Actions.AdminLogout();
            
            Driver.driver.Quit();
        }
    }
}
