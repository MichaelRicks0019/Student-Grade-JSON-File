using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.IO;

namespace StudentInfoApp
{
    public partial class studentInfoForm : Form
    {
        public studentInfoForm()
        {
            InitializeComponent();
        }
        IDictionary<string, Studentinfo> studentsList = new Dictionary<string, Studentinfo>();

        private void createButton_Click(object sender, EventArgs e)
        {
            Studentinfo student = new Studentinfo();
            student.studentId = int.Parse(studentIdTextBox.Text);
            student.StudentName = nameTextBox.Text;
            student.ClassTaken = classTakenTextBox.Text;
            student.StudentGrade = decimal.Parse(gradeTextBox.Text);

            studentsList.Add(student.StudentName, student);
            studentsTextBox.Text = studentsTextBox.Text + $"{student.StudentName}\n";
            studentIdTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            classTakenTextBox.Text = string.Empty;
            gradeTextBox.Text = string.Empty;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            studentIdTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            classTakenTextBox.Text = string.Empty;
            gradeTextBox.Text = string.Empty;
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;
            using (var fileChooser = new SaveFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }


            string jsonString = JsonSerializer.Serialize(studentsList);

           strea

            File.WriteAllText(fileName, jsonString);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            DialogResult result;
            string fileName;
            using (var fileChooser = new SaveFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
        }
    }
}
