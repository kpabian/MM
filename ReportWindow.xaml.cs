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
        /// <summary>
        /// Initializes new ReportWindow, whitch enables creating new reports of spendings.
        /// </summary>
        public ReportWindow()
        {
            InitializeComponent();
            InitializeLists();
            
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
            Close();
        }

        private void ReportButton_Click(object sender, RoutedEventArgs e)
        {
            MMContext context = new MMContext();
            bool selectedUser = context.Users.Any(c => c.Name == userCB.Text);
            bool selectedMonth = context.Months.Any(c => c.NameOfMonth == monthCB.Text);
            if(selectedUser && selectedMonth)
                MakeReport();
            else
            {
                MessageBoxResult mess;
                mess = MessageBox.Show("Nie wybrano użytkownika lub miesiąca", "", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.Yes);
            }


        }

        private void InitializeLists()
        {
            var context = new MMContext();
            var usersList = context.Users.ToList();
            foreach (var c in usersList)
            {
                userCB.Items.Add(c.Name);
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

        private void AnnualButton_Click(object sender, RoutedEventArgs e)
        {

            MMContext context = new MMContext();
            bool selectedUser = context.Users.Any(c => c.Name == userCB.Text);

            if (selectedUser)
            {
                var x = context.Months.ToArray();
                StringBuilder sb = new StringBuilder();
                decimal fullAmount = 0;
                foreach (var i in x)
                {
                    var y = context.Spendings.Where(s => s.Month.NameOfMonth == i.NameOfMonth && s.User.Name == userCB.Text).ToArray();
                    decimal sum = 0;
                    foreach (var s in y)
                    {

                        sum += s.Amount;
                        fullAmount += s.Amount;
                    }
                    sb.Append(sum.ToString());
                    sb.Append("\t\t");
                    sb.Append(i.NameOfMonth.ToString());
                    sb.Append("\n");
                }
                sb.Append(fullAmount.ToString());
                sb.Append("\t\t");
                sb.Append("SUMA");
                DataTextBox.Text = sb.ToString();
            }
            else
            {
                MessageBoxResult mess;
                mess = MessageBox.Show("Nie wybrano użytkownika", "", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.Yes);
            }
        }

        private void ImportanceReportButton_Click(object sender, RoutedEventArgs e)
        {
            MMContext context = new MMContext();
            bool selectedUser = context.Users.Any(c => c.Name == userCB.Text);
            bool selectedMonth = context.Months.Any(c => c.NameOfMonth == monthCB.Text);
            if (selectedUser && selectedMonth)
            {
                var x = context.Importances.ToArray();
                StringBuilder sb = new StringBuilder();
                decimal fullAmount = 0;
                foreach (var i in x)
                {
                    var y = context.Spendings.Where(s => s.Importance.Name == i.Name && s.User.Name == userCB.Text && s.Month.NameOfMonth == monthCB.Text).ToArray();
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
            else
            {
                MessageBoxResult mess;
                mess = MessageBox.Show("Nie wybrano użytkownika lub miesiąca", "", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.Yes);
            }
        }
    }
}
