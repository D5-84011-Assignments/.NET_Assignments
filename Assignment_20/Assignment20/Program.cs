using System;
using System.Collections.Generic;

namespace Assignment20
{
    
public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        // Other employee properties
    }

    public class Company
    {
        private List<Employee> employees = new List<Employee>();

        // Event declaration
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

        // Other methods of the Company class

        public decimal CalculateTotalSalaryExpense()
        {
            decimal totalSalaryExpense = 0;
            foreach (var employee in employees)
            {
                // Calculate salary expense for each employee
                // For simplicity, let's assume there's a Salary property in Employee class
                totalSalaryExpense += employee.Salary;
            }
            return totalSalaryExpense;
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

            // Adding employees
            Employee emp1 = new Employee { Name = "John", Salary = 50000 };
            company.AddEmployee(emp1);

            Employee emp2 = new Employee { Name = "Alice", Salary = 60000 };
            company.AddEmployee(emp2);

            // Removing an employee
            company.RemoveEmployee(emp1);
        }
    }

}
