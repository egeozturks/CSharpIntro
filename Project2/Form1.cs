using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> students;

        private void Form1_Load(object sender, EventArgs e)
        {
            var studentListText = "Students List";
            var studentNameText = "Students Name";
            var addToStudentButton = "Add Student";
            var removeStudentFromList = "Remove Student";


            lblStudentList.Text = studentListText;
            lblStudentName.Text = studentNameText;
            btnAddStudent.Text = addToStudentButton;
            btnRemoveStudent.Text = removeStudentFromList;

            students = new List<string>() { "Engin Demirog", "Derin Demirog", "Salih Demirog" };

            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (tbxStudentName.Text.Length >= 6)
            {
                students.Add(tbxStudentName.Text);
                lbxStudentList.Items.Clear();
                tbxStudentName.Clear();

                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("Please, write a proper name");
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lbxStudentList.SelectedItem!=null)
            {
                students.Remove(lbxStudentList.SelectedItem.ToString());


                lbxStudentList.Items.Clear();

                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("Choose a student to remove");
            }
        }
    }
}
