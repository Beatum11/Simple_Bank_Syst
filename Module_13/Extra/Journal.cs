using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13
{
   public class Journal
    {
        public string MessageToJournal(Client client)
        {
            string act = $"Действие совершено в: {DateTime.Now.ToShortTimeString()}" +
                         $" Произведена работа с клиентом {client.ClientName}";
            return act;
        }

    }
}
