using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResultManagementApp.BLL;
using ResultManagementApp.DLL.DAO;

namespace ResultManagementApp.DLL.Gateway
{
    class EnrollCourseGateway



    {
        public bool EnrollCourseInsert(EnrollCourse aEnrollCourse)
        {
            try
            {
                SqlConnection aConnection = new SqlConnection();
                aConnection.ConnectionString = DataConnect.ConnectionString;

                aConnection.Open();
                string query = String.Format(@"insert into T_EnrollCourse
                                (
	                                StudentId,
	                                CourseId,
	                                EnrollDate
                                )
                                values
                                (
                                    '{0}',
                                    '{1}',
                                    '{2}'
                                )",aEnrollCourse.StudentId,aEnrollCourse.CourseId,aEnrollCourse.EnrollDate);

                SqlCommand aCommand = new SqlCommand(query, aConnection);

                int n = aCommand.ExecuteNonQuery();
                aConnection.Close();
                if (n > 0)
                    return true;
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EnrollCourse> GetAllEnrollCourses()
        {
            try
            {
                SqlConnection aConnection = new SqlConnection();
                aConnection.ConnectionString = DataConnect.ConnectionString;

                aConnection.Open();
                string query = @"select c.CourseName
                                from T_EnrollCourse E
                                inner join T_Student S on E.StudentId = s.StudentId
                                inner join T_Course c on c.CourseId = e.CourseId
                                where e.StudentId = ";
                SqlCommand aCommand = new SqlCommand(query, aConnection);

                SqlDataReader aReader = aCommand.ExecuteReader();
                List<EnrollCourse> courses = new List<EnrollCourse>();


                if (aReader.HasRows)
                {
                    while (aReader.Read())
                    {
                        EnrollCourse aCourse = new EnrollCourse();
                        aCourse.CourseId = (int)aReader[0];
                        aCourse.CourseName = aReader[1].ToString();
                        aCourse.EnrollDate = Convert.ToDateTime(aReader[2]);
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
        public bool SaveResultInsert(EnrollCourse aEnrollCourse)
        {
            try
            {
                SqlConnection aConnection = new SqlConnection();
                aConnection.ConnectionString = DataConnect.ConnectionString;

                aConnection.Open();
                string query = String.Format(@"insert into T_EnrollCourse
                                (
	                                StudentId,
	                                CourseId,
	                                Score,
                                    ResultPublicationDate
                                )
                                values
                                (
                                    '{0}',
                                    '{1}',
                                    '{2}',
                                    '{3}'
                                )", aEnrollCourse.StudentId, aEnrollCourse.CourseId, aEnrollCourse.Score,aEnrollCourse.ResultPublicationDate);

                SqlCommand aCommand = new SqlCommand(query, aConnection);

                int n = aCommand.ExecuteNonQuery();
                aConnection.Close();
                if (n > 0)
                    return true;
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EnrollCourse> GetCourseByStudentID(int StudentID)
        {
            try
            {
                SqlConnection aConnection = new SqlConnection();
                aConnection.ConnectionString = DataConnect.ConnectionString;

                aConnection.Open();
                string query = @"select c.CourseName
                                from T_EnrollCourse E
                                inner join T_Student S on E.StudentId = s.StudentId
                                inner join T_Course c on c.CourseId = e.CourseId
                                where e.StudentId = " + StudentID;
                SqlCommand aCommand = new SqlCommand(query, aConnection);
                SqlDataReader aReader = aCommand.ExecuteReader();
                List<EnrollCourse> enrollCourses = new List<EnrollCourse>();
                if (aReader.HasRows)
                {
                    while (aReader.Read())
                    {
                        EnrollCourse aEnrollCourse = new EnrollCourse();
                        aEnrollCourse.CourseName = aReader[0].ToString();
                        enrollCourses.Add(aEnrollCourse);
                    }

                }
                aConnection.Close();
                return enrollCourses;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public double GetAverageScoreByStudentID(int StudentID)
        //{
        //    ////try
        //    ////{
        //    ////    SqlConnection aConnection = new SqlConnection();
        //    ////    aConnection.ConnectionString = DataConnect.ConnectionString;

        //    ////    aConnection.Open();
        //    ////    string query = @"SELECT AVG(score) FROM T_EnrollCourse where StudentId" + StudentID;
        //    ////    SqlCommand aCommand = new SqlCommand(query, aConnection);
        //    ////    SqlDataReader aReader = aCommand.ExecuteReader();
               
        //    ////    if (aReader.HasRows)
        //    ////    {
        //    ////        while (aReader.Read())
        //    ////        {
        //    ////            EnrollCourse aEnrollCourse = new EnrollCourse();
        //    ////            aEnrollCourse.CourseName = aReader[0].ToString();
        //    ////            enrollCourses.Add(aEnrollCourse);
        //    ////        }

        //    ////    }
        //    ////    aConnection.Close();
        //    ////    return enrollCourses;
        //    ////}
        //    ////catch (Exception ex)
        //    ////{
        //    ////    throw ex;
        //    //}
        //}
    }
}
