using AdactinHotelAppNew.POM.LoginPage;
using AdactinHotelAppNew.POM.SearchPage;
using AdactinHotelAppNew.POM.SelectPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdactinHotelAppNew.POM.BookHotel
{
    [TestClass]
    public class BookHotelTC : Execution
    {

        SelectPageTC selectPage = new SelectPageTC();
        BookHotel bookHotel = new BookHotel();
        


        [TestMethod]
        public void FinalBooking()
        {

            selectPage.ClickOnRadioButton();



            bookHotel.FirstNameValue = "Huzaifa";
            bookHotel.LastNameValue = "Saad";
            bookHotel.BillingAddressValue = "r550 block";
            bookHotel.CreditCardValue = "2156465121564561";
            bookHotel.CreditCardTypeValue = "VISA";
            bookHotel.SelectMonthValue = "4";
            bookHotel.SelectYearValue = "2022";
            bookHotel.CVVNumValue = "2132";

            bookHotel.AdditionalDetailsOfBookHotel();


        }
    }
}
