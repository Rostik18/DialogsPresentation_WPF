using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DialogsPresentation_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //Login();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void Login()
        {
            PasswordWindow passwordWindow = new PasswordWindow();

            if (passwordWindow.ShowDialog() == true)
            {
                if (passwordWindow.Password == "1234")
                    MessageBox.Show("Авторизацiя пройдена.");
                else
                {
                    MessageBox.Show("Неправильний пароль!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Авторизацiя не пройдена.");
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TaskWindow taskWindow = new TaskWindow();

            //taskWindow.Param = 5;
            //taskWindow.Owner = this;

            taskWindow.Show();


            // this.OwnedWindows - колекція всіх залежних вікон.
        }
    }
}
