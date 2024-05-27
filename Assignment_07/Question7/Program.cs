namespace Question7
{
    public class Date
    {

        public int year;
        public int month;
        public int day;

        public Date()
        {
        }
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public int day1 { get { return day; } set { day = value; } }
        public int month1 { get { return month; } set { month = value; } }
        public int year1 { get { return year; } set { year = value; } }


        public override string ToString()
        {
            return "day = " + day + "month = " + month + "year = " + year;
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine("Date: " + day + "/" + month + "/" + year);
        }

        public bool isValid()
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day <= 31)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day <= 30) { return true; }
                else { return false; }
            }
            else if (month == 2)
            {
                if (year % 4 == 0)
                {
                    if (year % 100 != 0 && year % 400 == 0) { return true; }
                    else { return false; }
                }
                else
                {
                    return false;
                }
            }



            return false;
        }

        public static int operator -(Date d1, Date d2)
        {
            return d1.year - d2.year;
        }


    }
    public class Person
    {
        string name;
        string gender;
        Date birth = new Date();
        string address;
        Date currdate = new Date(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        public Person() { }

        public Person(string name, string gender, Date birth, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = birth;
            this.address = address;
        }

        public string name1
        {
            get { return name; }

        }

        public string gender1
        {
            get { return gender; }
        }

        public Date birth1
        {
            get { return birth; }
        }

        public string address1
        {
            get { return address; }
        }

        public bool Accept()
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter gender: ");
            gender = Console.ReadLine();
            Console.WriteLine("Enter birth: ");
            birth.AcceptDate();
            if (birth.isValid())
            {
                Console.WriteLine("Enter address: ");
                address = Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Date............");
                return false;
            }
        }

        public void Print()
        {
            Console.WriteLine("Name: " + name + " Gender: " + gender + " Address: " + address + " Age: " + (currdate - birth));
            Console.WriteLine("Birth: ");
            birth.PrintDate();
        }

        public override string ToString()
        {
            return "Name: " + name + " Gender: " + gender + " Address: " + address;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            if (person.Accept())
            {
                person.Print();

            }

        }
    }
}
