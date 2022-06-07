using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13
{
    class Credit_Acc : ClientMoney<int>
    {
        public Credit_Acc()
        {

        }

        public Credit_Acc(int creditAmount)
        {
            Credit = creditAmount;
        }



    }
}
