using System.Reflection;

[assembly:AssemblyKeyFile("Key.snk")]

namespace Shared_L
{
    [Serializable]
    public partial class EmplyoeeLib : Person
    {
        #region Feilds
        private readonly int id;
        private double salary;
        private string? designation;
        private DepartmentType? dept;
        private static int count = 100; 
        #endregion

        public new void Accept()
        {
            //id = count++;
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

            Console.WriteLine("----------------------------------------");

        }
        public override string ToString()
        {
            return "ID " + Id + "Salary " + Salary + " Department " + Dept;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("ID " + Id);
            Console.WriteLine("Salary " + Salary);
            Console.WriteLine("Designation " + Designation);
            Console.WriteLine("Department " + Dept);
            Console.WriteLine("----------------------------------------");

        }

        #region Ctor and Proprty
        public EmplyoeeLib(int id, double salary, string designation, DepartmentType dept)
        {
            id = count++;
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;
        }

        public int Id { get => id; }
        public double Salary { get => salary; set => salary = value; }
        public string? Designation { get => designation; set => designation = value; }
        private DepartmentType? Dept { get => dept; set => dept = value; }

        public EmplyoeeLib()
        {
            id = count++;

        }
        #endregion
    }
}
