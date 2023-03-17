using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student st = new Student();
            while (true)
            {
                Console.WriteLine("\nPlease select an option");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Insert new student....");
                Console.WriteLine("2. Display all student list...");
                Console.WriteLine("3. Calculator average mark");
                Console.WriteLine("4. Finding Student");
                Console.WriteLine("5. Exit.");
                Console.WriteLine("==================================");
                Console.Write("Option:");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Insert new student....");
                        st.InsertStudent();
                        Console.WriteLine("\nSuccess!");
                        break;
                    case 2:
                        Console.WriteLine("\n2.Display all student list...");
                        st.Print(st.getStudentList());
                        Console.WriteLine("\nSuccess!");
                        break;
                    case 3:
                        Console.WriteLine("\n3. Calculator average mark");
                        st.CalAvg();
                        st.Print();
                        Console.WriteLine("\nSuccess!");
                        break;
                    case 4:
                        Console.WriteLine("\n4. Finding Student");
                        Console.WriteLine("Find by:");
                        Console.WriteLine("1. Find by ID:");
                        Console.WriteLine("2. Find by Name:");
                        Console.WriteLine("3. Find by Class:");
                        Console.Write("Option:");
                        int find = Convert.ToInt32(Console.ReadLine());
                        switch (find)
                        {
                            case 1:
                                Console.WriteLine("\nFind by ID:");
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("\nFind by Name:");
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("\nFind by Class:");
                                Console.ReadLine();
                                break;
                        }
                                Console.WriteLine("\nSuccess!");
                        break;
                    case 5:
                        Console.WriteLine("\nClosing Program!");
                        Environment.Exit(0);
                        break;
                }
            }
 
            
        }
    }
}
