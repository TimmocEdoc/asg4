using System;

namespace asg4
{
    public class ManagePhoneBook
    {
        public static void Main(String[] args)
        {
            PhoneBook p = new PhoneBook();
            while (true)
            {
                int choose;
                string name;
                string phone;
                Console.WriteLine("PHONEBOOK MANAGEMENT SYSTEM");
                Console.WriteLine("1| Insert Phone.");
                Console.WriteLine("2| Remove Phone.");
                Console.WriteLine("3| Update Phone.");
                Console.WriteLine("4| Search Phone.");
                Console.WriteLine("5| Exit.");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Phone:");
                        phone = Console.ReadLine();
                        p.insertPhone(name, phone);
                        break;
                    case 2:
                        Console.WriteLine("Enter name:");
                        name = Console.ReadLine();
                        p.DeletePhone(name);
                        break;
                    case 3:
                        Console.WriteLine("Enter name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Phone:");
                        phone = Console.ReadLine();
                        p.UpdatePhone(name, phone);
                        break;
                    case 4:
                        Console.WriteLine("Enter name:");
                        name = Console.ReadLine();
                        p.SearchPhone(name);
                        break;
                    case 5:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Error.");
                        break;
                }
            }
        }
    }
}