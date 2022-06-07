using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13
{
    class Interaction
    {
        CashFlow cf = new CashFlow();
        public bool flag = true;

        /// <summary>
        /// Метод, отвечающий за начало программы и выбор пользователя
        /// </summary>
        /// <returns></returns>
        public void Interact()
        {
            Console.WriteLine($"\nДобро пожаловать! Список действий:" +
                $"\nПеревод денег между счетами - ПМ" +
                $"\nИнформация о клиентах - ИК" +
                $"\nЗарегестрировать нового клиента - НК" +
                $"\nЗакрыть счет - ЗС" +
                $"\nВыйти из программы - В");

            //Console.Write("\nЧто выберем: ");
            //string s = Console.ReadLine();
            //return s;

        }

        
        /// <summary>
        /// Метод, отвечающий за определенные действия,
        /// которые будут совершаться в программе
        /// </summary>
        /// <param name="choise"></param>
        public void Actions(List<Client> clients)
        {
            
                Console.Write("\nЧто выберем: ");
                string choise = Console.ReadLine();

                switch (choise)
                {
                    //Перевод денег между счетами
                    case "ПМ":
                        cf.Transfer(clients[0], clients[1]);
                        return;

                    //Информация о клиентах
                    case "ИК":
                        cf.Show_ClientsInfo(clients);
                        return;

                    //Регистрация нового клиента
                    case "НК":
                        clients.Add(cf.OpenAccount());
                        return;

                    //Закрытие счета
                    case "ЗС":
                        cf.CloseAccount(clients);
                        return;

                    case "В":
                    flag = false;
                        return;

                    default:
                        return;
                }
               
            

        }

    }
}
