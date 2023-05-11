using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MM.Classes
{
    public class Importance
    {
        [Key] 
        public string Name { get; set; }

       
    }
}

