using System;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _vm;
        public UserView(UserViewModel vm) => _vm = vm;
        public void Display()
        {
            Console.WriteLine($"Name: {_vm.Names}, Role: {_vm.Role}, Age: {_vm.Age}");
        }
    }
} 