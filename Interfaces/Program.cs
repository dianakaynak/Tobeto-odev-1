using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //Intarfacesintr0();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());

            Console.ReadLine();
        }

        private static void Intarfacesintr0()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara",

            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Departmant = "Computer Science",
            };
            manager.Add(customer);
            manager.Add(student);
        }
    }
    interface IPerson //soyut nesne
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson //somut nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Worker : IPerson 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        private object person;

        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }


    }
}