
namespace StudentInfoApp
{
    partial class studentInfoForm
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
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.classTakenTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.classTakenLabel = new System.Windows.Forms.Label();
            this.StudentInfoPanel = new System.Windows.Forms.Panel();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.studentsTextBox = new System.Windows.Forms.TextBox();
            this.studentsLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openSavedFileButton = new System.Windows.Forms.Button();
            this.StudentInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(96, 38);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIdTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(96, 77);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // classTakenTextBox
            // 
            this.classTakenTextBox.Location = new System.Drawing.Point(96, 114);
            this.classTakenTextBox.Name = "classTakenTextBox";
            this.classTakenTextBox.Size = new System.Drawing.Size(100, 20);
            this.classTakenTextBox.TabIndex = 2;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(96, 151);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeTextBox.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(73, 41);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(16, 13);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "Id";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(54, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // classTakenLabel
            // 
            this.classTakenLabel.AutoSize = true;
            this.classTakenLabel.Location = new System.Drawing.Point(26, 117);
            this.classTakenLabel.Name = "classTakenLabel";
            this.classTakenLabel.Size = new System.Drawing.Size(63, 13);
            this.classTakenLabel.TabIndex = 6;
            this.classTakenLabel.Text = "ClassTaken";
            // 
            // StudentInfoPanel
            // 
            this.StudentInfoPanel.Controls.Add(this.openSavedFileButton);
            this.StudentInfoPanel.Controls.Add(this.saveToFileButton);
            this.StudentInfoPanel.Controls.Add(this.resetButton);
            this.StudentInfoPanel.Controls.Add(this.createButton);
            this.StudentInfoPanel.Controls.Add(this.gradeLabel);
            this.StudentInfoPanel.Controls.Add(this.classTakenTextBox);
            this.StudentInfoPanel.Controls.Add(this.studentIdTextBox);
            this.StudentInfoPanel.Controls.Add(this.classTakenLabel);
            this.StudentInfoPanel.Controls.Add(this.nameTextBox);
            this.StudentInfoPanel.Controls.Add(this.nameLabel);
            this.StudentInfoPanel.Controls.Add(this.gradeTextBox);
            this.StudentInfoPanel.Controls.Add(this.idLabel);
            this.StudentInfoPanel.Location = new System.Drawing.Point(408, 78);
            this.StudentInfoPanel.Name = "StudentInfoPanel";
            this.StudentInfoPanel.Size = new System.Drawing.Size(246, 324);
            this.StudentInfoPanel.TabIndex = 7;
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Location = new System.Drawing.Point(76, 243);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(105, 23);
            this.saveToFileButton.TabIndex = 10;
            this.saveToFileButton.Text = "Save To File";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(146, 203);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(43, 203);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(53, 154);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(36, 13);
            this.gradeLabel.TabIndex = 8;
            this.gradeLabel.Text = "Grade";
            // 
            // studentsTextBox
            // 
            this.studentsTextBox.Location = new System.Drawing.Point(67, 136);
            this.studentsTextBox.Multiline = true;
            this.studentsTextBox.Name = "studentsTextBox";
            this.studentsTextBox.ReadOnly = true;
            this.studentsTextBox.Size = new System.Drawing.Size(275, 218);
            this.studentsTextBox.TabIndex = 8;
            // 
            // studentsLabel
            // 
            this.studentsLabel.AutoSize = true;
            this.studentsLabel.Location = new System.Drawing.Point(67, 117);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(49, 13);
            this.studentsLabel.TabIndex = 9;
            this.studentsLabel.Text = "Students";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openSavedFileButton
            // 
            this.openSavedFileButton.Location = new System.Drawing.Point(76, 283);
            this.openSavedFileButton.Name = "openSavedFileButton";
            this.openSavedFileButton.Size = new System.Drawing.Size(105, 23);
            this.openSavedFileButton.TabIndex = 11;
            this.openSavedFileButton.Text = "Open Saved File";
            this.openSavedFileButton.UseVisualStyleBackColor = true;
            this.openSavedFileButton.Click += new System.EventHandler(this.openSavedFileButton_Click);
            // 
            // studentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 496);
            this.Controls.Add(this.studentsLabel);
            this.Controls.Add(this.studentsTextBox);
            this.Controls.Add(this.StudentInfoPanel);
            this.Name = "studentInfoForm";
            this.Text = "Student Info App";
            this.StudentInfoPanel.ResumeLayout(false);
            this.StudentInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox classTakenTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label classTakenLabel;
        private System.Windows.Forms.Panel StudentInfoPanel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox studentsTextBox;
        private System.Windows.Forms.Label studentsLabel;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button openSavedFileButton;
    }
}

