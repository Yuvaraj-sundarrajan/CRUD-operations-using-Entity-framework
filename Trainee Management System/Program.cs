using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Ef_Traineemanagement
{
    class Program
    {
        public static void Main(String[] args)
        {
            while (true)
            {
                Console.WriteLine("\t\t\tTainee Management System");
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine("1.Insert\t 2.Print\t 3.Update\t 4.Remove\t 5.Exit ");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Create ob1 = new Create();
                        ob1.InsertData();
                        break;
                    case 2:
                        Read ob2 = new Read();
                        ob2.PrintData();
                        break;
                    case 3:
                        Update ob3 = new Update();
                        ob3.UpdateData();
                        break;
                    case 4:
                        Delete ob4 = new Delete();
                        ob4.RemoveData();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

    }

}