using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResultManagementApp.BLL;
using ResultManagementApp.DLL.DAO;

namespace ResultManagementApp.UI
{
    public partial class CourseEnrollmentUI : Form
    {
        public CourseEnrollmentUI()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                string regNo = regNoTextBox.Text;
                StudentBLL aStudentBll = new StudentBLL();
                Student aStudent = aStudentBll.GetStudentByStudentRegNo(regNo);
                if (aStudent == null)
                {
                    MessageBox.Show("Student not Found !!!");
                }
                else
                {
                    studentIdLabel.Text = aStudent.StudentId.ToString();
                    nameTextBox.Text = aStudent.StudentName;
                    emailTextBox.Text = aStudent.StudentMail;

                    EnrollCourseBLL aEnrollCourseBll = new EnrollCourseBLL();
                    List<EnrollCourse> enrollCourselist = aEnrollCourseBll.GetCourseByStudentID(aStudent.StudentId);
                    coursesDataGridView.DataSource = enrollCourselist;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CourseEnrollmentUI_Load(object sender, EventArgs e)
        {
            CourseBLL aCourseBll = new CourseBLL();
            List<Course> courses = new List<Course>();
            courses = aCourseBll.GetAllCourses();
            courseComboBox.DataSource = courses;
            coursesDataGridView.AutoGenerateColumns = false;
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            EnrollCourse aEnrollCourse=new EnrollCourse();
            aEnrollCourse.StudentId = Convert.ToInt32(studentIdLabel.Text);
            Course theCourse = courseComboBox.SelectedValue as Course;
            aEnrollCourse.CourseId = theCourse.CourseId;
            aEnrollCourse.EnrollDate = enrollmentDateDateTimePicker.Value;
            EnrollCourseBLL aEnrollCourseBll=new EnrollCourseBLL();
            bool b = false;
            b = aEnrollCourseBll.EnrollCourseInsert(aEnrollCourse);
            if (b == true)
            {
                MessageBox.Show("Insert Successfully !!");
            }
            else
            {
                MessageBox.Show("Insert failed !!");
            }
        }
    }
}
