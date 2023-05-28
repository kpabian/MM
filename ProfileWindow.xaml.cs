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
    /// Interaction logic for ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        public ProfileWindow()
        {
            InitializeComponent();
        }

        private void NewSpendingsButton_Click(object sender, RoutedEventArgs e)
        {
            NewSpendingWindow newSpendingsWindow = new NewSpendingWindow();
            newSpendingsWindow.Show();
            Close();
        }

        private void NewCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            NewCategoryWindow newCategoryWindow = new NewCategoryWindow();
            newCategoryWindow.Show();
            Close();
        }

        private void NewReportButton_Click(object sender, RoutedEventArgs e)
        {
            ReportWindow newRaportDateWindow = new ReportWindow();
            newRaportDateWindow.Show();
            Close();
        }

        private void NewUserButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
