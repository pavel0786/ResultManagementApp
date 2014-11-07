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

        public bool EnrollCourseUpdateScoreAndResultDate(EnrollCourse aEnrollCourse)
        {
            return new EnrollCourseGateway().EnrollCourseUpdateScoreAndResultDate(aEnrollCourse);
        }

        public List<EnrollCourseView> GetCoursesByStudent(Student aStudent)
        {
            return new EnrollCourseGateway().GetCoursesByStudent(aStudent);
        }

        public string getGradeLatter(Student aStudent)
        {
            int average = GetAverage(aStudent);
            
            if (average >= 80)
                return "A+";
            else if (average >= 70) 
                return "A";
            else if (average >= 60)
                return "B+";
            else if (average >= 50)
                return "B";
            else if (average >= 40)
                return "D";
            else 
                return "F";
        }

        public int GetAverage(Student aStudent)
        {
            int TotalMark = 0;
            int TotalSubject = 0;
            List<EnrollCourseView> listEnrollCourse = new EnrollCourseGateway().GetCoursesByStudent(aStudent);
            if (listEnrollCourse.Count == 0)
                return 0;
            else
            {
                foreach (EnrollCourseView anEnrollCourseView in listEnrollCourse)
                {
                    if (anEnrollCourseView.Score >= 0)
                    {
                        TotalMark += Convert.ToInt32(anEnrollCourseView.Score);
                        TotalSubject++;
                    }
                }
                int average = TotalSubject>0? Convert.ToInt32(TotalMark/TotalSubject):0;
                return average;
            }
        }
    }
}
