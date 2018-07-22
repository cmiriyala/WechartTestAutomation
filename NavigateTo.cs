using WechartTest.Pages;

namespace WechartTest
{
    public static class NavigateTo
    {
        private static AdminLogin adminLogin = new AdminLogin();
        private static AdminDashboard adminDashboard = new AdminDashboard();

        public static void ForgotPassword()
        {
            adminLogin.ForgotPassword.Click();
        }
        public static void Register()
        {
            adminLogin.Register.Click();
        }
        public static void AboutUs()
        {
            adminLogin.About.Click();
        }
        public static void ContactUs()
        {
            adminLogin.Contact.Click();
        }
        public static void EditProfile()
        {
            adminDashboard.AdminName.Click();
            adminDashboard.EditProfile.Click();
        }
        public static void RemoveEmail()
        {
            adminDashboard.RemoveEmails.Click();
            
        }
        public static void ConfigureModules()
        {
            adminDashboard.ConfigureModules.Click();

        }

        public static void ManageMedia()
        {
            adminDashboard.ManageMedia.Click();

        }
        public static void AddStudentEmail()
        {
            adminDashboard.AddStudentEmail.Click();

        }
        public static void AddInstructorEmail()
        {
            adminDashboard.AddInstructorEmail.Click();

        }
    }
}
