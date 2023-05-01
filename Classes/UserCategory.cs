using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Classes
{
    public class UserCategoty
    {
        public Category Category { get; set; }
        public User User { get; set; }
        public UserCategoty(Category category, User user)
        {
            this.Category = category;
            this.User = user;
        }

        private UserCategory(Category category)
        {
            this.Category = category;
        }
    }
}