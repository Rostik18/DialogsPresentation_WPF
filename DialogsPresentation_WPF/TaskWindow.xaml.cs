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
using System.Windows.Shapes;

namespace DialogsPresentation_WPF
{
    /// <summary>
    /// Логика взаимодействия для TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {
        public double Param { get; set; }

        public TaskWindow()
        {
            InitializeComponent();
            Param = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MesgLab.Content = "";
            double num1;
            double num2;

            try
            {
                num1 = Convert.ToDouble(numb1.Text);
                num2 = Convert.ToDouble(numb2.Text);

                numb3.Text = (num1 + num2 + Param).ToString();
            }
            catch
            {
                MesgLab.Content = "Щось нетак...";
            }
        }

        //public void ChageOwnerBackground()
        //{
        //    this.Owner.Background = new SolidColorBrush(Colors.Red);
        //}
    }
}
