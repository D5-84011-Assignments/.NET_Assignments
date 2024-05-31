using Assignment8;

namespace Assignment9
{
    class WageEmp : Employee
    {
        int hours; int rate;

        public int Hours { get => hours; set => hours = value; }
        public int Rate { get => rate; set => rate = value; }

        public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Hours : ");
            Hours = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Enter Rate : ");
            Rate = Convert.ToInt32(Console.ReadLine());

        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("Hours is  : " + Hours); Console.WriteLine("Rate is  : " + Rate);

        }
        public string ToString()
        {
            return base.ToString() + " Hours is  : " + Hours + " Rate is  : " + Rate;
        }
        public WageEmp()
        {
            base.Designation = "Wage";
        }

        public WageEmp(int hours, int rate)
        {
            this.hours = hours;
            this.rate = rate;
            base.Designation = "Wage";

        }
    }
}
