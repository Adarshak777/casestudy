using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy4
{
    public class Helper : StudentInterface
    {
        string connectionString = "Server=RMGW58ZLPC0863\\SQLEXPRESS;Database=Student;User Id=sa; Password= Temp1234";

        public int DeleteStudent(int id)
        { 
            using(SqlConnection con=new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Delete  from Details where StudentId=@id", con);
                command.Parameters.AddWithValue("@id", id);
                con.Open();
                int res = command.ExecuteNonQuery();
                con.Close();
                return res;
            }
             
        }

        public List<student> Details()
        {
            List<student> l = new List<student>();
            using(SqlConnection con=new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Details", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    student s = new student();
                    s.studentId = Convert.ToInt32(reader["StudentId"]);
                    s.name = reader["Name"].ToString();
                    s.age = Convert.ToInt32(reader["age"]);
                    l.Add(s);
                }
                con.Close();
            }
            return l;
        }

        public student GetDetails(int id)
        {
            student student = new student();
            using(SqlConnection con=new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Details where StudentId=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    student.studentId = Convert.ToInt32(reader["StudentId"]);
                    student.name = Convert.ToString(reader["Name"]);
                    student.age = Convert.ToInt32(reader["age"]);
                    
                }
                con.Close();
            }
            return student;
        }

        public int InsertStudent(student student)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Insert into Details(StudentId,Name,age)  Values(@StudentId,@Name,@age)", con);
                cmd.Parameters.AddWithValue("@StudentId", student.studentId);
                cmd.Parameters.AddWithValue("@Name", student.name);
                cmd.Parameters.AddWithValue("@age", student.age);
                con.Open();
               int res= cmd.ExecuteNonQuery();
                con.Close();
                return res;
            }

        }
    }
}
