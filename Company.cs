using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR_Lab_8_Task_5
{
    internal class Company
    {
        public string Name { get; set; }
        public DateOnly FoundingYear { get; set; }

        public Company() { Name = string.Empty; FoundingYear = new DateOnly(1900, 1, 1); }
        public Company(string name, DateOnly foundingYear)
        {
            Name = name;
            if(foundingYear < DateOnly.FromDateTime(DateTime.Now)) { FoundingYear = foundingYear; }           
        }

        public override string ToString() 
        {
            return $"Company: {Name}. Founding year: {FoundingYear}";
        }  
    }
}
