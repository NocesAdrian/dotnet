// See https://aka.ms/new-console-template for more information
using System;

namespace Main
{
    class Login
    {
        // field
        private string password; // can only be accessed inside the its class
        // property
        public string Password // accessing the "private password"(field) passing the value on it
        {
            get { return password; }
            set { password = value; }
        }

        // shorthand
        public string passwd { get; set;} // not readable for me
        public string name;

        public Login(string name = "none", string password = "none")
        {
            this.name = name;
            this.Password = password;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Login user1 = new Login("adrian", "123456");
            Console.WriteLine(user1.Password);

        }
    }
}