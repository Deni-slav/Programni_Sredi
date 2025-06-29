using System;
using Welcome.Model;
using Welcome.ViewModel;
using WelcomeExtended.Others;
// using Welcome.View; // Will add this if UserView is created

class Program
{
    static void Main(string[] args)
    {
        var manager = new UserListManager();

        // Seed with some users
        var user1 = new User { Names = "Ivan Ivanov", Password = "pass123", Role = UserRolesEnum.STUDENT, Age = 22 };
        var user2 = new User { Names = "Maria Georgieva", Password = "pass456", Role = UserRolesEnum.PROFESSOR, Age = 45 };
        var user3 = new User { Names = "Asen Petrov", Password = "pass789", Role = UserRolesEnum.ADMIN, Age = 30 };

        manager.AddUser(user1);
        manager.AddUser(user2);
        manager.AddUser(user3);

        ActionOnError onError = Delegates.LogToConsole;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== User Management Menu ====");
            Console.WriteLine("1. Display all users");
            Console.WriteLine("2. Add new user");
            Console.WriteLine("3. Show average age");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n--- User List ---");
                    foreach (var user in manager.GetAllUsers())
                    {
                        var vm = new UserViewModel(user);
                        Console.WriteLine($"ID: {user.Id}, Name: {vm.Names}, Role: {vm.Role}, Age: {vm.Age}");
                    }
                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("\n--- Add New User ---");
                    Console.Write("Enter name: ");
                    var name = Console.ReadLine();
                    Console.Write("Enter password: ");
                    var password = Console.ReadLine();
                    Console.WriteLine("Select role: 1. Student  2. Professor  3. Admin");
                    Console.Write("Enter role number: ");
                    var roleInput = Console.ReadLine();
                    UserRolesEnum role = UserRolesEnum.STUDENT;
                    if (roleInput == "2") role = UserRolesEnum.PROFESSOR;
                    else if (roleInput == "3") role = UserRolesEnum.ADMIN;
                    int age = 0;
                    while (true)
                    {
                        Console.Write("Enter age: ");
                        var ageInput = Console.ReadLine();
                        if (int.TryParse(ageInput, out age) && age > 0)
                            break;
                        Console.WriteLine("Invalid age. Please enter a positive number.");
                    }
                    var newUser = new User { Names = name, Password = password, Role = role, Age = age };
                    manager.AddUser(newUser);
                    Console.WriteLine("User added successfully! Press any key to return to menu...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine($"\nAverage age of users: {manager.GetAverageAge():F2}");
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key to try again...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}



