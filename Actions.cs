using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using WechartTest.Pages;
using WechartTest.Scenarios;

namespace WechartTest
{
   public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(10);


        }
        public static void LoginAsAdmin()
        {
           AdminLogin login = new AdminLogin();
            login.Email.SendKeys(Config.Credentials.Valid.email);
            login.Password.SendKeys(Config.Credentials.Valid.password);
           login.SignIn.Click();
            
        }
        public static void LoginAsAdminInvalid()
        {
            AdminLogin login = new AdminLogin();
            login.Email.SendKeys(Config.Credentials.Invalid.email);
            login.Password.SendKeys(Config.Credentials.Invalid.password);
            login.SignIn.Click();

        }

        public static void EditProfileValid()
        {
            EditProfile admineditProfile = new EditProfile();
            SelectElement Depatment = new SelectElement(admineditProfile.Department);
            Depatment.SelectByValue(Config.EditProfileDetails.ValidEditProfileDetails.department);
            admineditProfile.FirstName.Clear();
            admineditProfile.FirstName.SendKeys(Config.EditProfileDetails.ValidEditProfileDetails.firstname);
            admineditProfile.LastName.Clear();
            admineditProfile.LastName.SendKeys(Config.EditProfileDetails.ValidEditProfileDetails.lastname);
            admineditProfile.ContactNo.Clear();
            admineditProfile.ContactNo.SendKeys(Config.EditProfileDetails.ValidEditProfileDetails.contactnumber);
            admineditProfile.SaveEditedChanges.Click();
        }
        /*public static void EditProfileInValid()
        {
            EditProfile admineditProfile = new EditProfile();
            SelectElement Depatment = new SelectElement(admineditProfile.Department);
            Depatment.SelectByValue();
            admineditProfile.FirstName.SendKeys();
            admineditProfile.LastName.SendKeys();
            admineditProfile.ContactNo.SendKeys();

        }*/
        public static void UpdatePasswordValid()
        {
            EditProfile changepassword = new EditProfile();
            changepassword.OldPassword.Clear();
            changepassword.OldPassword.SendKeys(Config.UpdatePasswordDetails.UpdatePasswordValid.oldpassword);
            changepassword.NewPassword.Clear();
            changepassword.NewPassword.SendKeys(Config.UpdatePasswordDetails.UpdatePasswordValid.newpassword);
            changepassword.ConfirmNewPassword.Clear();
            changepassword.ConfirmNewPassword.SendKeys(Config.UpdatePasswordDetails.UpdatePasswordValid.confirmnewpassword);
            changepassword.SaveEditedChanges.Click();
        }
        public static void UpdatePasswordInValid()
        {
            EditProfile changepassword = new EditProfile();
            changepassword.OldPassword.Clear();
            changepassword.OldPassword.SendKeys(Config.UpdatePasswordDetails.UpdatePasswordInvalid.invalidoldpassword);
            changepassword.NewPassword.Clear();
            changepassword.NewPassword.SendKeys(Config.UpdatePasswordDetails.UpdatePasswordInvalid.invalidnewpassword);
            changepassword.ConfirmNewPassword.Clear();
            changepassword.ConfirmNewPassword.SendKeys(Config.UpdatePasswordDetails.UpdatePasswordInvalid.invalidconfirmnewpassword);
            changepassword.SaveEditedChanges.Click();
        }

        public static void AdminLogout()
        {
            AdminDashboard admin = new AdminDashboard();
            admin.AdminName.Click();
            admin.AdminLogout.Click();
        }
    }
}
