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
        List<Person> people;
        internal List<Person> People { get => people; set => people = value; }

        PersonContext Db;
        public MainWindow()
        {
            InitializeComponent();
            Db = new PersonContext();

            //Login();
            People = new List<Person>();
            PeopleList.ItemsSource = People;

        }

        private void Login()
        {
            PasswordWindow passwordWindow = new PasswordWindow();

            if (passwordWindow.ShowDialog() == true)
            {
                if (passwordWindow.Password == "12345678")
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

        private void GetFromDb()
        {
            People = Db.People.ToList();
            PeopleList.Items.Refresh();
        }

        //Add Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = NameBox.Text;
                int age = int.Parse(AgeBox.Text);
                string workplace = WorkplaceBox.Text;

                Person person = new Person() { Name = name, Age = age, Workplace = workplace };

                People.Add(person);

                PeopleList.Items.Refresh();
            }
            catch
            {
                MessageBox.Show("Заповніть поля коректно!");
                return;
            }
        }
        //Remove Button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = NameBox.Text;
                int age = int.Parse(AgeBox.Text);
                string workplace = WorkplaceBox.Text;

                Person person = new Person() { Name = name, Age = age, Workplace = workplace };

                People.Remove(person);

                //if ( == true)
                //    MessageBox.Show("Не вдалося видалити об'єкт.");

                PeopleList.Items.Refresh();
            }
            catch
            {
                MessageBox.Show("Заповніть поля коректно!");
                return;
            }
        }



        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Db.SaveChanges();
            Db.Dispose();
        }


    }
}
