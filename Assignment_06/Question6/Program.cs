namespace Question6
{

    class Date
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
    internal class Program
    {
        static void Main(string[] args)
        {

            Date d = new Date();

            d.AcceptDate();
            d.PrintDate();

            if (d.isValid())
            {
                Date d1 = new Date();

                d1.AcceptDate();
                d1.PrintDate();
                if (d1.isValid())
                {
                    Console.WriteLine("Difference between dates in years: " + (d1 - d));
                }
                else
                {
                    Console.WriteLine("Invalid Date..........");
                }

            }
            else
            {
                Console.WriteLine("Invalid Date..........");
            }

        }
    }
}
