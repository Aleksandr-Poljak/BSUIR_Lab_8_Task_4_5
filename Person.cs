using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR_Lab_8_Task_5
{
    internal class Person<T> where T : Company
    {
        public string Name { get; set; }
        public DateOnly BirthDate { get; private set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public T? company { get; set; }

        public Person() 
        {
            Name = string.Empty;
            BirthDate = new DateOnly(1900, 1, 1);
            Position = string.Empty;
            Salary = 0;
            company = null;
        }
        public Person(string name, DateOnly birthDate, string position, double salary, T? company) :this()
        {
            Name = name;
            if (birthDate < DateOnly.FromDateTime(DateTime.Now)) BirthDate = birthDate;
            else { throw new ArgumentOutOfRangeException(); }
            Position = position;
            if (salary > 0.0000001) Salary = salary;
            else { throw new ArgumentException(); }
            this.company = company;
        }

        public override string ToString()
        {
            return $"Name: {Name}. Birth Date: {BirthDate}. Posiotion: {BirthDate}. Slary: {Salary}$\nWork: {company}";
        }
    }
}
