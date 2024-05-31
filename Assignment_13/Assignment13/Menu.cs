namespace Assignment6
{
    public class Menu
    {
        public static int MyMenu()
        {
            Console.WriteLine("Enter choice");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1. Accept Company Details");
            Console.WriteLine("2. Add Employe");
            Console.WriteLine("3. Remove Employee");
            Console.WriteLine("4. Find Employee");
            Console.WriteLine("5. Print Company Details");
            Console.WriteLine("6. Print Employees");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
