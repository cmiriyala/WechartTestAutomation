using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WechartTest.Pages
{
    class ManageMedia
    {
        public ManageMedia()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#app > div:nth-child(7) > div > div > div.panel.panel-default > div.panel-heading > h4")]
        public IWebElement MediaHeader { get; set; }
    }
}
