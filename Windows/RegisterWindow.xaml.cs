using Bankomat.Model;
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

namespace Bankomat.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void Register_Button_Click(object sender, RoutedEventArgs e)
        {
            string login = Login_Text_Box.Text.Trim();
            string password = Password_Text_Box.Password.Trim();
            string confirmPassword = Confirm_Password_Text_Box.Password.Trim();
            string email = Email_Text_Box.Text.Trim();
            string scoreName = Score_Text_Box.Text.Trim();
            if (login != null && password != null && confirmPassword != null && email != null && scoreName != null && confirmPassword == password)
            {
                if (email.Contains("@") && email.Contains("."))
                {
                    Score score = new Score();
                    using (ApplicationContext applicationContext = new ApplicationContext())
                    {
                        User user = new User();
                        user.Login = login;
                        user.Password = password;
                        user.Email = email;
                        score.Balance = 0;
                        score.Name = scoreName;
                        score.DateTime = DateTime.UtcNow;
                        score.User = user;
                        applicationContext.AddAsync(user);
                        applicationContext.AddAsync(score);
                        applicationContext.SaveChanges();
                    }
                    MainMenuWindow mainMenuWindow = new MainMenuWindow();
                    mainMenuWindow.Show();
                    mainMenuWindow.User_Score_Text_Block.Text = score.Balance.ToString();
                    this.Close();
                }
            }
            else if (login == null)
            {
                Error_Text_Block.Text = "Login is null";
                Error_Text_Block.Visibility = Visibility.Visible;
            }
            else if (password == null)
            {
                Error_Text_Block.Text = "Password is null";
                Error_Text_Block.Visibility = Visibility.Visible;
            }
            else if (confirmPassword == null)
            {
                Error_Text_Block.Text = "Confirm password is null";
                Error_Text_Block.Visibility = Visibility.Visible;
            }
            else if (email == null)
            {
                Error_Text_Block.Text = "Login is null";
                Error_Text_Block.Visibility = Visibility.Visible;
            }
            else if (scoreName == null)
            {
                Error_Text_Block.Text = "Score name is null";
                Error_Text_Block.Visibility = Visibility.Visible;
            }
            else if (password != confirmPassword)
            {
                Error_Text_Block.Text = "Passwords are not equal";
                Error_Text_Block.Visibility = Visibility.Visible;
            }
        }
    }
}
