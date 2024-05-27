using Question7;
using Question8;

namespace Question9
{   

    public class Manager: Employee
    {
        private double _bonus;

        public double bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }

        public Manager() { }
        public Manager(double bonus) { this.bonus = bonus; }

        public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter bonus: ");
            bonus = Convert.ToDouble(Console.ReadLine());

        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("bonus= " + bonus);
        }

        public override string ToString()
        {
            return base.ToString() + " bonus= " + bonus;
        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.Accept();
            m.Print();
        }
    }
}
