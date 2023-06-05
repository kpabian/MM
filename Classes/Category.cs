using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MM.Classes
{
    /// <summary>
    /// This class defines spendings' category data 
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Name of category
        /// </summary>
        [Key]
        public string Name { get; set; }
        
    }
}

