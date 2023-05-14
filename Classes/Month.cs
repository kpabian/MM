using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Classes
{
    public class Month
    {
        [Key]
        public string NameOfMonth { get; set; }
    }
}
