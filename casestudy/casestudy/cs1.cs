using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CaseStudy



{
    public class Student 
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string DOB { get; set; } 
        public Student(int id, string name, string dob) 
        {
            Id = id;
            Name = name; 
            DOB = dob; 
        }
    }
    public class Course 
    {
        public int Id;
        public string Name;
        public int duration;
        public float fees; 
        public Course(int id, string name, int dura, float fee)
        {
            this.Id = id;
            this.Name = name;
            this.duration = dura; this.fees = fee;
        }
    } 
    public class Info 
    {
        public void display(Student student)
        {
            Console.WriteLine($"The student details is student id {student.Id}, student name {student.Name}, student dob {student.DOB}");
        }

        public void display(Course course) 
        
        {
            Console.WriteLine($"the student id {course.Id}, student name {course.Name}, couse duration is {course.duration}, corse fee is {course.fees}"); 
        }
    }
    class App 
    {
        Info info = new Info();
        public void Scenerio1() 
        {
            Student student = new Student(101, "Kranthi", "15/10/1998"); 
            Student student1 = new Student(102, "Shekar", "21/3/1999");
            info.display(student);
            info.display(student1); 
        }
        public void Scenerio2()
        {
            Student[] students = new Student[2];
            students[0] = new Student(1234, "Vinay", "26/3/1997");
            students[1] = new Student(2345, "Sunny", "09/10/2003");
            for (int i = 0; i < students.Length; i++)
            {
                info.display(students[i]);
            }
        }
        public void Scenerio3() 
        {
            Student[] student = new Student[3]; 
            for (int i = 0; i < student.Length; i++) 
            {
                Console.WriteLine("Enter Student Id,Name and Date of Birth"); 
                student[i] = new Student(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine()); 
            }
            for (int i = 0; i < student.Length; i++) 
            {
                info.display(student[i]); 
            }
            Console.ReadLine();
        }
        public void courseclass()
        {
            Course course = new Course(10, "sai", 30, 12000.00f); 
            info.display(course);
        }
        static void Main(string[] args) 
        {
            App app = new App();
            app.Scenerio1();
            app.Scenerio2();
            app.Scenerio3();
            app.courseclass();
            Console.Read(); 
        }
    }
}