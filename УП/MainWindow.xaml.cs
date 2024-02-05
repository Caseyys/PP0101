using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;



//Здесь будут отображаться все данные, которые занесены в бд.
//На вкладке заявление будут отображаться те, кто заполнил заявление(как я поняла на поступление или что-то типо того)
//На вкладке профессионалитет будут отображаться те, кто заполнил заявление именно на профессионалитет
//Ну и соотвественно у анкеты будут те, кто заполнял анкету





namespace DataGrid
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            members.Add(new Member { Number = "1",Ball = "300", Name = "John Doe", Specialization = "Программист", Position = "9 класса" });
          
            membersDataGrid.ItemsSource = members;
            //это было типо для проверки отображения данных
        }

        //я не уверена нужен ли будет тебе этот класс если ты вставляешь данные из бд, если надо можешь удалить
        public class Member
        {
            public string Number { get; set; }
            public string Ball { get; set; }
            public string Name { get; set; }
            public string Specialization { get; set; }
            public string Position { get; set; }
        }
        

        //Это как я поняла для подстветки надписи или хз, но короче думаю лучше не удалять
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //переход на вкладку анкеты
            Anketa n = new Anketa();
            n.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Postyplenie postyplenie = new Postyplenie();
            postyplenie.Show(); this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Proffesionalitet p = new Proffesionalitet();
            p.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //выйти из системы или грубо говоря обратно переход на вкладку входа
            Login f = new Login();
            f.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //закрыть программу
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            //при нажатии на эту кнопку в таблице должны отображатся данные из бд которые заполняли заявление 
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            //при нажатии на эту кнопку в таблице должны отображатся данные из бд которые заполняли заявление на профессионалитет
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            //при нажатии на эту кнопку в таблице должны отображатся данные из бд которые заполняли анкету
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            
            //Кнопка поиска заявки
            //string Search = textBoxFilter.Text.Trim();(вдруг пригодиться)
            //за пояснением см 142 строчку хаml окна
        }
    }
   

}