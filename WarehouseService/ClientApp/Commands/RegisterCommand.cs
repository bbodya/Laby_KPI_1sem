using ClientApp.Commands.Abstract;
using ClientApp.Controllers.Abstract;
using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ClientApp.Commands
{
    class RegisterCommand : Command
    {
        public override string Name => "register";

        public override string Description => "to register";

        public override Controller Execute(Controller controller)
        {
            var clients = controller.Warehouse.ClientRepository;

            //Name
            Console.Write("Name: ");
            var name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Enter a name that contains non-empty symbols: ");
                name = Console.ReadLine();
            }

            //Surname
            Console.Write("Surname: ");
            var surname = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(surname))
            {
                Console.Write("Enter a surname that contains non-empty symbols: ");
                surname = Console.ReadLine();
            }

            //Email
            Console.Write("Email: ");
            var email = Console.ReadLine();
            bool check = true;
            try
            {
                var line = new MailAddress(email);
            }
            catch (FormatException)
            {
                check = false;
            }

            while (!check)
            {
                Console.Write("Enter email in the correct format: ");
                email = Console.ReadLine();
                try
                {
                    var line = new MailAddress(email);
                    check = true;
                }
                catch (FormatException)
                {
                    check = false;
                }
            }

            //Phone
            Console.Write("Phone number: ");
            var phone = Console.ReadLine();

            var pattern = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");

            while(!pattern.IsMatch(phone) && !string.IsNullOrWhiteSpace(phone))
            {
                Console.Write("Enter the phone number in the correct format: ");
                phone = Console.ReadLine();
            }

            //Login
            Console.Write("Login: ");
            var login = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(login) && clients.Exists(login))
            {
                Console.Write("This login is already taken, enter another: ");
                login = Console.ReadLine();
            }

            //Password
            Console.Write("Password: ");
            var password = Console.ReadLine();
            Console.Write("Repeat password: ");
            var passwordConfirmation = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(password) || password != passwordConfirmation)
            {
                Console.WriteLine("Password should not be blank and entered twice the same, enter another!");

                Console.Write("Password: ");
                password = Console.ReadLine();
                Console.Write("Repeat password: ");
                passwordConfirmation = Console.ReadLine();
            }

            if (clients.Register(login, password, name, surname, email, phone))
                Console.WriteLine("Registration was successful");
            else
                Console.WriteLine("Something went wrong, try again later ...");

            return controller;
        }
    }
}
