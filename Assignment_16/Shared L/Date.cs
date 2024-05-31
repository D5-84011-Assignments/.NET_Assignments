namespace Shared_L
{
    [Serializable]
    public class Date
    {
        #region Common
        private int day;
        private int month;
        private static int year;

        public Date()
        {
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;

        }

        public int Day
        {
            get => day;
            set => day = value;
        }
        public int Month { get => month; set => month = value; }
        public static int Year { get => year; set => year = value; }
        #endregion


        public int GetYear() { return year; }
        public void AcceptDate()
        {
            Console.WriteLine("Enter Day");
            Day = Convert.ToInt32(Console.ReadLine());
            if (day < 0 && day > 32) { Console.WriteLine("Enter valid day"); }
            Console.WriteLine("Enter Month");
            Month = Convert.ToInt32(Console.ReadLine());
            if (month < 0 && month > 13) { Console.WriteLine("Enter valid month"); }
            Console.WriteLine("Enter Year");
            Year = Convert.ToInt32(Console.ReadLine());
            if (year < 0 && year > 9999) { Console.WriteLine("Enter valid Year"); }
        }
        public static int CalculateAge()
        {
            return Convert.ToInt32(DateTime.Now.Year) - Year;

        }
        public void PrintDate()
        {
            Console.WriteLine("Date is: " + Day + "/" + Month + "/" + Year);
        }

        public override string ToString()
        {
            return "Date is: " + Day + "/" + Month + "/" + Year;
        }
    }
}
