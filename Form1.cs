using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ArrayList task1ArrayList;
        private List<string> task2List;

        public Form1()
        {
            InitializeComponent();

            task1ArrayList = new ArrayList(); // For Task 1
            task2List = new List<string>();   // For Task 2
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void submitBTN_Click_1(object sender, EventArgs e)
        {
            // Task 1: Storing each value separately in the ArrayList
            string firstName = fName.Text;
            string lastName = lName.Text;
            string course = courseBox.Text;
            bool clear = checkbox.Checked;

            task1ArrayList.Add(firstName);
            task1ArrayList.Add(lastName);
            task1ArrayList.Add(course);
            task1ArrayList.Add(clear);

            // Task 2: Storing multi-line textbook entries or checkbox states
            string clearCourse = clear ? "Pre Requisite Cleared" : "Pre Requisite Not Cleared";
            string multiLineTextbook = GetMultiLineTextbook(firstName, lastName, course, clearCourse);
            task2List.Add(multiLineTextbook);

            // Display the submission
            string submission = GetSubmissionText(firstName, lastName, course, clearCourse);
            result.Text = submission;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Disable form resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private string GetMultiLineTextbook(string firstName, string lastName, string course, string clearCourse)
        {
            return $"{firstName}\n{lastName}\n{course}\n{clearCourse}";
        }

        private string GetSubmissionText(string firstName, string lastName, string course, string clearCourse)
        {
            return $"{firstName}\n{lastName}\n{course}\n{clearCourse}";
        }
    }
}
