using Bankomat.Model;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        private void Add_Money_Button_Click(object sender, RoutedEventArgs e)
        {
            AddMoneyWindow addMoneyWindow = new AddMoneyWindow();
            addMoneyWindow.User_Id_Block.Text = User_Id_Block.Text.Trim();
            addMoneyWindow.ShowDialog();
            Get_Cheque_Button_Click(sender, e);
            //this.Close();
        }

        private void Get_Money_Button_Click(object sender, RoutedEventArgs e)
        {
            GetMoneyWindow getMoneyWindow = new GetMoneyWindow();
            getMoneyWindow.User_Id_Block.Text = User_Id_Block.Text.Trim();
            getMoneyWindow.ShowDialog();
            Get_Cheque_Button_Click(sender, e);
            //this.Close();
        }

        private void Send_Money_Button_Click(object sender, RoutedEventArgs e)
        {
            int userId = Int32.Parse(User_Id_Block.Text.Trim());
            SendMoneyWindow sendMoneyWindow = new SendMoneyWindow();
            sendMoneyWindow.User_Id_Block.Text = User_Id_Block.Text.Trim();
            sendMoneyWindow.Show();
            using(ApplicationContext applicationContext = new ApplicationContext())
            {
                var users = applicationContext.Users.Where(u => u.Id != userId).ToList();
                foreach(var user in users)
                {
                    sendMoneyWindow.User_Login_Combo_Box.Items.Add(user.Login);
                }
            }
            this.Close();
        }

        private void Get_Cheque_Button_Click(object sender, RoutedEventArgs e)
        {
            using(ApplicationContext applicationContext = new ApplicationContext())
            {
                string userId = User_Id_Block.Text.Trim();
                string path = @"C:\Users\fedya\Desktop\Проекты\C#_VS2022\Bankomat\Cheques\" + userId;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                int userIntId = Int32.Parse(userId);
                string title = "\tCheque";
                var getterLogin = applicationContext.Users.Where(u => u.Id == userIntId).Select(user_login => user_login.Login);
                string userLogin = null;
                foreach (var login in getterLogin)
                {
                    userLogin = "Login is: " + login;
                }
                string dateAndTime = "Current date of operation is: " + DateTime.Now.ToString();
                var getterBalance = applicationContext.Scores.Where(user => user.UserId == userIntId).Select(s => s.Balance);
                string currentBalance = null;
                foreach (var balance in getterBalance)
                {
                    currentBalance = "Current balance is: " + balance.ToString();
                }
                string ending = "\tHope to see you one more time";
                string[] strings = {title, userLogin, dateAndTime, currentBalance,  ending};
                string dateAndTimeForFileName = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss").Trim();
                if (dateAndTimeForFileName.Contains(" "))
                {
                    int getSpaceIndex = dateAndTimeForFileName.IndexOf(" ");
                    dateAndTimeForFileName = dateAndTimeForFileName.Remove(getSpaceIndex, 1);
                }
                string filepath = path + "\\" + dateAndTimeForFileName + "_Cheque.txt";
                File.WriteAllLinesAsync(filepath,strings);
            }
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Add_Additional_Information_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
