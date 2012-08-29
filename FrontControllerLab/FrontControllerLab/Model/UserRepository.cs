using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontControllerLab.Model
{
    public class UserRepository
    {
        private gcutourswmEntities context = new gcutourswmEntities();

        public IQueryable<User> GetAll()
        {
            return context.Users;
        }

        public User GetByUsername(string target)
        {
            return context.Users.SingleOrDefault(u => u.username == target);
        }
    }
}
