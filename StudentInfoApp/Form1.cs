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
        List<Studentinfo> studentsList = new List<Studentinfo>();
        public studentInfoForm()
        {
            InitializeComponent();
        }
        

        private void createButton_Click(object sender, EventArgs e)
        {
            //Create Student and add info
            Studentinfo student = new Studentinfo();
            student.studentId = int.Parse(studentIdTextBox.Text);
            student.StudentName = nameTextBox.Text;
            student.ClassTaken = classTakenTextBox.Text;
            //student.StudentGrade = decimal.Parse(gradeTextBox.Text);
            //Adds Students Name to List
            studentsList.Add(student);
            studentsTextBox.Text += $"{student.StudentName} {Environment.NewLine}";
            //Reset TextBox
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

            var opt = new JsonSerializerOptions() { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(studentsList, opt);
            File.WriteAllText($"{fileName}.json", jsonString);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
          
        }
        
        private void openSavedFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;
            using (var fileOpener = new OpenFileDialog())
            {
                result = fileOpener.ShowDialog();
                fileName = fileOpener.FileName;
            }
            string jsonString = File.ReadAllText(fileName);
            List<Studentinfo> students = JsonSerializer.Deserialize<List<Studentinfo>>(jsonString);

            studentsTextBox.Text = String.Empty;

            foreach (Studentinfo student in students)
            {
                studentsTextBox.Text += $"{student} {Environment.NewLine}";
                
            }
        }
    }
}
