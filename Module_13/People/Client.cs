using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13
{
    public class Client : Bank_Info
    {

        private string clientName;

        public string ClientName
        {
            get { return this.clientName; }

            set { this.clientName = value; }
        }

        #region Конструкторы

        public Client()
        {

        }

        public Client(string clientName, int depositeAcc, int creditAcc)
        {
            ClientName = clientName;
            Deposite = depositeAcc;
            Credit = creditAcc;
        }

        #endregion

        public string CreateNote()
        {
            string s = $"Имя клиента: {ClientName} \nНа депозитном счете: {Deposite} руб." +
                       $" \nНа кредитном счете: {Credit} руб." +
                       $"\n------";
            return s;

        }
    }
}
