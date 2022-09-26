using System;

namespace OOP_2_1
{
    class Address
    {
        // поля класу
        private string index;
        private string country;
        private string city;
        private string street;
        private uint house;
        private uint apartment;

        // конструктор з 6 параметрами
        public Address(string index, string country, string city, string street, uint house, uint apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }

        // властивості
        public string Index
        {
            get { return index; }
            set { index = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public uint House
        {
            get { return house; }
            set { house = value; }
        }
        public uint Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address someAddress = new Address("02254", "Ukraine", "Kyiv", "Zakrevskogo", 53, 112); // створення екземпляру класу
            // звернення до get
            // виведення адреси на екран
            Console.WriteLine($"{someAddress.Index}");
            Console.WriteLine($"{someAddress.Country}");
            Console.WriteLine($"{someAddress.City}");
            Console.WriteLine($"{someAddress.Street}");
            Console.WriteLine($"{someAddress.House}");
            Console.WriteLine($"{someAddress.Apartment}");
            Console.ReadLine();
        }
    }
}