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
        /// <summary>
        /// Initializes NewCategoryWindow, whitch enables creating new Category instances
        /// </summary>
        public NewCategoryWindow()
        {
            InitializeComponent();
        }

        private void NewCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (categoryName.Text.Length > 1)
            {
                using (var context = new MMContext())
                {
                    try
                    {
                        var std = new Category()
                        {
                            Name = categoryName.Text,

                        };
                        context.Categories.Add(std);
                        context.SaveChanges();

                        MessageBoxResult result;
                        result = MessageBox.Show("Kategoria stworzona", "", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.Yes);
                    }
                    catch (Exception ex)
                    {
                        MessageBoxResult mess;
                        mess = MessageBox.Show("Nie można utworzyć kategorii", "", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.Yes);
                    }
                }
            }
            else
            {
                MessageBoxResult mess;
                mess = MessageBox.Show("Nie można utworzyć kategorii. Za krótka nazwa", "", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.Yes);
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
