namespace ResultManagementApp.UI
{
    partial class CourseEnrollmentUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.enrollmentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.findButton = new System.Windows.Forms.Button();
            this.enrollButton = new System.Windows.Forms.Button();
            this.courseEnrollmentGroupBox = new System.Windows.Forms.GroupBox();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.EnrolledCoursesGroupBox = new System.Windows.Forms.GroupBox();
            this.coursesDataGridView = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrollDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseEnrollmentGroupBox.SuspendLayout();
            this.EnrolledCoursesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enrollment Date";
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(107, 32);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.regNoTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(107, 61);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(281, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(107, 95);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(191, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // courseComboBox
            // 
            this.courseComboBox.DisplayMember = "CourseName";
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(107, 128);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(191, 21);
            this.courseComboBox.TabIndex = 8;
            this.courseComboBox.SelectedIndexChanged += new System.EventHandler(this.courseComboBox_SelectedIndexChanged);
            // 
            // enrollmentDateDateTimePicker
            // 
            this.enrollmentDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.enrollmentDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.enrollmentDateDateTimePicker.Location = new System.Drawing.Point(107, 165);
            this.enrollmentDateDateTimePicker.Name = "enrollmentDateDateTimePicker";
            this.enrollmentDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.enrollmentDateDateTimePicker.TabIndex = 9;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(223, 31);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 10;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(313, 164);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(75, 23);
            this.enrollButton.TabIndex = 11;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // courseEnrollmentGroupBox
            // 
            this.courseEnrollmentGroupBox.Controls.Add(this.studentIdLabel);
            this.courseEnrollmentGroupBox.Controls.Add(this.courseComboBox);
            this.courseEnrollmentGroupBox.Controls.Add(this.enrollButton);
            this.courseEnrollmentGroupBox.Controls.Add(this.label1);
            this.courseEnrollmentGroupBox.Controls.Add(this.findButton);
            this.courseEnrollmentGroupBox.Controls.Add(this.label2);
            this.courseEnrollmentGroupBox.Controls.Add(this.enrollmentDateDateTimePicker);
            this.courseEnrollmentGroupBox.Controls.Add(this.label3);
            this.courseEnrollmentGroupBox.Controls.Add(this.label4);
            this.courseEnrollmentGroupBox.Controls.Add(this.emailTextBox);
            this.courseEnrollmentGroupBox.Controls.Add(this.label5);
            this.courseEnrollmentGroupBox.Controls.Add(this.nameTextBox);
            this.courseEnrollmentGroupBox.Controls.Add(this.regNoTextBox);
            this.courseEnrollmentGroupBox.Location = new System.Drawing.Point(22, 12);
            this.courseEnrollmentGroupBox.Name = "courseEnrollmentGroupBox";
            this.courseEnrollmentGroupBox.Size = new System.Drawing.Size(596, 204);
            this.courseEnrollmentGroupBox.TabIndex = 12;
            this.courseEnrollmentGroupBox.TabStop = false;
            this.courseEnrollmentGroupBox.Text = "Student Information";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(326, 36);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(13, 13);
            this.studentIdLabel.TabIndex = 12;
            this.studentIdLabel.Text = "0";
            // 
            // EnrolledCoursesGroupBox
            // 
            this.EnrolledCoursesGroupBox.Controls.Add(this.coursesDataGridView);
            this.EnrolledCoursesGroupBox.Location = new System.Drawing.Point(22, 235);
            this.EnrolledCoursesGroupBox.Name = "EnrolledCoursesGroupBox";
            this.EnrolledCoursesGroupBox.Size = new System.Drawing.Size(596, 211);
            this.EnrolledCoursesGroupBox.TabIndex = 13;
            this.EnrolledCoursesGroupBox.TabStop = false;
            this.EnrolledCoursesGroupBox.Text = "Enrolled Courses";
            // 
            // coursesDataGridView
            // 
            this.coursesDataGridView.AllowUserToAddRows = false;
            this.coursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.CourseTitle,
            this.EnrollDate});
            this.coursesDataGridView.Location = new System.Drawing.Point(19, 19);
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.Size = new System.Drawing.Size(557, 186);
            this.coursesDataGridView.TabIndex = 0;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "CourseName";
            this.CourseName.Name = "CourseName";
            // 
            // CourseTitle
            // 
            this.CourseTitle.DataPropertyName = "CourseTitle";
            this.CourseTitle.HeaderText = "CourseTitle";
            this.CourseTitle.Name = "CourseTitle";
            // 
            // EnrollDate
            // 
            this.EnrollDate.DataPropertyName = "EnrollDate";
            dataGridViewCellStyle2.Format = "dd-MM-yyyy";
            this.EnrollDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.EnrollDate.HeaderText = "EnrollDate";
            this.EnrollDate.Name = "EnrollDate";
            // 
            // CourseEnrollmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 457);
            this.Controls.Add(this.EnrolledCoursesGroupBox);
            this.Controls.Add(this.courseEnrollmentGroupBox);
            this.Name = "CourseEnrollmentUI";
            this.Text = "Course Enrollment";
            this.Load += new System.EventHandler(this.CourseEnrollmentUI_Load);
            this.courseEnrollmentGroupBox.ResumeLayout(false);
            this.courseEnrollmentGroupBox.PerformLayout();
            this.EnrolledCoursesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.DateTimePicker enrollmentDateDateTimePicker;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.GroupBox courseEnrollmentGroupBox;
        private System.Windows.Forms.GroupBox EnrolledCoursesGroupBox;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.DataGridView coursesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollDate;
    }
}