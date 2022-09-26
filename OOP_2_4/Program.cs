using System;

namespace OOP_2_4
{
    class User
    {
        //поля
        private string login;
        private string name;
        private string surname;
        private uint age;
        private readonly string date;
        // конструктор з параметрами
        public User(string login, string name, string surname, uint age, string date)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.date = date;
        }
        // властивості
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public uint Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Date
        {
            get { return date; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // створення екземплярa класу
            User u = new("ashev2003@ukr.net", "Artem", "Shevchuk", 18, "23.09.22");
            Console.WriteLine($"{u.Login}");
            Console.WriteLine($"{u.Name}");
            Console.WriteLine($"{u.Surname}");
            Console.WriteLine($"{u.Age}");
            Console.WriteLine($"{u.Date}");
            Console.ReadLine();
        }
    }
}