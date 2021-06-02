namespace Lib
{
    public class Admin
    {
        public string Login { get; }
        public string Password { get; }
        public string Email { get; }

        public Admin(string login, string password, string email)
        {
            Login = login;
            Password = password;
            Email = email;
        }
    }
}
