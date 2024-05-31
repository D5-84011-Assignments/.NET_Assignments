using Shared_L;
using System.Runtime.Serialization.Formatters.Binary;
namespace Assignmnent16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String filepath = "F:\\Full Material\\5 MS.Net Technologies\\dotnet\\Daily Practice\\Demo02.txt";
            FileStream fs = null;
            int choice;
            List<EmplyoeeLib> emplist = new List<EmplyoeeLib>();
            String filepath = "F:\\Full_Material\\5_MS.Net_Technologies\\dotnet\\Daily_Practice\\May28\\Demo02.txt";
            while ((choice = Menu.MyMenu()) != 0)
            {
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("thank you");
                        break;
                    case 1:
                        {
                            Console.WriteLine("Adding Emp");
                            EmplyoeeLib emp = new EmplyoeeLib();
                            emp.Accept();
                            emplist.Add(emp);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Remove Emp");
                            Console.WriteLine("Enter Id for removing Emp: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine(" Find Employee");
                            Console.WriteLine("Enter id od Emp ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            int flag = 0;
                            foreach (EmplyoeeLib empp in emplist)
                            {
                                if (empp.Id == id)
                                {
                                    Console.WriteLine("Emp found");
                                    empp.Print();
                                    flag = 1;
                                    break;
                                }
                            }
                            if (flag == 0)
                                Console.WriteLine("Emp not found");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Printing all Employees");
                            foreach (EmplyoeeLib empp in emplist)
                            {
                                empp.Print();
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Serialization of emp");

                            if (File.Exists(filepath))
                            {
                                BinaryFormatter reader = new BinaryFormatter();

                                fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);

                                object obj1 = reader.Deserialize(fs);
                                List<EmplyoeeLib> emplist2 = new List<EmplyoeeLib>();
                                if (obj1 is List<EmplyoeeLib>)
                                {
                                    emplist2 = (List<EmplyoeeLib>)obj1;
                                    foreach (EmplyoeeLib item in emplist2)
                                    {
                                        item.Print();
                                    }
                                }
                                reader = null;
                                fs.Close();
                                File.Delete(filepath);
                                fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                            }
                            else
                            {
                                fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                            }
                            BinaryFormatter writer = new BinaryFormatter();
                            writer.Serialize(fs, emplist);
                            writer = null;
                            fs.Close();
                            fs = null;
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Deserialization of emp");

                            fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                            BinaryFormatter reader = new BinaryFormatter();
                            object obj = reader.Deserialize(fs);
                            List<EmplyoeeLib> emplist2 = new List<EmplyoeeLib>();
                            if (obj is List<EmplyoeeLib>)
                            {
                                emplist2 = (List<EmplyoeeLib>)obj;

                                foreach (EmplyoeeLib item in emplist2)
                                {
                                    item.Print();
                                }
                            }
                            reader = null;
                            fs.Close();
                            fs = null;
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
