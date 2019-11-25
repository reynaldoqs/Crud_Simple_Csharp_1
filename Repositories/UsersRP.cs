using CrudApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Repositories
{
    public class UsersRP
    {
        public static List<User> _users = new List<User>(){
               new User(){Id = 1, Name = "Maria", Credit = 23.0},
               new User(){Id = 2, Name = "Juana", Credit = 623.0},
               new User(){Id = 3, Name = "Carlos", Credit = 491.0},
               new User(){Id = 4, Name = "Pedro", Credit = 123.0},
               new User(){Id = 5, Name = "Gomer", Credit = 53.0},
               new User(){Id = 6, Name = "Moralex", Credit = 33.0},
        };

        public IEnumerable<User> getUsers()
        {
            return _users;
        }
        public User getUser(int id)
        {
            var client = _users.Where(x => x.Id == id);
            return client.FirstOrDefault();
        }
        public void addUser(User newUser)
        {
            _users.Add(newUser);
        }
        public void updateUser(int id, User user)
        {
            int index = _users.FindIndex(x => x.Id == id);
            _users[index] = user;
        }
        public void removeUser(int id)
        {
            int index = _users.FindIndex(x => x.Id == id);
            _users.RemoveAt(index);
        }
    }
}
