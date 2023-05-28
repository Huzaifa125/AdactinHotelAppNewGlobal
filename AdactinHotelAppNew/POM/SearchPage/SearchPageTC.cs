using AdactinHotelAppNew.POM.LoginPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdactinHotelAppNew.POM.SearchPage
{
    [TestClass]
    public class SearchPageTC : Execution
    {
        SearchPage searchPage = new SearchPage();

        LoginPageTC loginPage = new LoginPageTC();

        [TestMethod]
        public void SearchHotelEnterAllFields()
        {

            loginPage.LoginWithValidUsernameValidPassword();

            searchPage.LocationValue = "Brisbane";
            searchPage.HotelValue = "Hotel Sunshine";
            searchPage.RoomTypeValue = "Double";
            searchPage.NumOfRoomsValue = "4";
            searchPage.DateCheckInValue = "24/05/2023";
            searchPage.DateCheckOutValue = "26/05/2023";
            searchPage.AdultsPerRoomValue = "3";
            searchPage.ChildrenPerRoomValue = "3";

            searchPage.SearchHotel();


        }

        //[TestMethod]
        //public void SearchHotelEnterAllFields()
        //{

        //    loginPage.LoginWithValidUsernameValidPassword();

        //    searchPage.LocationValue = "Brisbane";
        //    searchPage.HotelValue = "Hotel Sunshine";
        //    searchPage.RoomTypeValue = "Double";
        //    searchPage.NumOfRoomsValue = "4";
        //    searchPage.DateCheckInValue = "24/05/2023";
        //    searchPage.DateCheckOutValue = "26/05/2023";
        //    searchPage.AdultsPerRoomValue = "3";
        //    searchPage.ChildrenPerRoomValue = "3";

        //    searchPage.SearchHotel();


        //}
    }
}
