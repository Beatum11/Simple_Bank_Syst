using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13
{
    public class Bank_Info : ClientMoney<int>
    {

        #region Переменные

        public List<Client> clients = new List<Client>();

        private int clientsNumber;

        #endregion
  
        public int ClientsNumber
        {
            get { return this.clientsNumber; }
            set { clientsNumber = value; }

        }

        public Bank_Info()
        {

        }
    }
}
