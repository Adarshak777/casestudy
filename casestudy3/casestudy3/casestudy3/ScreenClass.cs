using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy3
{
    class ScreenClass : UserInterface1
    {
        HashSet<String> h = new HashSet<string>();
        Dictionary<string, string> user = new Dictionary<string, string>();       
        public void introduceNewCourseScreen()
        {
            Console.WriteLine("Enter course to add");
            string course = Console.ReadLine();
            h.Add(course);
            Console.WriteLine("New Course " + course + " added");
        }

        public void showAdminScreen()
        {
           Console.WriteLine("Welocome to Admin Screen");


            do
            {
               Console.WriteLine("Choose : \n1. Show All Students\n2. Introduce New Course\n3.UpdateCouse\n4.Show All Courses\n5.Exit");

                Console.WriteLine("Enter your choice ( 1 or 2 or 3 ) : ");

                int op2 = Convert.ToInt32(Console.ReadLine());
                if (op2== 1)
                {
                     showAllStudentsScreen();

                }
                if (op2 == 2)
                {
                    introduceNewCourseScreen();
                }
                if (op2 == 3)
                {
                    updateCourse();
                }
                if (op2 == 4)
                {
                    Console.WriteLine("----------------COURSES--------------------");
                    foreach (var x in h)
                    {
                        Console.WriteLine(x + "\n");
                    }
                    Console.WriteLine("-----------------------------------");

                }
                if (op2 > 4)
                {
                    showFirstScreen();           
                }

            } while (true);



        }

        public void showAllCoursesScreen()
        {
            
        
            Console.WriteLine("enter username");
            string uname = Console.ReadLine();
            Console.WriteLine("enter password");
            string pwd = Console.ReadLine();
            if (user.ContainsKey(uname))
            {
                foreach (KeyValuePair<string, string> x in user)
                {
                    if (x.Key == uname && x.Value == pwd)
                    {
                        Console.WriteLine("----------------COURSES--------------------");
                        foreach (string c in h)
                            Console.WriteLine(c + "\n");
                        Console.WriteLine("-----------------------------------");
                    }
                    else
                    {

                        Console.WriteLine("Invalid user");
                        Console.WriteLine("Try Again");
                        showAllCoursesScreen();
                    }
                }
            }
            else
            {
                Console.WriteLine("please register");
                showStudentRegistrationScreen();
            }
        }

        public void showAllStudentsScreen()
        {
            Console.WriteLine("--------------STUDENTS---------------------");

            foreach (KeyValuePair<string,string> x in user)
            {
                Console.WriteLine(x.Key);
            }
            Console.WriteLine("-----------------------------------");

        }

        public void showFirstScreen()
        {

            Console.WriteLine("Welcome to Student Management system");


            do
            {

                Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin\n 3.exit");

                Console.WriteLine("Enter your choice ( 1 or 2 or 3) : ");

                int op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {
                    showStudentScreen();

                }
                if (op == 2)
                {
                    showAdminScreen();
                }
                if (op > 2)
                {
                    Environment.Exit(0);
                }
            } while (true);

        }
        public   void showStudentRegistrationScreen()
        {
            Console.WriteLine("Welcome to Student Registration");
            Console.WriteLine("enter username ");
            String username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            user.Add(username, password);
            Console.WriteLine("Registration successfull");
        }

     public  void showStudentScreen()
        {
            Console.WriteLine("Welcome to Student Screen");
            do
            {

                

                Console.WriteLine("Choose : \n1. StudentRegistration\n2. AllCourses\n3.exit");

                Console.WriteLine("Enter your choice ( 1 or 2 or 3) : ");

                int op1 = Convert.ToInt32(Console.ReadLine());
                if (op1 == 1)
                {
                    showStudentRegistrationScreen();

                }
                if (op1 == 2)
                {
                    showAllCoursesScreen();
                }
                if(op1>2)
                {
                    showFirstScreen();                }
            } while (true);

        }

        public void updateCourse()
        {
            Console.WriteLine("old course name:");
            string oldCourse = Console.ReadLine();
            Console.WriteLine("New Course name");
            string newCourse = Console.ReadLine();
            if (h.Contains(oldCourse))
            {
                h.Remove(oldCourse);
                h.Add(newCourse);
            }
            else
            {
                Console.WriteLine("please enter right course name to update");

            }
            if (h.Contains(newCourse))
            {
                Console.WriteLine("course updated successfully");
                Console.WriteLine("Updated  Course");
                Console.WriteLine("----------------COURSES--------------------");
                foreach (var x in h)
                {
                        Console.WriteLine(x + "\n");
                }
                Console.WriteLine("-----------------------------------");

            }
        }
    }
}
