using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_3
{
    class Employee
    {
        public Employee(string name , double salary)
        {
            this.Username = name;
            this.Salary = salary;
            _id++;
            Id = _id;
        }
        private int _id;
        public int Id { get;}

        public string Username { get; set; }
        public double Salary { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Username:{this.Username}");
        }
    }
}
