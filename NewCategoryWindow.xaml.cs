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
    /// Interaction logic for NewCategoryWindow.xaml
    /// </summary>
    public partial class NewCategoryWindow : Window
    {
        public NewCategoryWindow()
        {
            InitializeComponent();
        }

        private void NewCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Kategoria stworzona pomyślnie", "", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.Yes);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
            this.Close();
        }
    }
}
