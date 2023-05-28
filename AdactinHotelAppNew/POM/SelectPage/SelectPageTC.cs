using AdactinHotelAppNew.POM.LoginPage;
using AdactinHotelAppNew.POM.SearchPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdactinHotelAppNew.POM.SelectPage
{
    [TestClass]
    public class SelectPageTC : Execution
    {
        SelectPage selectPage = new SelectPage();
        LoginPageTC loginPage = new LoginPageTC();
        SearchPageTC searchPage = new SearchPageTC();

        [TestMethod]
        public void ClickOnRadioButton()
        {

            loginPage.LoginWithValidUsernameValidPassword();
            searchPage.SearchHotelEnterAllFields();

            selectPage.ClickOnSelectHotelRadioButton();


        }
    }
}
