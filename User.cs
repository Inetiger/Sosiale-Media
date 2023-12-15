using System;

namespace Sosiale_Media
{
    internal class User
    {
        public string _name;
        private string _brukerNavn;
        private int _age;

        public User(string name, string brukerNavn, int age)
        {
            _name = name;
            _brukerNavn = brukerNavn;
            _age = age;
        }

        public void PrintUserInfo()
        {
            Console.Clear();
            Console.WriteLine($"Brukernavn: {_brukerNavn}\nNavn: {_name}\nAlder: {_age}");
        }
    }
}
