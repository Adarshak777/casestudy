using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2
{
    public class Student
    {
        private int studentId;
        private string studentName;
        private string dateOfBirth;
        public Student(int studentId, string studentName, string dateOfBirth)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.dateOfBirth = dateOfBirth;
        }
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
    }

}
