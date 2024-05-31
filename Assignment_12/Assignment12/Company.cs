using Assignment8;

namespace Assignment12
{
    class Company
    {
        private string? name;
        private string? address;
        private LinkedList<Employee> employees = new LinkedList<Employee>();
        private static double salaryExpense ;

        public void PrintEmployees()
        {
            Console.WriteLine("Employee of Company");
            foreach (Employee item in employees)
            {
                item.Print();
            }
        }

        public override string? ToString()
        {
            return name + address + salaryExpense;
        }

        public LinkedListNode<Employee>? FindEmployee(int id)
        {
            foreach (Employee emp in employees)
                if (emp.Id == id)
                    return new LinkedListNode<Employee>(emp);
            return null;
        }

        public void RemoveEmployee(int id)
        {
            int flag = 0;
            foreach (Employee emp in employees)
            {
              
                if (emp.Id == id)
                {
                    employees.Remove(emp);
                    flag = 1;
                    break;
                }
            }
            if (flag==0)
            {
                Console.WriteLine("Employee not found");
            }
        }

        public void AddEmployee(Employee e)
        {
            employees.AddLast(e);
        }

        public void CalculateSalaryExpense()
        {
            salaryExpense = 0;
            foreach (Employee emp in employees)
            {
                salaryExpense = salaryExpense+ emp.Salary;
            }
            this.SalaryExpense = salaryExpense;
            Console.WriteLine("Company Expence: " + this.SalaryExpense);
        }

        public void Print()
        {
            Console.WriteLine("--------------Company Details--------------");
            Console.WriteLine("Name of Company: " + Name);
            Console.WriteLine("Address of Company: " + Address);
            Console.WriteLine("SalaryExpense of Company: " + SalaryExpense);
            Console.WriteLine("------------------------------------------");

        }

        public void Accept()
        {
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Enter Name of Company: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Address of Company: ");
            Address = Console.ReadLine();
            CalculateSalaryExpense();
                        Console.WriteLine("----------------------------------------");

        }


        #region Ctor And Property
        public Company()
        {
        }

        public Company(string name, string address, LinkedList<Employee> employees)
        {
            this.name = name;
            this.address = address;
            this.employees = employees;
          
        }

        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }
        public double SalaryExpense { get => salaryExpense; set => salaryExpense = value; }
        internal LinkedList<Employee> Employees { get => employees; set => employees = value; }
        #endregion
    }
}
