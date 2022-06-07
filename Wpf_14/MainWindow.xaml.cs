using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Module_13;

namespace Wpf_14
{

    public partial class MainWindow : Window
    {
        public List<Client> clients;
        Interact inter;
        Journal j;

        #region Инициализация полей

        public void Wake()
        {
            clients = new List<Client>()
           {
               new Client("Олег Н.", 20000, 15000),
               new Client("Иван Л.", 13000, 21500),
               new Client("Дмитрий Д.", 24500, 33000),
           };
            j = new Journal();
            inter = new Interact(this);
            inter.Alarm += j.MessageToJournal;
        }
        public void Refresh()
        {
            string[] clientsNotes = inter.ClientsNotes(clients);
            list.ItemsSource = clientsNotes;
        }

        #endregion


        public MainWindow()
        {
            InitializeComponent();
            Wake();

            Refresh();
        }


        #region Функционал кнопок

        //Добавление нового клиента
        private void addClient_Click(object sender, RoutedEventArgs e)
        {
            clients.Add(new Client(addName.Text, int.Parse(addDeposite.Text),
                                    int.Parse(addCredit.Text)));

            Refresh();

            addName.Text = "";
            addDeposite.Text = "";
            addCredit.Text = "";
        }

        //Переводим деньги с одного счета - на другой
        private void transferButton_Click(object sender, RoutedEventArgs e)
        {
            inter.Transfer(clients);
            Refresh();

            transferAmount.Text = "";
            send.Text = "";
            reciepient.Text = "";
            
        }

        //Закрываем счета клиента
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            inter.CloseAccounts(clients);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #endregion


    }
}