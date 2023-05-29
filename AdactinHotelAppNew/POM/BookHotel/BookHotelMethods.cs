using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactinHotelAppNew.POM.BookHotel
{
    public partial class BookHotel : BasePage
    {

        public string FirstNameValue {  get; set; }
        public string LastNameValue { get; set; }
        public string BillingAddressValue { get; set; }
        public string CreditCardValue { get; set; }
        public string CreditCardTypeValue { get; set; }
        public string SelectMonthValue { get; set; }
        public string SelectYearValue { get; set; }
        public string CVVNumValue { get; set; }
        public string BookNowValue { get; set; }

        public void AdditionalDetailsOfBookHotel()
        {

            EnterValueByLocator(TXTFirstName, FirstNameValue);
            EnterValueByLocator(TXTLastName, LastNameValue);
            EnterValueByLocator(TXTBillingAddress, BillingAddressValue);
            EnterValueByLocator(TXTCreditCard, CreditCardValue);
            ComboBoxByValue(DDCreditCardType, CreditCardTypeValue);
            ComboBoxByValue(DDSelectMonth, SelectMonthValue);
            ComboBoxByValue(DDSelectYear, SelectYearValue);
            EnterValueByLocator(TXTCVVNum, CVVNumValue);
            ClickOnElement(BTNBookNow);




        }


    }
}
