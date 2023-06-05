using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.Packaging;

namespace MM.Classes
{
    /// <summary>
    /// This class defines spendings data
    /// </summary>
    public class Spendings
    {
        /// <summary>
        /// Spendings identifier
        /// </summary>
        [Key] public int Id { get; set; }
        /// <summary>
        /// Spendings amount
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Name of the month of spending
        /// </summary>
        [ForeignKey("Month")]
        public string MonthName { get; set; }
        public Month Month { get; set; }
        /// <summary>
        /// Category name of spending
        /// </summary>
        [ForeignKey("Category")]
        public string CategoryName { get; set; }
        public Category Category { get; set; }
        /// <summary>
        /// Importane of spending
        /// </summary>
        [ForeignKey("Importance")]
        public string ImportanceName { get; set; }
        public Importance Importance { get; set; }
        /// <summary>
        /// Username of user who report the spending
        /// </summary>
        [ForeignKey("User")]
        public string UserName { get; set; }
        public User User { get; set; }

    }
}
