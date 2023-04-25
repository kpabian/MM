using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Classes
{
    public class UserCategoty
    {
        Category category;
        User user;
        public UserCategoty(Category category, User user)
        {
            this.category = category;
            this.user = user;
        }
    }
}