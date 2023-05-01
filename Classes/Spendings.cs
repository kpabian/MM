using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Classes
{
    public class Spendings
    {
        public string Amount { get; set; }
        public Category Category { get; set; }
        public Importance Importance { get; set; }

        public Spendings (string amount, Category category, Importance importance)
        {
            Amount = amount;
            Category = category;
            Importance = importance;
        }

        private Spendings(string amount)
        {
            Amount = amount;
        }
             
    }
}
