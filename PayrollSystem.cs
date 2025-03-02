using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_System
{
    class PayrollSystem
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
            Console.WriteLine("Employee added successfully!");
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("\nEmployee List:");
            foreach (var emp in employees)
            {
                emp.DisplayEmployee();
            }
        }

        public void ProcessPayroll()
        {
            Console.WriteLine("\nProcessing Payroll...");
            foreach (var emp in employees)
            {
                double grossSalery = emp.CalculateGrossSalery();
                double tax = Payroll.CalculateTax(grossSalery);
                double netSalery = Payroll.CalculateNetSalery(grossSalery);

                Console.WriteLine($"Payroll for {emp.Name}:");
                Console.WriteLine($"Gross Salery: {grossSalery:C}");
                Console.WriteLine($"Tax Deducted: {tax:C}");
                Console.WriteLine($"Net Salery: {netSalery:C}");
                Console.WriteLine("-----------------------------");
            }
        }


    }
}
