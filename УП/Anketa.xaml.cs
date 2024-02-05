using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace DataGrid
{
    public partial class Anketa : Window
    {
        public Anketa()
        {
            InitializeComponent();
        }

        //Это как я поняла для подстветки надписи или хз,
        //но короче не удалять
        //(пиздить надо уметь, а я не особо,
        //соу удачи писать код к этой параше)
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
   

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(); 
            mainWindow.Show();
            this.Close();
            //переход на вкладку заявления, где будут отображаться данные из бд
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Anketa anketa = new Anketa();
            anketa.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Postyplenie postyplenie = new Postyplenie();
            postyplenie.Show(); this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           Proffesionalitet pro = new Proffesionalitet();
            pro.Show(); this.Close();   
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Close();
            //выйти из системы типо
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            //ну тут концепция такая, что жмешь на кнопку и открывается вордовский файл и там уже в ворде жмешь на распечатать
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            //Сохранить данные в бд
            //На самом деле я немного хз как это реализовать, потому что как с поискам в заявках(string Search = textBoxFilter.Text.Trim()) он не хочет

        }
    }
}
