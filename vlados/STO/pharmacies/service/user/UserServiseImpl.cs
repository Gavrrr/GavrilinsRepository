using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carservice.model;
using carservice.repository;

namespace carservice.service
{
    class UserServiseImpl : UserSerrvise
    {
        UserRepository userRepository = new UserRepository();

        public bool saveUser(User user)
        {
            if (userRepository.findUserByUserName(user.UserName) != null)
            {
                return false;
            }
            userRepository.save(user);
            return true;
        }

        public User getUser(String userName)
        {
            try
            {
                return userRepository.findUserByUserName(userName);
            }
            catch
            {
                return null;
            }

        }

        public bool validate(User existingUser, User userForValidate)
        {

            if (existingUser != null && existingUser.Password == userForValidate.Password)
            {
                return true;
            }

            return false;
        }

    }
}
