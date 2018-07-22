

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WechartTest.Pages
{
   public  class AdminDashboard
    {
        public AdminDashboard()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        [FindsBy(How = How.CssSelector, Using = "#lblAdminHeader")]
        public IWebElement AdminDashboardText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#navigation_bar > div > div.navbar-header > a > img")]
        public IWebElement Logo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#navigation_bar > div > div:nth-child(2) > ul.nav.navbar-nav.navbar-right > li > a")]
        public IWebElement AdminName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#navigation_bar > div > div:nth-child(2) > ul.nav.navbar-nav.navbar-right > li > ul > li:nth-child(1) > a")]
        public IWebElement EditProfile { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#navigation_bar > div > div:nth-child(2) > ul.nav.navbar-nav.navbar-right > li > ul > li:nth-child(2) > a")]
        public IWebElement AdminLogout { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#app > div.container > div:nth-child(3) > div.col-md-2.col-md-offset-1 > a")]
        public IWebElement RemoveEmails { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#app > div.container > div:nth-child(3) > div.col-md-8 > a.btn.btn-primary")]
        public IWebElement ConfigureModules { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#app > div.container > div:nth-child(3) > div.col-md-8 > a.btn.btn-success")]
        public IWebElement ManageMedia { get; set; }

        [FindsBy(How = How.Id, Using = "addStudentEmails")]
        public IWebElement AddStudentEmail { get; set; }

        [FindsBy(How = How.Id, Using = "addInstructorEmails")]
        public IWebElement AddInstructorEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#app > div.container > div:nth-child(5) > div > div > div.panel-heading > h4")]
        public IWebElement StudentEmailTableName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#app > div.container > div:nth-child(7) > div > div > div.panel-heading > h4")]
        public IWebElement InstructorEmailTableName { get; set; }

/*        [FindsBy(How = How.CssSelector, Using = "#student_minus_delete > i")]
        public IWebElement DeleteRegisteredStudent { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#student_minus_delete > i")]
        public IWebElement DeleteRegisteredInstructor { get; set; }*/
    }
}
