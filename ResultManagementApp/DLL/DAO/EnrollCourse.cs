using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultManagementApp.DLL.DAO
{
    class EnrollCourse
    {
        public int EnrollId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollDate { get; set; }

        public decimal Score { get; set; }
        public DateTime ResultPublicationDate { get; set; }
        
    }
}
