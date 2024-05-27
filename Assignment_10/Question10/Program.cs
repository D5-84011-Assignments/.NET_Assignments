
using Question7;
using Question8;
using Question9; 


namespace Question10
{
    public class Supervisor : Employee
    {
        private int _subbordinates;

        public int subbordinates
        {
            get { return _subbordinates; }
            set { _subbordinates = value; }
        }

        public Supervisor() { }
        public Supervisor(int subbordinates) { this.subbordinates = subbordinates; }

        public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter subbordinates: ");
            subbordinates = Convert.ToInt32(Console.ReadLine());

        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("subbordinates= " + subbordinates);
        }

        public override string ToString()
        {
            return base.ToString() + "subbordinates= " + subbordinates;
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Supervisor s = new Supervisor();
                s.Accept();
                s.Print();
        }
    }
}
