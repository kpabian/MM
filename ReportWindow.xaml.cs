using Microsoft.Extensions.Primitives;
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
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        public ReportWindow()
        {
            InitializeComponent();
            InitializeLists();
            
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
            this.Close();
        }

        private void ReportButton_Click(object sender, RoutedEventArgs e)
        {
            MakeReport();
        }

        private void InitializeLists()
        {
            var context = new MMContext();
            var usersList = context.Users.ToList();
            foreach (var c in usersList)
            {
                userCB.Items.Add(c.Name);
            }
            var monthList = context.Months.ToList();
            foreach (var c in monthList)
            {
                monthCB.Items.Add(c.NameOfMonth);
            }
        }

        private void MakeReport()
        {
            MMContext context = new MMContext();
            var x = context.Categories.ToArray();
            StringBuilder sb = new StringBuilder();
            decimal fullAmount = 0;
            foreach (var i in x)
            {
                var y = context.Spendings.Where(s => s.Category == i && s.User.Name == userCB.Text && s.Month.NameOfMonth == monthCB.Text).ToArray();
                decimal sum = 0;
                foreach (var s in y)
                {

                    sum += s.Amount;
                    fullAmount += s.Amount;
                }
                sb.Append(sum.ToString());
                sb.Append("\t\t");
                sb.Append(i.Name.ToString());
                sb.Append("\n");
            }
            sb.Append(fullAmount.ToString());
            sb.Append("\t\t");
            sb.Append("SUMA");
            DataTextBox.Text = sb.ToString();
        }
    }
}
