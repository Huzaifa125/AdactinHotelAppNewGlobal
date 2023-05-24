using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactinHotelAppNew.POM.SearchPage
{
    public partial class SearchPage : BasePage
    {

        #region Properties
        public string LocationValue { get; set; }
        public string HotelValue { get; set; }
        public string RoomTypeValue { get; set; }
        public string NumOfRoomsValue { get; set; }
        public string DateCheckInValue { get; set; }
        public string DateCheckOutValue { get; set; }
        public string AdultsPerRoomValue { get; set; }
        public string ChildrenPerRoomValue { get; set; }
        #endregion

        public void SearchHotel()
        {
            
            ComboBoxByValue(DdLocation, LocationValue);
            ComboBoxByValue(DdHotels, HotelValue);
            ComboBoxByValue(DdRoomType, RoomTypeValue);
            ComboBoxByValue(DdNumOfRooms, NumOfRoomsValue);

            EnterValueByLocator(DateCheckIn, DateCheckInValue);
            EnterValueByLocator(DateCheckOut, DateCheckOutValue);

            ComboBoxByValue(DdAdultsPerRoom, AdultsPerRoomValue);
            ComboBoxByValue(DdChildrenPerRoom, ChildrenPerRoomValue);

            ClickOnElement(BTNSearch);


        }


    }
}
