using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MM.Classes
{
    public class Spendings
    {
        [Key] public int Id { get; set; }
        public decimal Amount { get; set; }
        [ForeignKey("Month")]
        public string MonthName { get; set; }
        public Month Month { get; set; }
        [ForeignKey("Category")]
        public string CategoryName { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Importance")]
        public string ImportanceName { get; set; }
        public Importance Importance { get; set; }

    }
}
