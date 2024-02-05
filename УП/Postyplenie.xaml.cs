using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataGrid
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Postyplenie : Window
    {
        public Postyplenie()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Anketa n = new Anketa();
            n.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Postyplenie postyplenie = new Postyplenie();
            postyplenie.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Proffesionalitet g = new Proffesionalitet();
            g.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            //распечатать заявление и согласие на обработку данных
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            //сохранить данные в бд
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            this.Close();
        }
    }
}
