using System.Reflection;

namespace Question5
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
            Student[] s = new Student[CreateArray()];
            AcceptInfo(ref s);
            PrintInfo(ref s);

            Console.WriteLine("Reversed Array");
            ReverseArray(ref s);
            PrintInfo(ref s);


        }

        public static int CreateArray()
        {
            Console.WriteLine("Enter size of array: ");
            return Convert.ToInt32(Console.ReadLine());

        }

        public static void AcceptInfo(ref Student[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i].AcceptDetails();
            }
        }
        public static void PrintInfo(ref Student[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i].PrintDetails();
            }
        }

        public static void ReverseArray(ref Student[] s)
        {
            for (int i = 0; i < (s.Length / 2); i++)
            {
                Student temp = s[i];
                s[i] = s[s.Length - 1];
                s[s.Length - 1] = temp;
            }

        }


    }
}
