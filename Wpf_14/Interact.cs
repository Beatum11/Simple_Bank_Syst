using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Module_13;

namespace Wpf_14
{
   public class Interact
    {
        MainWindow mw;
        public delegate string WriteDown(Client client);
        public event WriteDown Alarm;

        public Interact(MainWindow Mw)
        {
            mw = Mw;
        }

        #region Работа со счетами

        /// <summary>
        /// Перевод с одного счета - на другой
        /// </summary>
        /// <param name="clients"></param>
        public void Transfer(List<Client> clients)
        {
            int amount = int.Parse(mw.transferAmount.Text);
            string from = mw.send.Text;
            string to = mw.reciepient.Text;

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].ClientName == from)
                {
                    clients[i].Deposite -= amount;
                }
            }

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].ClientName == to)
                {
                    clients[i].Deposite += amount;
                    MessageBox.Show(Alarm.Invoke(clients[i]));
                }
            }
        }

        /// <summary>
        /// Закрытие аккаунта
        /// </summary>
        /// <param name="clients"></param>
        public void CloseAccounts(List<Client> clients)
        {
            string s = mw.closeClient.Text;

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].ClientName == s)
                {
                    MessageBox.Show(Alarm.Invoke(clients[i]));
                    mw.closeClient.Text = "";
                    clients.Remove(clients[i]);
                }
            }

            mw.Refresh();
        }

        /// <summary>
        /// Преобразование списка клиентов - в массив строк
        /// </summary>
        /// <param name="clients"></param>
        /// <returns></returns>
        public string[] ClientsNotes(List<Client> clients)
        {
            string[] notes = new string[clients.Count];

            for (int i = 0; i < notes.Length; i++)
            {
                notes[i] = clients[i].CreateNote();
            }

            return notes;
        }

        #endregion
    }
}
