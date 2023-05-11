using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MM.Classes
{
    public class UserCategory
    {
        [Key] public int Id { get; set; }
        [ForeignKey("Category")]
        public string Category { get; set; }
        [ForeignKey("User")]
        public string User { get; set; }


        
    }
}