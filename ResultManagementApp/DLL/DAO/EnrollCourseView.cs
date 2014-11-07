using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultManagementApp.DLL.DAO
{
    class EnrollCourseView
    {
        public int EnrollId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollDate { get; set; }
        public decimal Score { get; set; }
        public DateTime ResultPublicationDate { get; set; }

        public string CourseName { get; set; }
        public string CourseTitle { get; set; }

        public string StudentName { get; set; }
        public string StudentMail { get; set; }
        public string StudentRegNo { get; set; }

        public string GradeLatter
        {
            get
            {
                if (Score >= 80)
                    return "A+";
                else if (Score >= 70)
                    return "A";
                else if (Score >= 60)
                    return "B+";
                else if (Score >= 50)
                    return "B";
                else if (Score >= 40)
                    return "D";
                else if(Score>=0)
                    return "F";
                else
                    return "NA";
            }
            
        }


    }
}
