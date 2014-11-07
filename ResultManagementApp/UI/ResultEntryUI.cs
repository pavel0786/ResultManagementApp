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
                    nameTextBox.Text = aStudent.StudentName;
                    emailTextBox.Text = aStudent.StudentMail;

                    EnrollCourseBLL aEnrollCourseBll = new EnrollCourseBLL();
                    courseComboBox.DataSource = aEnrollCourseBll.GetCoursesByStudent(aStudent);
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
            if (courseComboBox.SelectedIndex >= 0)
            {
                EnrollCourse aEnrollCourse = new EnrollCourse();
                aEnrollCourse.EnrollId = (courseComboBox.SelectedValue as EnrollCourseView).EnrollId;
                aEnrollCourse.Score = Convert.ToDecimal(scoreTextBox.Text);
                aEnrollCourse.ResultPublicationDate = resultPublishingDateDateTimePicker.Value;
                if (new EnrollCourseBLL().EnrollCourseUpdateScoreAndResultDate(aEnrollCourse) == true)
                {
                    MessageBox.Show("Score and date updatd successfully");
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
        }

        private void viewResultSheetButton_Click(object sender, EventArgs e)
        {
            ResultSheetUI aResultSheetUi = new ResultSheetUI();
            aResultSheetUi.ShowDialog();
        }
    }
}
