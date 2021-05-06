using ApiDataImob.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDataImob.Repositories
{
    public static class UserRepository
    {

        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add( new User { Id = 1, Username = "DataImob", Password= "yc9qGtT!mR06", Role = "manager"});

            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }
    
    
    
    }
}
