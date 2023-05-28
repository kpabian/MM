using Microsoft.EntityFrameworkCore.Infrastructure;
using MM.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        ///  Initializes new DatabaseFacade and creates initial database.
        /// </summary>
        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade databaseFacade = new DatabaseFacade(new Classes.MMContext());
            databaseFacade.EnsureCreated();
            MMContext context = new MMContext();
            if (!context.Users.Any(c => c.Name == "admin"))
                NewDatabase();
        }
        private void NewDatabase()
        {
            using (MMContext context = new MMContext())
            {
                //user

                User user = new User()
                {
                    Name = "admin",
                    
                };
                context.Users.Add(user);

                User user2 = new User()
                {
                    Name = "1",
                    
                };
                context.Users.Add(user2);

                //importance 

                Importance std = new Importance()
                {
                    Name = "potrzeby"
                };
                context.Importances.Add(std);

                Importance std1 = new Importance()
                {
                    Name = "zachcianki"
                };
                context.Importances.Add(std1);
                Importance std2 = new Importance()
                {
                    Name = "oszczędności"
                };
                context.Importances.Add(std2);

                // categories

                Category std3 = new Category()
                {
                    Name = "mieszkanie",
                   
                };
                context.Categories.Add(std3);
                Category std4 = new Category()
                {
                    Name = "żywność",

                };
                context.Categories.Add(std4);
                Category std5 = new Category()
                {
                    Name = "transport",

                };
                context.Categories.Add(std5);

                //months

                Month jan = new Month()
                {
                    NameOfMonth = "Styczeń"
                };
                context.Months.Add(jan);
                Month feb = new Month()
                {
                    NameOfMonth = "Luty"
                };
                context.Months.Add(feb);
                Month mar = new Month()
                {
                    NameOfMonth = "Marzec"
                };
                context.Months.Add(mar);
                Month apr = new Month()
                {
                    NameOfMonth = "Kwiecień"
                };
                context.Months.Add(apr);
                Month may = new Month()
                {
                    NameOfMonth = "Maj"
                };
                context.Months.Add(may);
                Month jun = new Month()
                {
                    NameOfMonth = "Czerwiec"
                };
                context.Months.Add(jun);
                Month jul = new Month()
                {
                    NameOfMonth = "Lipiec"
                };
                context.Months.Add(jul);
                Month aug = new Month()
                {
                    NameOfMonth = "Sierpień"
                };
                context.Months.Add(aug);
                Month sep = new Month()
                {
                    NameOfMonth = "Wrzesień"
                };
                context.Months.Add(sep);
                Month oct = new Month()
                {
                    NameOfMonth = "Październik"
                };
                context.Months.Add(oct);
                Month nov = new Month()
                {
                    NameOfMonth = "Listopad"
                };
                context.Months.Add(nov);
                Month dec = new Month()
                {
                    NameOfMonth = "Grudzień"
                };
                context.Months.Add(dec);

                context.SaveChanges();
            }
        }
    }
}
