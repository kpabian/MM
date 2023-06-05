using MM.Classes;
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

namespace MM
{
    /// <summary>
    /// Interaction logic for NewUserWindow.xaml
    /// </summary>
    public partial class NewUserWindow : Window
    {
        /// <summary>
        ///  This window enables creating new User instances
        /// </summary>
        public NewUserWindow()
        {
            InitializeComponent();
        }

        private void NewUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (userName.Text.Length > 1)
            {
                using (MMContext context = new MMContext())
                {
                    try
                    {
                        User std = new User()
                        {
                            Name = userName.Text,

                        };
                        context.Users.Add(std);
                        context.SaveChanges();

                        MessageBoxResult result;
                        result = MessageBox.Show("Użytkownik utworzony", "", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.Yes);
                    }
                    catch (Exception ex)
                    {
                        MessageBoxResult mess;
                        mess = MessageBox.Show("Nie można utworzyć użytkownika", "", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.Yes);
                    }
                }
            }
            else
            {
                MessageBoxResult mess;
                mess = MessageBox.Show("Za krótka nazwa użytkownika", "", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.Yes);
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
            this.Close();
        }
    }
}
