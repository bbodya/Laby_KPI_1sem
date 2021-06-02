using System.Collections.Generic;

namespace Lib.Repositories
{
    public class AdminRepository
    {
        private List<Admin> Admins { get; }

        public AdminRepository() => Admins = new List<Admin>();

        public void Register(string login, string password, string email)
        {
            Admins.Add(new Admin(login, password, email));
        }

        public Admin Login(string login, string password) => 
            Admins.Find(x => x.Login == login && x.Password == password);

        public bool Validate(Admin client) => Admins.Contains(client);
    }
}
