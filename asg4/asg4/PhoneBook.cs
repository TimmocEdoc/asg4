using System;
using System.Collections.Generic;

namespace asg4
{
    public class PhoneBook : Phone
    {
        public List<PhoneNumber> PhoneList = new List<PhoneNumber>();
        
        public override void insertPhone(string name, string phone)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    if (p.Phone != phone)
                    {
                        p.Phone += ":" + phone;
                        Console.WriteLine("Success!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Error: Duplicate phone number.");
                        return;
                    }
                }
            }
            PhoneList.Add(new PhoneNumber(name, phone));
        }

        public override void DeletePhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    PhoneList.Remove(p);
                    Console.WriteLine("Success!");
                    return;
                }
            }
            Console.WriteLine("Error: No such name found.");
        }

        public override void UpdatePhone(string name, string newPhone)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    p.Phone = newPhone;
                    Console.WriteLine("Success!");
                    return;
                }
            }
            Console.WriteLine("Error: No such name found.");
        }

        public override void SearchPhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    Console.WriteLine("Success!");
                    Console.WriteLine("Name: "+p.Name+".");
                    Console.WriteLine("Phone: " + p.Phone + ".");
                    return;
                }
            }
            Console.WriteLine("Error: No such name found.");
        }
    }
}