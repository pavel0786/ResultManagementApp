namespace ResultManagementApp.UI
{
    partial class ResultSheetUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.courseEnrollmentGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gradeLetterTextBox = new System.Windows.Forms.TextBox();
            this.averageScoreTextBox = new System.Windows.Forms.TextBox();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.coursesDataGridView = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultGroupBox.SuspendLayout();
            this.courseEnrollmentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(186, 26);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 10;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(71, 92);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(190, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(71, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(190, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(71, 29);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.regNoTextBox.TabIndex = 5;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.coursesDataGridView);
            this.resultGroupBox.Location = new System.Drawing.Point(12, 171);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(518, 186);
            this.resultGroupBox.TabIndex = 15;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Result";
            // 
            // courseEnrollmentGroupBox
            // 
            this.courseEnrollmentGroupBox.Controls.Add(this.studentIdLabel);
            this.courseEnrollmentGroupBox.Controls.Add(this.label4);
            this.courseEnrollmentGroupBox.Controls.Add(this.label1);
            this.courseEnrollmentGroupBox.Controls.Add(this.label5);
            this.courseEnrollmentGroupBox.Controls.Add(this.findButton);
            this.courseEnrollmentGroupBox.Controls.Add(this.gradeLetterTextBox);
            this.courseEnrollmentGroupBox.Controls.Add(this.label2);
            this.courseEnrollmentGroupBox.Controls.Add(this.averageScoreTextBox);
            this.courseEnrollmentGroupBox.Controls.Add(this.label3);
            this.courseEnrollmentGroupBox.Controls.Add(this.emailTextBox);
            this.courseEnrollmentGroupBox.Controls.Add(this.nameTextBox);
            this.courseEnrollmentGroupBox.Controls.Add(this.regNoTextBox);
            this.courseEnrollmentGroupBox.Location = new System.Drawing.Point(12, 28);
            this.courseEnrollmentGroupBox.Name = "courseEnrollmentGroupBox";
            this.courseEnrollmentGroupBox.Size = new System.Drawing.Size(518, 130);
            this.courseEnrollmentGroupBox.TabIndex = 14;
            this.courseEnrollmentGroupBox.TabStop = false;
            this.courseEnrollmentGroupBox.Text = "Student Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Average Score (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Grade Letter";
            // 
            // gradeLetterTextBox
            // 
            this.gradeLetterTextBox.Location = new System.Drawing.Point(400, 55);
            this.gradeLetterTextBox.Name = "gradeLetterTextBox";
            this.gradeLetterTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeLetterTextBox.TabIndex = 19;
            // 
            // averageScoreTextBox
            // 
            this.averageScoreTextBox.Location = new System.Drawing.Point(400, 27);
            this.averageScoreTextBox.Name = "averageScoreTextBox";
            this.averageScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageScoreTextBox.TabIndex = 18;
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(267, 30);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(13, 13);
            this.studentIdLabel.TabIndex = 20;
            this.studentIdLabel.Text = "0";
            // 
            // coursesDataGridView
            // 
            this.coursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName});
            this.coursesDataGridView.Location = new System.Drawing.Point(17, 19);
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.Size = new System.Drawing.Size(483, 154);
            this.coursesDataGridView.TabIndex = 1;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "CourseName";
            this.CourseName.Name = "CourseName";
            // 
            // ResultSheetUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 380);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.courseEnrollmentGroupBox);
            this.Name = "ResultSheetUI";
            this.Text = "ResultSheetUI";
            this.resultGroupBox.ResumeLayout(false);
            this.courseEnrollmentGroupBox.ResumeLayout(false);
            this.courseEnrollmentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.GroupBox courseEnrollmentGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gradeLetterTextBox;
        private System.Windows.Forms.TextBox averageScoreTextBox;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.DataGridView coursesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;

    }
}