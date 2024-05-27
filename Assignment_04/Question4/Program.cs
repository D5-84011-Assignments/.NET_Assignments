namespace Question4
{
    public struct Student
    {
        string name;
        string gender;
        int age;
        int std;
        char div;
        double marks;

        public Student()
        {
            name = "ABC";
            gender = "Male";
            age = 10;
            std = 10;
            div = 'a';
            marks = 90;
        }

        public Student(string name, string gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public string name1
        {
            get { return name; }
            set { name = value; }
        }

        public string gender1
        {
            get { return gender; }
            set { gender = value; }
        }

        public int age1
        {
            get { return age; }
            set { age = value; }
        }

        public int std1
        {
            get { return std; }
            set { std = value; }
        }

        public char div1
        {
            get { return div; }
            set { div = value; }
        }

        public double marks1
        {
            get { return marks; }
            set { marks = value; }
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter gender: ");
            gender = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter std: ");
            std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter div: ");
            div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter marks: ");
            marks = Convert.ToDouble(Console.ReadLine());

        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: " + name + " Gender: " + gender + " Age: " + age + " Std: " + std + " Div: " + div + " Marks: " + marks);
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            s.AcceptDetails();
            s.PrintDetails();

        }
    }
}
