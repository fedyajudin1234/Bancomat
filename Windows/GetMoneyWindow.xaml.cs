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
    /// Логика взаимодействия для GetMoneyWindow.xaml
    /// </summary>
    public partial class GetMoneyWindow : Window
    {
        List<Button> buttons = new List<Button>();
        string userSum = string.Empty;
        int counter = 0;
        public GetMoneyWindow()
        {
            InitializeComponent();
        }

        private void User_Sum_Click(object sender, RoutedEventArgs e)
        {
            int userId = Int32.Parse(User_Id_Block.Text.Trim());
            using(ApplicationContext applicationContext = new ApplicationContext())
            {
                var score = applicationContext.Scores.Where(s => s.UserId == userId);
                foreach(var balance in score)
                {
                    userSum = balance.Balance.ToString();
                }
                Sum_Text_Box.Text = userSum;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Sum_Text_Box.Text += button.Content;
            buttons.Add(button);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (buttons.Count > 0)
            {
                buttons.RemoveAt(buttons.Count - 1);
                Sum_Text_Box.Clear();
                foreach (var button in buttons)
                {
                    Sum_Text_Box.Text += button.Content;
                }
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Sum_Text_Box.Clear();
            buttons.Clear();
        }

        private void Confirm_Button_Click(object sender, RoutedEventArgs e)
        {
            string sumString = Sum_Text_Box.Text.Trim();
            double sumDouble = Double.Parse(sumString);
            int userId = Int32.Parse(User_Id_Block.Text.Trim());
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                var scores = applicationContext.Scores.Where(s => s.UserId == userId).ToList();
                foreach (var score in scores)
                {
                    if(score.Balance < sumDouble)
                    {
                        Sum_Text_Box.Clear();
                        Sum_Text_Box.Text = "You can't take more money then you have";
                    }
                    else
                    {
                        score.Balance -= sumDouble;
                        applicationContext.SaveChanges();
                        MainMenuWindow mainMenuWindow = new MainMenuWindow();
                        mainMenuWindow.User_Id_Block.Text = User_Id_Block.Text.Trim();
                        mainMenuWindow.Show();
                        var balance = from s in applicationContext.Scores
                                      where s.UserId == userId
                                      select s.Balance.ToString();
                        foreach (var value in balance)
                        {
                            mainMenuWindow.User_Score_Text_Block.Text = value;
                        }
                        buttons.Clear();
                        this.Close();
                    }
                }
            }
        }
    }
}
