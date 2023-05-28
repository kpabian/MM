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
        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade databaseFacade = new DatabaseFacade(new Classes.MMContext());
            databaseFacade.EnsureCreated();
            //NewDatabase();
        }
        public void NewDatabase()
        {
            using (var context = new MMContext())
            {
                //user

                var user = new User()
                {
                    Name = "admin",
                    
                };
                context.Users.Add(user);

                var user2 = new User()
                {
                    Name = "1",
                    
                };
                context.Users.Add(user2);

                //importance 

                var std = new Importance()
                {
                    Name = "potrzeby"
                };
                context.Importances.Add(std);

                var std1 = new Importance()
                {
                    Name = "zachcianki"
                };
                context.Importances.Add(std1);
                var std2 = new Importance()
                {
                    Name = "inwestycje/oszczędności"
                };
                context.Importances.Add(std2);

                // categories

                var std3 = new Category()
                {
                    Name = "inwestycje/oszczędności",
                   
                };
                context.Categories.Add(std3);

                //months
                var jan = new Month()
                {
                    NameOfMonth = "Styczeń"
                };
                context.Months.Add(jan);
                var feb = new Month()
                {
                    NameOfMonth = "Luty"
                };
                context.Months.Add(feb);
                var mar = new Month()
                {
                    NameOfMonth = "Marzec"
                };
                context.Months.Add(mar);
                var apr = new Month()
                {
                    NameOfMonth = "Kwiecień"
                };
                context.Months.Add(apr);
                var may = new Month()
                {
                    NameOfMonth = "Maj"
                };
                context.Months.Add(may);
                var jun = new Month()
                {
                    NameOfMonth = "Czerwiec"
                };
                context.Months.Add(jun);
                var jul = new Month()
                {
                    NameOfMonth = "Lipiec"
                };
                context.Months.Add(jul);
                var aug = new Month()
                {
                    NameOfMonth = "Sierpień"
                };
                context.Months.Add(aug);
                var sep = new Month()
                {
                    NameOfMonth = "Wrzesień"
                };
                context.Months.Add(sep);
                var oct = new Month()
                {
                    NameOfMonth = "Październik"
                };
                context.Months.Add(oct);
                var nov = new Month()
                {
                    NameOfMonth = "Listopad"
                };
                context.Months.Add(nov);
                var dec = new Month()
                {
                    NameOfMonth = "Grudzień"
                };
                context.Months.Add(dec);


                context.SaveChanges();
            }


        }
    }

    
}
