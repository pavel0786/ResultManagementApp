using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResultManagementApp.DLL.DAO;

namespace ResultManagementApp.DLL.Gateway
{
    class StudentGateway
    {
        public List<Student> GetAllStudent()
        {
            try
            {
                SqlConnection aConnection = new SqlConnection();
                aConnection.ConnectionString = DataConnect.ConnectionString;

                aConnection.Open();
                string query = "SELECT * FROM t_Student";
                SqlCommand aCommand = new SqlCommand(query, aConnection);

                SqlDataReader aReader = aCommand.ExecuteReader();
                List<Student> students = new List<Student>();


                if (aReader.HasRows)
                {
                    while (aReader.Read())
                    {
                        Student aStudent = new Student();
                        aStudent.StudentId = (int)aReader[0];
                        aStudent.StudentRegNo = aReader[1].ToString();
                        aStudent.StudentName = aReader[2].ToString();
                        aStudent.StudentMail = aReader[3].ToString();

                        students.Add(aStudent);
                    }

                }
                aConnection.Close();
                return students;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Student GetStudentByStudentRegNo(string StudentRegNo)
        {
            try
            {
                SqlConnection aConnection = new SqlConnection();
                aConnection.ConnectionString = DataConnect.ConnectionString;

                aConnection.Open();
                string query = "SELECT * FROM t_Student where StudentRegNo = " + StudentRegNo;
                SqlCommand aCommand = new SqlCommand(query, aConnection);

                SqlDataReader aReader = aCommand.ExecuteReader();
                List<Student> students = new List<Student>();

                Student aStudent = new Student();

                if (aReader.HasRows)
                {
                    while (aReader.Read())
                    {

                        aStudent.StudentId = (int) aReader[0];
                        aStudent.StudentRegNo = aReader[1].ToString();
                        aStudent.StudentName = aReader[2].ToString();
                        aStudent.StudentMail = aReader[3].ToString();
                    }
                }
                else
                {
                    aStudent = null;
                }
                aConnection.Close();
                return aStudent;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
