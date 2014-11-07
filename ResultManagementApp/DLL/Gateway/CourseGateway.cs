using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResultManagementApp.DLL.DAO;

namespace ResultManagementApp.DLL.Gateway
{
    class CourseGateway
    {
       
         public List<Course> GetAllCourses()
        {
            try
            {
                SqlConnection aConnection = new SqlConnection();
                aConnection.ConnectionString = DataConnect.ConnectionString;

                aConnection.Open();
                string query = "SELECT * FROM t_Course";
                SqlCommand aCommand = new SqlCommand(query, aConnection);

                SqlDataReader aReader = aCommand.ExecuteReader();
                List<Course> courses = new List<Course>();


                if (aReader.HasRows)
                {
                    while (aReader.Read())
                    {
                        Course aCourse = new Course();
                        aCourse.CourseId = (int)aReader[0];
                        aCourse.CourseName = aReader[1].ToString();
                        aCourse.CourseTitle = aReader[2].ToString();
                        courses.Add(aCourse);
                    }

                }
                aConnection.Close();
                return courses;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         public List<Course> GetAllCoursesByStudentId(int StudentID)
         {
             try
             {
                 SqlConnection aConnection = new SqlConnection();
                 aConnection.ConnectionString = DataConnect.ConnectionString;

                 aConnection.Open();
                 string query = @"select distinct(c.CourseName), c.CourseId, c.CourseTitle
                                from T_EnrollCourse E
                                inner join T_Student S on E.StudentId = s.StudentId
                                inner join T_Course c on c.CourseId = e.CourseId
                                where e.StudentId= " + StudentID;
                 SqlCommand aCommand = new SqlCommand(query, aConnection);

                 SqlDataReader aReader = aCommand.ExecuteReader();
                 List<Course> courses = new List<Course>();


                 if (aReader.HasRows)
                 {
                     while (aReader.Read())
                     {
                         Course aCourse = new Course();
                         //aCourse.CourseId = (int)aReader[0];
                         aCourse.CourseName = aReader[0].ToString();
                         //aCourse.CourseTitle = aReader[2].ToString();
                         courses.Add(aCourse);
                     }

                 }
                 aConnection.Close();
                 return courses;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
    }
}
