namespace Employee_Payroll_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PayrollSystem payrollSystem = new PayrollSystem();

            while (true)
            {
                Console.WriteLine("\nEmployee Payroll System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display Employees");
                Console.WriteLine("3. Process Payroll");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Employee ID: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Position: ");
                        string position = Console.ReadLine();

                        Console.Write("Enter Base Salery: ");
                        double salery = double.Parse(Console.ReadLine());

                        Employee emp = new Employee(id, name, position, salery);
                        payrollSystem.AddEmployee(emp);
                        break;

                    case "2":
                        payrollSystem.DisplayEmployees();
                        break;

                    case "3":
                        payrollSystem.ProcessPayroll();
                        break;

                    case "4":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }
}
