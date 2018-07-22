using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechartTest
{
    public static class Config
    {
        public static string BaseURL = "http://testwechart.herokuapp.com";
        public static class Credentials
        {
            public static class Valid
            {
                public static string email = "admin@wechart.com";
                public static string password = "wechartadmin";
                public static string admindashboardName = "Admin Dashboard";
            }
            public static class Invalid
            {

                public static string email = "admin@wechart.com";
                public static string password = "wechartadmi";
                public static string notloggedin = "Sign In";

            }
        }

        public static class EditProfileDetails
        {
            public static class ValidEditProfileDetails
            {
                public static string department = "College of Nursing";
                public static string firstname = "Chethan Kumar";
                public static string lastname = "Miriyala";
                public static string contactnumber = "9999999999";
                public static string success = "Profile updated successfully.";
            }

/*            public static class InValidEditProfileDetails
            {
                public static string department = "College of Nursing";
                public static string firstname = "Chethan Kumar";
                public static string lastname = "Miriyala";
                public static string contactnumber = "9999999999";

            }*/
        }

        public static class UpdatePasswordDetails
        {
            public static class UpdatePasswordValid
            {
                public static string oldpassword = "wechartadminnew";
                public static string newpassword = "wechartadmin";
                public static string confirmnewpassword = "wechartadmin";
                public static string validmessage = "Profile updated successfully.";

            }

            public static class UpdatePasswordInvalid
            {
                public static string invalidoldpassword = "Asdf";
                public static string invalidnewpassword = "dfas";
                public static string invalidconfirmnewpassword = "dfas";
                public static string invalidmessage = "Old Password entered does not match with your current password.";

            }

        }
    }
}
