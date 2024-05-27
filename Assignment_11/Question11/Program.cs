using Question8;
using Question7;
using Question9;

namespace Question11
{
    public class WageEmp : Employee
    {
        private int _hours;
        private int _rate;

        public int rate
        {
            get { return _rate; }
            set { _rate = value; }
        }


        public int hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        public WageEmp() { }
        public WageEmp(int hours, int rate) { this.hours = hours; this.rate = rate; }

        public void Accept()
        {   
            base.Accept();  
            Console.WriteLine("Enter hours: ");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate: ");
            rate = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("hours= " + hours + " rate= " + rate);
        }

        public override string ToString()
        {
            return base.ToString() + "hours= " + hours + " rate= " + rate;
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            WageEmp emp = new WageEmp();
            emp.Accept();
            emp.Print();
        }
    }
}
