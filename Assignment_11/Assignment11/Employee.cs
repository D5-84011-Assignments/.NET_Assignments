using Assignment7;
using Microsoft.VisualBasic;

namespace Assignment8
{
    partial class Employee : Person
    {
        private readonly  int id;
        private double salary;
        private string designation;
        private DepartmentType dept;
        private static int count = 100;
        public void Accept()
        {
            int i = 0;
            base.Accept();
           
            Console.WriteLine("Enter salary ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Dept ");
            foreach (Enum item in Enum.GetValues(typeof(DepartmentType)))
            {
                Console.WriteLine(i + " for " + item);
                i++;
            }
            int j = Convert.ToInt32(Console.ReadLine());
            foreach (Enum item in Enum.GetValues(typeof(DepartmentType)))
            {
                if (Convert.ToInt32(item) == j)
                {
                    Dept = (DepartmentType)item;
                }
            }

        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("ID " + Id);
            Console.WriteLine("Salary " + Salary);
            Console.WriteLine("Designation " + Designation);
            Console.WriteLine("Department " + Dept);
        }
        public Employee( int id,double salary, string designation, DepartmentType dept)
        {
            id = count++;
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;
        }

        public int Id { get => id;  }
        public double Salary { get => salary; set => salary = value; }
        public string Designation { get => designation; set => designation = value; }
        private DepartmentType Dept { get => dept; set => dept = value; }

        public Employee()
        {
            id = count++;
        }
    }
}
