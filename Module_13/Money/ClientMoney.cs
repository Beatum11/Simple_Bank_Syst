using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13
{
   public abstract class ClientMoney<T>
    {
        private T deposite;
        private T credit;


        #region Свойства

        public T Deposite
        {
            get { return this.deposite; }
            set { deposite = value; }
        }

        public T Credit
        {
            get { return this.credit; }
            set { credit = value; }
        }

        #endregion 

    }
}
