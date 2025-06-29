using Welcome.Model;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        private User _user;
        public UserViewModel(User user) => _user = user;
        public int Age => _user.Age;
        public string Names => _user.Names;
        public string Role => _user.Role.ToString();
    }
}
