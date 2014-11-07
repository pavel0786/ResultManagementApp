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

        public bool EnrollCourseUpdateScoreAndResultDate(EnrollCourse aEnrollCourse)
        {
            try
            {
                SqlConnection aConnection = new SqlConnection();
                aConnection.ConnectionString = DataConnect.ConnectionString;

                aConnection.Open();
                string query = String.Format(@"Update T_EnrollCourse
                            set Score = {0},
                            ResultPublicationDate = '{1}'
                            where EnrollId = {2}",aEnrollCourse.Score,aEnrollCourse.ResultPublicationDate,aEnrollCourse.EnrollId);

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
        public List<EnrollCourseView> GetCoursesByStudent(Student aStudent)
        {
            try
            {
                SqlConnection aConnection = new SqlConnection();
                aConnection.ConnectionString = DataConnect.ConnectionString;
                aConnection.Open();
                string query = String.Format(@"select *
                            from EnrollCourseView
                            where StudentId = {0}",aStudent.StudentId);

                SqlCommand aCommand = new SqlCommand(query, aConnection);
                SqlDataReader aReader = aCommand.ExecuteReader();
                List<EnrollCourseView> listEnrollCourseView = new List<EnrollCourseView>();

                if (aReader.HasRows)
                {
                    while (aReader.Read())
                    {
                        EnrollCourseView aEnrollCourseView = new EnrollCourseView();
                        aEnrollCourseView.EnrollId = int.Parse(aReader["EnrollId"].ToString());
                        aEnrollCourseView.StudentId = int.Parse(aReader["StudentId"].ToString());
                        aEnrollCourseView.CourseId = int.Parse(aReader["CourseId"].ToString());
                        if (aReader["EnrollDate"].ToString() != "")
                        {
                            aEnrollCourseView.EnrollDate = DateTime.Parse(aReader["EnrollDate"].ToString());
                        }
                        if (aReader["Score"].ToString() != "")
                        {
                            aEnrollCourseView.Score = decimal.Parse(aReader["Score"].ToString());
                        }
                        else
                        {
                            aEnrollCourseView.Score = -1;
                        }
                        if (aReader["ResultPublicationDate"].ToString() != "")
                        {
                            aEnrollCourseView.ResultPublicationDate = DateTime.Parse(aReader["ResultPublicationDate"].ToString());
                        }
                        aEnrollCourseView.StudentRegNo = aReader["StudentRegNo"].ToString();
                        aEnrollCourseView.StudentName = aReader["StudentName"].ToString();
                        aEnrollCourseView.StudentMail = aReader["StudentMail"].ToString();
                        aEnrollCourseView.CourseName = aReader["CourseName"].ToString();
                        aEnrollCourseView.CourseTitle = aReader["CourseTitle"].ToString();
                        listEnrollCourseView.Add(aEnrollCourseView);
                    }
                }
                aConnection.Close();
                return listEnrollCourseView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
