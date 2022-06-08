using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13
{
    public class Program
    {
        #region Переменные
        private static List<Client> clients;
        private static CashFlow cf;
        private static Bank_Info bank = new Bank_Info();
        private static Journal j;
        private static Interaction i;
        #endregion

        public static void WakeUp()
        {
            clients = new List<Client>()
        {
            new Client("Олег Н.", 23000, 68000),
            new Client("Иван В.", 12000, 10000),
            new Client("Афанасий К.", 32500, 12600)
        };
            cf = new CashFlow();
            j = new Journal();
            i = new Interaction();
        }


        static void Main(string[] args)
        {
            WakeUp();

            cf.Transfer(clients[0], clients[1]);

            Console.ReadKey();
        }
    }
}
