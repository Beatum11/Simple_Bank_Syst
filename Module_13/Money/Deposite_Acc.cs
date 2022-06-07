using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13
{
    class Deposite_Acc : ClientMoney<int>
    {

        public Deposite_Acc()
        {

        }

        public Deposite_Acc(int depositeAmount)
        {
            Deposite = depositeAmount;
        }


    }
}
