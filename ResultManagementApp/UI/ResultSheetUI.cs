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
    public partial class ResultSheetUI : Form
    {
        public ResultSheetUI()
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
                    averageScoreTextBox.Text = new EnrollCourseBLL().GetAverage(aStudent).ToString();
                    gradeLetterTextBox.Text = new EnrollCourseBLL().getGradeLatter(aStudent).ToString();

                    coursesDataGridView.DataSource = new EnrollCourseBLL().GetCoursesByStudent(aStudent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResultSheetUI_Load(object sender, EventArgs e)
        {
            coursesDataGridView.AutoGenerateColumns = false;

        }

    }
}
