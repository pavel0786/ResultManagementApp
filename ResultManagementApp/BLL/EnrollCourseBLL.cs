using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResultManagementApp.DLL.DAO;
using ResultManagementApp.DLL.Gateway;

namespace ResultManagementApp.BLL
{
    class EnrollCourseBLL
    {
        public bool EnrollCourseInsert(EnrollCourse aEnrollCourse)
        {
            return new EnrollCourseGateway().EnrollCourseInsert(aEnrollCourse);
        }
        public bool SaveResultInsert(EnrollCourse aEnrollCourse)
        {
            return new EnrollCourseGateway().SaveResultInsert(aEnrollCourse);
        }

        public List<EnrollCourse> GetCourseByStudentID(int StudentID)
        {
            return new EnrollCourseGateway().GetCourseByStudentID(StudentID);
        }

        public List<EnrollCourse> GetAverageScoreByStudentID(int StudentID)
        {
            return new EnrollCourseGateway().GetCourseByStudentID(StudentID);
        }

        public List<EnrollCourse> GetAllEnrollCourses()
        {
            EnrollCourseGateway aCourseGateway = new EnrollCourseGateway();
            return aCourseGateway.GetAllEnrollCourses();
        }
    }
}
