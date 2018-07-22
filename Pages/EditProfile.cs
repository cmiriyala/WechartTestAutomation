using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WechartTest.Pages
{
    public class EditProfile
    {
        public EditProfile()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.Name, Using = "departmentName")]
        public IWebElement Department { get; set; }

        [FindsBy(How = How.Name, Using = "firstname")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Name, Using = "lastname")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Name, Using = "contactno")]
        public IWebElement ContactNo { get; set; }
        
        [FindsBy(How = How.Id, Using = "password_old")]
        public IWebElement OldPassword { get; set; }

        [FindsBy(How = How.Id, Using = "password_new")]
        public IWebElement NewPassword { get; set; }

        [FindsBy(How = How.Id, Using = "password_new_confirm")]
        public IWebElement ConfirmNewPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#formCheckPassword > div:nth-child(12) > div > button")]
        public IWebElement SaveEditedChanges { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#app > div.container > div > div.row > a")]
        public IWebElement BacktoDashboardFromEditProfile { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#app > div.container > div > div.panel.panel-default > div.panel-heading > h3")]
        public IWebElement EditHeader { get; set; }
        
        [FindsBy(How = How.Id, Using = "success")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.Id, Using = "old_current_mismatch")]
        public IWebElement ErrorMessageInvalid { get; set; }

      
    }
}
