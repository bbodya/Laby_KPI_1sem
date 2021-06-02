using System;

namespace Lib
{
    public class Client : IEquatable<Client>
    {
        public string Login { get; }
        public string Password { get; }
        public string Surname { get; }
        public string Name { get; }
        public string Email { get; }
        public string Phone { get; }

        public Client(string login, string password, string name, string surname, string email, string phone)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
        }

        public static bool operator ==(Client left, Client right)
        {
            if (left is null)
                return right is null;

            return left.Equals(right);
        }

        public static bool operator !=(Client left, Client right) => !(left == right);

        public override bool Equals(object obj)
        {
            var client = obj as Client;

            if (client is null)
                return false;

            return Login == client.Login;
        }

        public bool Equals(Client other) => other != null && Login == other.Login;

        public override int GetHashCode() => HashCode.Combine(Login);
    }
}