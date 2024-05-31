using Assignment12;
using Assignment13;
using Assignment6;
namespace Assign15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Company company = new Company();
            while ((choice = Menu.MyMenu()) != 0)
            {
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thank You");
                        break;
                    case 1:
                        company.Accept();
                        break;
                    case 2:
                        EmplyoeeLib? employee = new EmplyoeeLib();
                        employee.Accept();
                        company.AddEmployee(employee);
                        company.CalculateSalaryExpense();
                        break;
                    case 3:
                        Console.WriteLine("Enter Id for removing Emp: ");
                        company.RemoveEmployee(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Enter Id for Finding Emp: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        LinkedListNode<EmplyoeeLib>? emp = company.FindEmployee(id);
                        Console.WriteLine(emp.Value);
                        break;
                    case 5:
                        company.Print();
                        break;
                    case 6:
                        company.PrintEmployees();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
