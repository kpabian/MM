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
        MMContext context = new MMContext();
        public ReportWindow()
        {
            InitializeComponent();
            MMContext context = new MMContext();
            var x = context.Spendings.GroupBy(x => x.CategoryName).ToArray();
            StringBuilder sb = new StringBuilder();
            decimal fullAmount = 0;
            foreach(var i in  x)
            {
                var y = context.Spendings.Where(s => s.CategoryName == i.Key).ToArray();
                decimal sum = 0;
                foreach (var s in y)
                {
                    sum += s.Amount;
                    fullAmount += s.Amount;
                }
                sb.Append(sum.ToString());
                sb.Append("\t\t");
                sb.Append(i.Key.ToString());
                sb.Append("\n");
            }
            sb.Append(fullAmount.ToString());
            sb.Append("\t\t");
            sb.Append("SUMA");
            DataTextBox.Text = sb.ToString();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
            this.Close();
        }
    }
}
