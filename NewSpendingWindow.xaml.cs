using MM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        /// <summary>
        /// Initializes NewSpendingWindow, whitch enables creating new Spendings instances
        /// </summary>
        public NewSpendingWindow()
        {
            InitializeComponent(); 
            InitializeComboBoxes();

        }

        private void InitializeComboBoxes()
        {
            MMContext context = new MMContext();
            List<Category> categoryList = context.Categories.ToList();
            foreach (Category c in categoryList)
            {
                category.Items.Add(c.Name);
            }
            List<User> usersList = context.Users.ToList();
            foreach (User user in usersList)
            {
                userCB.Items.Add(user.Name);
            }
        }

        private void NewSpendingsButton_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("^[1-9][0-9]{0,5},?[0-9]{0,2}$");
            using (MMContext context = new MMContext())
            {
                bool selectedcategory = context.Categories.Any(c => c.Name == category.Text);
                bool selectedimportance = context.Importances.Any(c => c.Name == importance.Text);
                bool selectedmonth = context.Months.Any(c => c.NameOfMonth == month.Text);
                bool selecteduser = context.Users.Any(c => c.Name == userCB.Text);

                if (regex.IsMatch(sum.Text) && selectedcategory && selectedimportance && selectedmonth)
                {
                
                    Spendings spd = new Spendings()
                    {
                        Amount = decimal.Parse(sum.Text),
                        Category = context.Categories.Where(s => s.Name == category.Text).FirstOrDefault(),
                        Importance = context.Importances.Where(s => s.Name == importance.Text).FirstOrDefault(),
                        Month = context.Months.Where(s => s.NameOfMonth == month.Text).FirstOrDefault(),
                        User = context.Users.Where(c => c.Name == userCB.Text).FirstOrDefault()
                };
                    context.Spendings.Add(spd);
                    context.SaveChanges();
                
                MessageBoxResult result;
                result = MessageBox.Show("Wydatek dodany pomyślnie", "", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.Yes);
                }
                else
                {
                    MessageBoxResult result;
                    result = MessageBox.Show("Sprawdź poprawność danych", "", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Yes);
                }
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
