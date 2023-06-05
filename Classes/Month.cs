using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Classes
{
    /// <summary>
    /// This class defines names of months
    /// </summary>
    public class Month
    {
        /// <summary>
        /// Name of month
        /// </summary>
        [Key]
        public string NameOfMonth { get; set; }
    }
}
