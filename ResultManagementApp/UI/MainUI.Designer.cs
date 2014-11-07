namespace ResultManagementApp.UI
{
    partial class MainUI
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
            this.showResultSheetButton = new System.Windows.Forms.Button();
            this.enterResultButton = new System.Windows.Forms.Button();
            this.enrollButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showResultSheetButton
            // 
            this.showResultSheetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showResultSheetButton.Location = new System.Drawing.Point(98, 169);
            this.showResultSheetButton.Name = "showResultSheetButton";
            this.showResultSheetButton.Size = new System.Drawing.Size(180, 48);
            this.showResultSheetButton.TabIndex = 5;
            this.showResultSheetButton.Text = "Show Result Sheet";
            this.showResultSheetButton.UseVisualStyleBackColor = true;
            this.showResultSheetButton.Click += new System.EventHandler(this.showResultSheetButton_Click);
            // 
            // enterResultButton
            // 
            this.enterResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterResultButton.Location = new System.Drawing.Point(98, 102);
            this.enterResultButton.Name = "enterResultButton";
            this.enterResultButton.Size = new System.Drawing.Size(180, 48);
            this.enterResultButton.TabIndex = 4;
            this.enterResultButton.Text = "Enter Result";
            this.enterResultButton.UseVisualStyleBackColor = true;
            this.enterResultButton.Click += new System.EventHandler(this.enterResultButton_Click);
            // 
            // enrollButton
            // 
            this.enrollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollButton.Location = new System.Drawing.Point(98, 37);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(180, 48);
            this.enrollButton.TabIndex = 3;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 309);
            this.Controls.Add(this.showResultSheetButton);
            this.Controls.Add(this.enterResultButton);
            this.Controls.Add(this.enrollButton);
            this.Name = "MainUI";
            this.Text = "Main UI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showResultSheetButton;
        private System.Windows.Forms.Button enterResultButton;
        private System.Windows.Forms.Button enrollButton;
    }
}