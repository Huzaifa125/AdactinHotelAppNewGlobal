using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdactinHotelAppNew.POM.LoginPage
{
    [TestClass]
    public class LoginPageTC : Execution
    {

        LoginPage loginPage = new LoginPage();

        [TestMethod]
        [Owner("Huzaifa")]
        [Description("")]
        public void LoginWithValidUsernameValidPassword()
        {
            loginPage.username = "saaddash";
            loginPage.password = "123456";
            loginPage.url = "https://adactinhotelapp.com/index.php";

            loginPage.Login();

        }
    }
}
