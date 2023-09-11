using carservice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.service
{
    interface UserSerrvise
    {
        bool validate(User existingUser, User user);
        bool saveUser(User user);

        User getUser(String userName);
    }
}
