using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MM.Classes;

namespace MM
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

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string Username = username.Text;
            string Password = password.Password;

            using (MMContext context = new MMContext())
            {
                bool userexist = context.Users.Any(user => user.Name == Username && user.Password == Password);
                if (userexist)
                {
                    var std = context.Users.Where(s => s.Name == Username).First();
                    std.ID = true;
                    context.SaveChanges();
                    ProfileWindow profileWindow = new ProfileWindow();
                    profileWindow.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Źle wprowadzone dane");
            }

        }

        private void newAccountButton_Click(object sender, RoutedEventArgs e)
        {
            using (MMContext context = new MMContext())
            {
                bool userexist = context.Users.Any(user => user.Name == username.Text);
                if (!userexist)
                {
                    var user = new User()
                    {
                        Name = username.Text,
                        Password = password.Password,
                        ID = true
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                }

                ProfileWindow profileWindow = new ProfileWindow();
                profileWindow.Show();
                this.Close();

                MessageBoxResult result;
                result = MessageBox.Show("Konto utworzone pomyślnie", "", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.Yes);
            }
        }
    }
}

