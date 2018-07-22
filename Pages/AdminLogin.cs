

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WechartTest.Pages
{
    public class AdminLogin
    {
        public AdminLogin()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Password { get; set; }  

        [FindsBy(How = How.XPath, Using = "//*[@value=\"Sign In\"]")]
        public IWebElement SignIn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > form > div:nth-child(4) > div > a:nth-child(2)")]
        public IWebElement ForgotPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > form > div:nth-child(4) > div > a:nth-child(4)")]
        public IWebElement Register { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > div.form-group > div > a")]
        public IWebElement About { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > div.col-md-1.col-md-offset-5 > a")]
        public IWebElement Contact { get; set; }




    }
}
