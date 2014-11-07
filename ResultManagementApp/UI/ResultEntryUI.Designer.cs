namespace ResultManagementApp.UI
{
    partial class ResultEntryUI
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
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.viewResultSheetButton = new System.Windows.Forms.Button();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.resultPublishingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // courseComboBox
            // 
            this.courseComboBox.DisplayMember = "CourseName";
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(144, 143);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(181, 21);
            this.courseComboBox.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(368, 199);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(250, 41);
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
            this.label2.Location = new System.Drawing.Point(99, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(144, 110);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(181, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Result Publishing Date";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(144, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(316, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(144, 42);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.regNoTextBox.TabIndex = 5;
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(144, 174);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.scoreTextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Score (%)";
            // 
            // viewResultSheetButton
            // 
            this.viewResultSheetButton.Location = new System.Drawing.Point(357, 42);
            this.viewResultSheetButton.Name = "viewResultSheetButton";
            this.viewResultSheetButton.Size = new System.Drawing.Size(103, 23);
            this.viewResultSheetButton.TabIndex = 19;
            this.viewResultSheetButton.Text = "View Result Sheet";
            this.viewResultSheetButton.UseVisualStyleBackColor = true;
            this.viewResultSheetButton.Click += new System.EventHandler(this.viewResultSheetButton_Click);
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(331, 47);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(13, 13);
            this.studentIdLabel.TabIndex = 20;
            this.studentIdLabel.Text = "0";
            // 
            // resultPublishingDateDateTimePicker
            // 
            this.resultPublishingDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.resultPublishingDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.resultPublishingDateDateTimePicker.Location = new System.Drawing.Point(144, 200);
            this.resultPublishingDateDateTimePicker.Name = "resultPublishingDateDateTimePicker";
            this.resultPublishingDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.resultPublishingDateDateTimePicker.TabIndex = 21;
            // 
            // ResultEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 245);
            this.Controls.Add(this.resultPublishingDateDateTimePicker);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.viewResultSheetButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.regNoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label4);
            this.Name = "ResultEntryUI";
            this.Text = "Result Entry UI";
            this.Load += new System.EventHandler(this.ResultEntryUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button viewResultSheetButton;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.DateTimePicker resultPublishingDateDateTimePicker;
    }
}