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
    /// This class defines users' data
    /// </summary>
    public class User
    {
        /// <summary>
        /// Name of the user
        /// </summary>
        [Key]
        public string Name { get; set; }

    }
}
