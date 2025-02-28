using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_System
{
    class Payroll
    {
        private const double TaxRate = 0.15; //15% tax
        public static double CalculateTax(double salery)
        {
            return salery * TaxRate;
        }

        public static double CalculateNetSalery(double salery)
        {
            double tax = CalculateTax(salery);
            return salery - tax;
        }
    }
}
