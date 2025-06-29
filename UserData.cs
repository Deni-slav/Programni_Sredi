using System;
using System.Collections.Generic;
using System.Linq;
using Welcome.Model;

namespace WelcomeExtended.Data
{
    public class UserData
    {
        private List<User> _users;
        private int _nextId;

        public UserData()
        {
            _users = new List<User>();
            _nextId = 0;
        }

        public void AddUser(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
        }

        public double GetAverageAge()
        {
            if (_users.Count == 0)
                throw new Exception("There are no users in the system!");
            return _users.Average(u => u.Age);
        }

        public User GetUser(string name, string password)
        {
            return _users.FirstOrDefault(u => u.Names == name && u.Password == password);
        }

        public List<User> GetAll() => _users;
    }
}
