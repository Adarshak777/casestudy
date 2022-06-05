using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy4
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper h = new Helper();

            Console.WriteLine("WELCOME");
            do { 
                Console.WriteLine("1.Insert student\n2.Delete Student\n3.Get Details\n4.StudentsDetails\n5.Exit");
                Console.WriteLine("enter option");
                int op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    student s = new student();
                    Console.WriteLine("Enter Id");
                    s.studentId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Name");
                    s.name = Console.ReadLine();
                    Console.WriteLine("Enter age");
                    s.age = Convert.ToInt32(Console.ReadLine());
                   int result= h.InsertStudent(s);
                    if (result == 1)
                    {
                        Console.WriteLine("Inserted Successfully");
                    }

                }
                if(op==2)
                {
                    Console.WriteLine("Enter id to delete");
                    int id = Convert.ToInt32(Console.ReadLine());
                    int res= h.DeleteStudent(id);
                    if (res == 1)
                    {
                        Console.WriteLine("Deleted Successfully");
                    }
                }
                if (op == 3)
                {
                    Console.WriteLine("Enter id to get Details");
                    int id = Convert.ToInt32(Console.ReadLine());
                  student s =  h.GetDetails(id);
                    Console.WriteLine("------------------");
                    Console.WriteLine("STUDENTID  NAME  AGE");
                    Console.WriteLine("  "+s.studentId+"          "+s.name+"      "+s.age);
                    Console.WriteLine("------------------");

                }
                if (op == 4)
                {
                    List<student> l1 = new List<student>();
                    l1 = h.Details();
                    Console.WriteLine("------------------");
                    Console.WriteLine("STUDENTID    NAME   AGE");

                    foreach (var x in l1)
                    {
                        Console.WriteLine("  " + x.studentId + "            " + x.name + "     " + x.age);

                    }
                    Console.WriteLine("------------------");

                }
                if (op == 5)
                {
                    Environment.Exit(0);
                }
            } while (true);
        }
    }
}
