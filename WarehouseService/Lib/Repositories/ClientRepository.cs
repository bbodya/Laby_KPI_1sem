using System.Collections.Generic;

namespace Lib.Repositories
{
    public class ClientRepository
    {
        private List<Client> Clients { get; }

        public ClientRepository() => Clients = new List<Client>();

        public bool Exists(string login) => Clients.Find(x => x.Login == login) is { };

        public bool Register(string login, string password, string name, string surname, string email, string phone = "")
        {
            if (Exists(login))
                return false;

            var client = new Client(login, password, name, surname, email, phone);
            Clients.Add(client);

            return true;
        }

        public Client Login(string login, string password) => 
            Clients.Find(x => x.Login == login && x.Password == password);

        public bool Validate(Client client) => Clients.Contains(client);
    }
}
