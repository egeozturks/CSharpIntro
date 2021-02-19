using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.FirstName = "Engin";
            student1.Age = 35;
            student1.Mail = "engin@";

            Student student2 = new Student();
            student2.FirstName = "Derin";
            student2.Age = 6;
            student2.Mail = "derin@";

            Student student3 = new Student();
            student3.FirstName = "Salih";
            student3.Age = 33;
            student3.Mail = "salih@";

            List<Student> students = new List<Student>() { student1, student2, student3 };

            foreach (var student in students)
            {
                //MessageBox.Show(student.FirstName + " " + student.Age);
                lbxStudents.Items.Add(student.FirstName);
            }

            dgrwStudents.DataSource = students;
        }


    }
}
