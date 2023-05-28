using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactinHotelAppNew.POM.SelectPage
{
    public partial class SelectPage : BasePage
    {

        public void ClickOnSelectHotelRadioButton()
        {

            ClickOnElement(RDBtnSelectHotel);

            ClickOnElement(BTNsubmit);

        }



    }
}
