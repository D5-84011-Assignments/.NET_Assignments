

using Assignment6;
using System;

namespace Assignment7
{
    class Person
    {
        string Name;
        bool Gender;
        public Date Birth = new Date();
        private string Address;
        static int Age;

        public Person()
        {
        }

        public Person(string name, bool gender, Date birth, string address)
        {
            Name = name;
            Gender = gender;
            Birth = birth;
            Address = address;
        }

        public void Accept()
        {
            Console.WriteLine("Enter Name of Person:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter gender of Person:(true: M /false: F)");
            Gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Birth Date of Person:");
            Birth.AcceptDate();
            Console.WriteLine("Enter Address  person:");
            Address = Console.ReadLine();

        }

        public void Print()
        {
            Console.WriteLine("Name of person: " + Name);
            Console.WriteLine("Gender of person: " + (Gender ? "Male" : "Female"));
            Console.WriteLine("Name of person: " + Address);
            Birth.PrintDate();
        }
        public override string ToString()
        {
            return Name + (Gender ? "Male" : "Female") + Address + Birth.ToString();
        }

        public string Name1 { get => Name; set => Name = value; }
        public bool Gender1 { get => Gender; set => Gender = value; }
        internal Date Birth1 { get => Birth; set => Birth = value; }
        public string Address1 { get => Address; set => Address = value; }
        public static int Age1 { get => Age; }
    }
}
