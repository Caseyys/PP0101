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
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrid
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Proffesionalitet : Window
    {
        public Proffesionalitet()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Anketa anketa = new Anketa();
            anketa.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Postyplenie g = new Postyplenie();
            g.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Proffesionalitet proffesionalitet = new Proffesionalitet();
            proffesionalitet.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Login login = new Login();  
            login.Show();
            this.Close();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            //распечатать заявление на профессионалитет и соглашения 
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
        //сохранить данные в бд
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Window3 s = new Window3();
            s.Show();
            this.Close();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void KodSpeciality_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void NameSpeciality_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void comboBox8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void comboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.White);
        }

       
    }
}
