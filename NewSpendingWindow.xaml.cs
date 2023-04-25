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
    /// Interaction logic for NewSpendingWindow.xaml
    /// </summary>
    public partial class NewSpendingWindow : Window
    {
        public NewSpendingWindow()
        {
            InitializeComponent();
        }

        private void NewSpendingsButton_Click(object sender, RoutedEventArgs e)
        {
            //Spendings spending = new Spendings(sum.Text, category, )
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
            this.Close();
        }
    }
}
