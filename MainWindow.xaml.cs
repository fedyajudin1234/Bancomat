using Bankomat.Model;
using Bankomat.Windows;
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

namespace Bankomat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Enter_Button_Click(object sender, RoutedEventArgs e)
        {
            using(ApplicationContext applicationContext = new ApplicationContext())
            {
                string login = Login_Text_Box.Text.Trim();
                string password = Password_Text_Box.Password.ToString().Trim();
                var users = applicationContext.Users.ToList();
                if(users.Count > 0)
                {
                    foreach (var user in users)
                    {
                        int currentUserId = user.Id;
                        if (login != null && password != null && user.Login == login && user.Password == password)
                        {
                            MainMenuWindow mainMenuWindow = new MainMenuWindow();
                            mainMenuWindow.Show();
                            var value = from s in applicationContext.Scores
                                       where s.UserId == currentUserId
                                       select s.Balance.ToString();
                            foreach(string item in value)
                            {
                                mainMenuWindow.User_Score_Text_Block.Text = item;
                            }
                            mainMenuWindow.User_Id_Block.Text = currentUserId.ToString();
                            this.Close();
                        }
                    }
                }
                else if(login == null)
                {
                    Error_Text_Block.Text = "Login is null";
                    Error_Text_Block.Visibility = Visibility.Visible;
                }
                else if (password == null)
                {
                    Error_Text_Block.Text = "Password is null";
                    Error_Text_Block.Visibility = Visibility.Visible;
                }
            }
        }

        private void Register_Button_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            this.Close();
        }
    }
}
