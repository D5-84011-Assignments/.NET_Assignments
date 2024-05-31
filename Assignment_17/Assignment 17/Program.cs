using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
namespace Assignment_17
{
   

    [Serializable]
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        // Other employee properties
    }

    [Serializable]
    public class Company
    {
        private ArrayList employees = new ArrayList();

        public event EventHandler EmpListChanged;

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            OnEmpListChanged(EventArgs.Empty);
        }

        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
            OnEmpListChanged(EventArgs.Empty);
        }

        protected virtual void OnEmpListChanged(EventArgs e)
        {
            EmpListChanged?.Invoke(this, e);
        }

        public decimal CalculateTotalSalaryExpense()
        {
            decimal totalSalaryExpense = 0;
            foreach (Employee employee in employees)
            {
                totalSalaryExpense += employee.Salary;
            }
            return totalSalaryExpense;
        }

        // Serialization method
        public void Serialize(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                SoapFormatter formatter = new SoapFormatter();
                formatter.Serialize(fs, this);
            }
        }

        // Deserialization method
        public static Company Deserialize(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                SoapFormatter formatter = new SoapFormatter();
                return (Company)formatter.Deserialize(fs);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            // Event handler to update salary expense when employee list changes
            company.EmpListChanged += (sender, e) =>
            {
                Console.WriteLine("Employee list changed. Updating salary expense...");
                decimal totalSalaryExpense = company.CalculateTotalSalaryExpense();
                Console.WriteLine($"Total Salary Expense: {totalSalaryExpense}");
            };

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Serialize Company");
                Console.WriteLine("4. Deserialize Company");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter employee name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter employee salary: ");
                        decimal salary = Convert.ToDecimal(Console.ReadLine());
                        company.AddEmployee(new Employee { Name = name, Salary = salary });
                        break;
                    case "2":
                        Console.Write("Enter employee name to remove: ");
                        string empName = Console.ReadLine();
                        Employee employeeToRemove = company.Employees.Find(emp => emp.Name == empName);
                        if (employeeToRemove != null)
                        {
                            company.RemoveEmployee(employeeToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        break;
                    case "3":
                        Console.Write("Enter file path to serialize: ");
                        string serializeFilePath = Console.ReadLine();
                        company.Serialize(serializeFilePath);
                        Console.WriteLine("Company serialized successfully.");
                        break;
                    case "4":
                        Console.Write("Enter file path to deserialize: ");
                        string deserializeFilePath = Console.ReadLine();
                        Company deserializedCompany = Company.Deserialize(deserializeFilePath);
                        Console.WriteLine("Company deserialized successfully.");
                        // You can perform operations on deserializedCompany as needed
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

}
