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

namespace UsersApp
{
    /// <summary>
    /// Interaction logic for AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            string login = loginbox.Text.Trim();
            string password = passwordbox.Password.Trim();

            if (login.Length < 6)
            {
                loginbox.ToolTip = "Login must be more than 6 characters";
                loginbox.Background = Brushes.Red;
            }
            else if (password.Length < 7)
            {
                passwordbox.ToolTip = "Password must be more than 7 characters";
                passwordbox.Background = Brushes.Red;
            }
            else
            {
                loginbox.ToolTip = "";
                loginbox.Background = Brushes.Transparent;
                passwordbox.ToolTip = "";
                passwordbox.Background = Brushes.Transparent;

                User loginuser = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    loginuser = db.Users.Where(b => b.Login == login && b.Password == password).FirstOrDefault();
                }

                if (loginuser != null)
                {
                    MessageBox.Show("All is correct");
                    UserAccountWindow userAccountWindow = new UserAccountWindow();
                    userAccountWindow.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("You insert a wrong data!");
            }
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
