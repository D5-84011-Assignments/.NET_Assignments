using Assignment13;

namespace Assignment12
{
    public class Company
    {
        private string? name;
        private string? address;
        private LinkedList<EmplyoeeLib> employees = new LinkedList<EmplyoeeLib>();
        private static double salaryExpense;

        public void PrintEmployees()
        {
            Console.WriteLine("Employee of Company");
            foreach (EmplyoeeLib item in employees)
            {
                item.Print();
            }
        }

        public override string? ToString()
        {
            return name + address + salaryExpense;
        }

        public LinkedListNode<EmplyoeeLib>? FindEmployee(int id)
        {
            foreach (EmplyoeeLib emp in employees)
                if (emp.Id == id)
                    return new LinkedListNode<EmplyoeeLib>(emp);
            return null;
        }

        public void RemoveEmployee(int id)
        {
            int flag = 0;
            foreach (EmplyoeeLib emp in employees)
            {

                if (emp.Id == id)
                {
                    employees.Remove(emp);
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Employee not found");
            }
        }

        public void AddEmployee(EmplyoeeLib e)
        {
            employees.AddLast(e);
        }

        public void CalculateSalaryExpense()
        {
            salaryExpense = 0;
            foreach (EmplyoeeLib emp in employees)
            {
                salaryExpense = salaryExpense + emp.Salary;
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

        public Company(string name, string address, LinkedList<EmplyoeeLib> employees)
        {
            this.name = name;
            this.address = address;
            this.employees = employees;

        }

        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }
        public double SalaryExpense { get => salaryExpense; set => salaryExpense = value; }
        internal LinkedList<EmplyoeeLib> Employees { get => employees; set => employees = value; }
        #endregion
    }
}
