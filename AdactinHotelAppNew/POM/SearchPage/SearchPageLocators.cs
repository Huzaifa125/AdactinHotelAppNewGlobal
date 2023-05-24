using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactinHotelAppNew.POM.SearchPage
{
    public partial class SearchPage
    {

        #region locators
        By DdLocation = By.Id("location");
        By DdHotels = By.Id("hotels");
        By DdRoomType = By.Id("room_type");
        By DdNumOfRooms = By.Id("room_nos");
        By DateCheckIn = By.Id("datepick_in");
        By DateCheckOut = By.Id("datepick_out");
        By DdAdultsPerRoom = By.Id("adult_room");
        By DdChildrenPerRoom = By.Id("child_room");
        By BTNSearch = By.Id("Submit");
        #endregion


    }
}
