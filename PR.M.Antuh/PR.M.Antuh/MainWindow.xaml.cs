using ConsoleAuthorizations.Module;
using HashPasswords;
using PR.M.Antuh.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace PR.M.Antuh
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Model.Entities s_entities;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_authorization_Click(object sender, RoutedEventArgs e)
        {
            string login = tb_login.Text;
            string password = tb_password.Password;
            HashPassword hash = new HashPassword();
            password = hash.HashPassw(password);
            Entities m = new Entities();
            var authorization = m.Authorizations;


            var user = authorization.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
            if (user != null)
            {
                int idpost = user.Staff.ID_Post;
                switch (idpost)
                {
                    case 1:
                        Window1 f = new Window1();
                        f.Show();
                        break;
                    case 2:
                        Window2 f2 = new Window2();
                        f2.Show();
                        break;
                    case 3:
                        Window3 f3 = new Window3();
                        f3.Show();
                        break;
                    case 4:
                        Window4 f4 = new Window4();
                        f4.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }

        private static Model.Entities getContext()
        {
            if (s_entities == null)
            {
                s_entities = new Model.Entities();
            }
            return s_entities;
        }
    }
}




