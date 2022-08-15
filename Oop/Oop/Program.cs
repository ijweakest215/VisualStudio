using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doc;
            Programmer pro;
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("[1] Doctor");
                Console.WriteLine("[2] Programmer");
                Console.WriteLine("[3] Exit");
                Console.Write("Option: ");
                string ch = Console.ReadLine();
                choice = Int32.Parse(ch);
                if (choice == 1)
                {
                    Console.Write("Enter ID Number: ");
                    string idText = Console.ReadLine();
                    int id = Int32.Parse(idText);
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Specialization: ");
                    string spec = Console.ReadLine();
                    Console.Write("Enter Days Worked: ");
                    string daysText = Console.ReadLine();
                    int days = Int32.Parse(daysText);
                    if (days <= 0 || days > 30)
                    {
                        Console.Write("INVALID NUMBER OF DAYS");
                    }
                    else
                    {
                        Console.WriteLine("\n\n");
                        doc = new Doctor(id, name, spec);
                        doc.calculateSalary(days);
                        doc.display();
                        Console.Write("\n\nPress any key to continue....");
                        Console.ReadLine();
                    }
                }
                else if (choice == 2)
                {
                    Console.Write("Enter ID Number: ");
                    string idText = Console.ReadLine();
                    int id = Int32.Parse(idText);
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Specialization: ");
                    string spec = Console.ReadLine();
                    Console.Write("Enter Days Worked: ");
                    string daysText = Console.ReadLine();
                    int days = Int32.Parse(daysText);
                    if (days <= 0 || days > 30)
                    {
                        Console.Write("INVALID NUMBER OF DAYS");
                    }
                    else
                    {
                        Console.WriteLine("\n\n");
                        pro = new Programmer(id, name, spec);
                        pro.calculateSalary(days);
                        pro.display();
                        Console.Write("\n\nPress any key to continue....");
                        Console.ReadLine();
                    }
                }
            } while (choice != 3);
            Console.Write("\n\nPress any key to continue....");
            Console.ReadLine();
        }
    }
}
