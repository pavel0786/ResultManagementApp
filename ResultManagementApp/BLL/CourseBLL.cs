using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResultManagementApp.DLL.DAO;
using ResultManagementApp.DLL.Gateway;

namespace ResultManagementApp.BLL
{
    class CourseBLL
    {
        public List<Course> GetAllCourses()
        {
            CourseGateway aCourseGateway = new CourseGateway();
            return aCourseGateway.GetAllCourses();
        }
        public List<Course> GetAllCoursesByStudentId(int StudentID)
        {
            CourseGateway aCourseGateway = new CourseGateway();
            return aCourseGateway.GetAllCoursesByStudentId(StudentID);
        }
    }
}
