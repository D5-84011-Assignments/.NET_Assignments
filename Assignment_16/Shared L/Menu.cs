namespace Shared_L
{
    [Serializable]
    public class Menu
    {
        public static int MyMenu()
        {
            Console.WriteLine("Enter choice");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1. Add Employe");
            Console.WriteLine("2. Remove Employee");
            Console.WriteLine("3. Find Employee");
            Console.WriteLine("4. Print Employees");
            Console.WriteLine("5. Serialization of emp");
            Console.WriteLine("6. Deserialization of emp");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
