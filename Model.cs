namespace Welcome.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Password { get; set; }
        public UserRolesEnum Role { get; set; }
        public int Age { get; set; }
    }

    public enum UserRolesEnum
    {
        STUDENT,
        PROFESSOR,
        ADMIN
    }
}
