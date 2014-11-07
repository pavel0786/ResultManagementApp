using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResultManagementApp.BLL;
using ResultManagementApp.DLL.DAO;

namespace ResultManagementApp.UI
{
    public partial class ResultEntryUI : Form
    {
        public ResultEntryUI()
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
                    CourseBLL aCourseBll = new CourseBLL();
                    List<Course> courses = new List<Course>();
                    courses = aCourseBll.GetAllCoursesByStudentId(aStudent.StudentId);
                    courseComboBox.DataSource = courses;

                    
                    nameTextBox.Text = aStudent.StudentName;
                    emailTextBox.Text = aStudent.StudentMail;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResultEntryUI_Load(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            EnrollCourse aEnrollCourse = new EnrollCourse();
            aEnrollCourse.StudentId = Convert.ToInt32(studentIdLabel.Text);
            Course theCourse = courseComboBox.SelectedValue as Course;
            aEnrollCourse.CourseId = theCourse.CourseId;
            aEnrollCourse.Score = Convert.ToDecimal(scoreTextBox.Text);
            aEnrollCourse.ResultPublicationDate = resultPublishingDateDateTimePicker.Value;
            EnrollCourseBLL aEnrollCourseBll = new EnrollCourseBLL();
            bool b = false;
            b = aEnrollCourseBll.SaveResultInsert(aEnrollCourse);
            if (b == true)
            {
                MessageBox.Show("Insert Successfully !!");
            }
            else
            {
                MessageBox.Show("Insert failed !!");
            }
        }

        private void viewResultSheetButton_Click(object sender, EventArgs e)
        {
            ResultSheetUI aResultSheetUi = new ResultSheetUI();
            aResultSheetUi.ShowDialog();
        }
    }
}
