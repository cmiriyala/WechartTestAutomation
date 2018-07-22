using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal.Execution;
using WechartTest.Pages;

namespace WechartTest.Scenarios
{
      class VerifyDashboardDetails
      {
          private AdminDashboard adminDashboard;


        [OneTimeSetUp]
        public void Initialize()
        {
    
            Actions.InitializeDriver();
            Actions.LoginAsAdmin();
            Thread.Sleep(1000);
        }



        [Test]
        public void NavbarTest()
        {
         adminDashboard = new AdminDashboard();
            Thread.Sleep(1000);
            if (adminDashboard.Logo.Enabled && adminDashboard.AdminName.Enabled)
            {
                adminDashboard.AdminName.Click();
                    if (adminDashboard.EditProfile.Enabled && adminDashboard.AdminLogout.Enabled)
                    {
                      Console.WriteLine("Navigation bar is enabled in Admin's Dashboard");
                    }
            }
        }
        [Test]
        public void AllButtonsTest()
        {
           
           adminDashboard = new AdminDashboard();

            if (adminDashboard.RemoveEmails.Enabled && adminDashboard.ConfigureModules.Enabled && adminDashboard.ManageMedia.Enabled && adminDashboard.AddStudentEmail.Enabled && adminDashboard.AddInstructorEmail.Enabled)
            {
             
                 Console.WriteLine("All Buttons on Admin Dashboard are enabled");
                            
            }

        }
        [Test]
        public void TablesTest()
        {
           
         adminDashboard = new AdminDashboard();

            if (adminDashboard.StudentEmailTableName.Enabled && adminDashboard.InstructorEmailTableName.Enabled)
            {
                Console.WriteLine("TAbles Exisit for Student and Instructor");
            }

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
