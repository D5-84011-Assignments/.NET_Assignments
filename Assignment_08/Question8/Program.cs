using Question7;

namespace Question8
{
    public enum DepartmentType { DAC = 1, DBDA, DMC };
    public class Employee : Person
    {
        private static int _id;
        private double _salary;
        private string _designation;
        private DepartmentType _dept;
        private static int auto_id=0;

        public DepartmentType dept
        {
            get { return _dept; }
            set { _dept = value; }
        }


        public string designation
        {
            get { return _designation; }
            set { _designation = value; }
        }


        public double salary
        {
            get { return _salary; }
            set { _salary = value; }
        }


        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Employee()
        {
            auto_id++;
            id = auto_id;
        }
        public Employee(int id, double salary, string designation)
        {
            this.id = id;
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;

        }

        public void Accept()
        {   
            base.Accept();
            Console.WriteLine("Enter salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter designation: ");
            designation = Console.ReadLine();
            Console.WriteLine("Enter deptname 1.DAC, 2.DBDA, 3.DMC");
            int ch = Convert.ToInt32(Console.ReadLine());
            dept = (DepartmentType)ch;


        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("id= " + id + " salary= " + salary + " designation= " + designation + " dept= " + dept);
        }

        public override string ToString()
        {
            return  "id= " + id+ " salary= "+ salary+" designation= "+designation+" dept= "+ dept;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Accept();
            e.Print();
            

        }
    }
}
