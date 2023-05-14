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
using MM.Classes;

namespace MM
{
    /// <summary>
    /// Interaction logic for NewRaportDateWindow.xaml
    /// </summary>
    public partial class NewRaportDateWindow : Window
    {
        public NewRaportDateWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
            this.Close();
        }

        private void NewReportButton_Click(object sender, RoutedEventArgs e)
        {
            var context = new MMContext();
            var report = context.Spendings
                         .Where(s => s.MonthName == month.Text)
                         .ToList();
            ReportWindow reportWindow = new ReportWindow(report);
            reportWindow.Show();
            this.Close();
        }
    }
}
