using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13
{
     
    public class CashFlow
    {
        public delegate void WriteDown(Client client);
        public event WriteDown Alarm;

        #region Методы, отвечающие за перевод между счетами

        /// <summary>
        /// Первоначальный текст для перевода денег между клиентами
        /// </summary>
        /// <param name="client_1"></param>
        /// <param name="client_2"></param>
        /// <returns></returns>
        public int ClientsGreetings(Client client_1, Client client_2)
        {
            Console.WriteLine($"\nПеревод будет совершать {client_1.ClientName} на счет" +
                              $" клиента {client_2.ClientName}");

            Console.Write("\nСколько переводим денег: ");
            int sum = Convert.ToInt32(Console.ReadLine());

            return sum;
        }

        /// <summary>
        /// Перевод денег с любого счета
        /// </summary>
        /// <param name="client_1"></param>
        /// <param name="client_2"></param>
        public void Transfer(Client client_1, Client client_2)
        {
            int sum = ClientsGreetings(client_1, client_2);

            Console.Write("\nС какого счета переводим деньги?\nДепозитный или Кредитный: ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Депозитный":
                    client_1.Deposite -= sum;
                    client_2.Deposite += sum;
                    Console.WriteLine("\nУспешно");
                    break;

                case "Кредитный":
                    client_1.Credit -= sum;
                    client_2.Credit += sum;
                    Console.WriteLine("\nУспешно");
                    break;
            }

            Alarm.Invoke(client_1);
        }

        #endregion




        /// <summary>
        /// Информация о клиентах
        /// </summary>
        /// <param name="clients"></param>
        public void Show_ClientsInfo(List<Client> clients)
        {
            int a = 0;

            foreach (var client in clients)
            {
                Console.WriteLine($"№{a++} Клиент: {client.ClientName} " +
                                  $"Сумма на депозитном счете: {client.Deposite} " +
                                  $" Сумма на кредитном счете: {client.Credit}");
            }
        }


        #region Работаем непосредственно со счетами

        /// <summary>
        /// Открываем новые счета для нового клиента
        /// </summary>
        /// <returns></returns>
        public Client OpenAccount()
        {
            Credit_Acc creditAccount = new Credit_Acc();
            Deposite_Acc depositeAccount = new Deposite_Acc();

            Console.Write($"\nИмя клиента: ");
            string name = Console.ReadLine();

            Console.Write($"\nСумма на депозитном счете: ");
            depositeAccount.Deposite = int.Parse(Console.ReadLine());
            int depositeAmount = depositeAccount.Deposite;

            Console.Write($"\nСумма на кредитном счете: ");
            creditAccount.Credit = int.Parse(Console.ReadLine());
            int creditAmount = creditAccount.Credit;

            Client newClient = new Client(name, depositeAmount, creditAmount);
            Alarm.Invoke(newClient);
            return newClient;


        }

        /// <summary>
        /// Закрываем конкретный счет
        /// </summary>
        /// <param name="clients"></param>
        public void CloseAccount(List<Client> clients)
        {
            Console.Write($"\nНужно закрыть счет клиента под номером: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write($"Выбран клиент по имени: {clients[num].ClientName} " +
                          $"Какой счет закрыть? Депозитный или кредитный: ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Депозитный":
                    clients[num].Deposite = 0;
                        break;

                case "Кредитный":
                    clients[num].Credit = 0;
                    break;
            }

            Alarm.Invoke(clients[num]);
        }

        #endregion



    }
}
