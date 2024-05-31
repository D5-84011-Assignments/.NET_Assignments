namespace Assignment6
{
    class Menu
    {   
        public static int MyMenu() {
            Console.WriteLine("Enter choice");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1. Enter Details");
            Console.WriteLine("2. Print Details");
            Console.WriteLine("3. Print Details via String");
            Console.WriteLine("4. Calculate Age");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
