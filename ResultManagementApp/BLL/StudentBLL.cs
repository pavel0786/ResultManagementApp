using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResultManagementApp.DLL.DAO;
using ResultManagementApp.DLL.Gateway;

namespace ResultManagementApp.BLL
{
    class StudentBLL
    {
        public List<Student> GetAllStudent()
        {
            return new StudentGateway().GetAllStudent();
        }

        public Student GetStudentByStudentRegNo(string StudentRegNo)
        {
            return new StudentGateway().GetStudentByStudentRegNo(StudentRegNo);
        }
    }
}
