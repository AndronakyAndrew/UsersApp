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

namespace UsersApp
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

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = loginbox.Text.Trim();
            string password = passwordbox.Password.Trim();
            string password_2 = passwordbox_2.Password.Trim();
            string email = emailbox.Text.Trim().ToLower();

            if(login.Length < 6)
            {
                loginbox.ToolTip = "Login must be more than 6 characters";
                loginbox.Background = Brushes.Red;
            }
            else if (password.Length < 7)
            {
                passwordbox.ToolTip = "Password must be more than 7 characters";
                passwordbox.Background = Brushes.Red;
            }
            else if (password != password_2)
            {
                passwordbox_2.ToolTip = "Passwords don't match";
                passwordbox_2.Background = Brushes.Red;
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                emailbox.ToolTip = "Email isn't correct";
                emailbox.Background = Brushes.Red;
            }
            else
            {
                loginbox.ToolTip = "";
                loginbox.Background = Brushes.Transparent;
                passwordbox.ToolTip = "";
                passwordbox.Background = Brushes.Transparent;
                passwordbox_2.ToolTip = "";
                passwordbox_2.Background = Brushes.Transparent;
                emailbox.ToolTip = "";
                emailbox.Background = Brushes.Transparent;

                MessageBox.Show("You have successfully registered");
            }
        }
    }
}
