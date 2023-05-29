using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactinHotelAppNew.POM.BookHotel
{
    public partial class BookHotel
    {
        #region locators
        By TXTFirstName = By.Id("first_name");
        By TXTLastName = By.Id("last_name");
        By TXTBillingAddress = By.Id("address");
        By TXTCreditCard = By.Id("cc_num");
        By DDCreditCardType = By.Id("cc_type");
        By DDSelectMonth = By.Id("cc_exp_month");
        By DDSelectYear = By.Id("cc_exp_year");
        By TXTCVVNum = By.Id("cc_cvv");
        By BTNBookNow = By.Id("book_now");
        #endregion

    }
}
