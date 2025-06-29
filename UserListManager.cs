using System;
using System.Collections.Generic;
using System.Linq;
using Welcome.Model;

namespace Welcome.ViewModel
{
    public class UserListManager
    {
        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public double GetAverageAge()
        {
            if (_users.Count == 0) return 0;
            return _users.Average(u => u.Age);
        }

        public List<User> GetAllUsers() => _users;
    }
}
