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
    /// This class defines spendings' importance data
    /// </summary>
    public class Importance
    {
        /// <summary>
        /// Name of the importance
        /// </summary>
        [Key] 
        public string Name { get; set; }

       
    }
}

