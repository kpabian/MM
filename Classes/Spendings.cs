using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoney.Classes
{
    public class Spendings
    {
        string amount;
        Category category;
        Importance importance;

        public Spendings (string amount, Category category, Importance importance)
        {
            this.amount = amount;
            this.category = category;
            this.importance = importance;
        }
             
    }
}
