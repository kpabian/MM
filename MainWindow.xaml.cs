using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
            this.Close();
        }

        private void newAccountButton_Click(object sender, RoutedEventArgs e)
        {
            //User user = new User(username.Text, password.Text);

            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
                this.Close();

            MessageBoxResult result;
            result = MessageBox.Show("Konto utworzone pomyślnie", "", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.Yes);
        }
}
}
