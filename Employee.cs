using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_System
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public double BaseSalery { get; set; }

        private CultureInfo culture = new CultureInfo("en-ZA");

        public Employee(int id, string name, string position, double baseSalery)
        {
            ID = id;
            Name = name;
            Position = position;
            BaseSalery = baseSalery;
        }

        public virtual double CalculateGrossSalery()
        {
            return BaseSalery; // Base implementation (can be overriden)
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Position: {Position}, Salery: {BaseSalery.ToString("C", culture)}");
        }
    }
}
