using OOP_Multiple_Inheritance.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Multiple_Inheritance
{
    public partial class Form1 : Form
    {
        Person person;
        Student student;
        Teacher teacher;

        public Form1()
        {
            InitializeComponent();
        }

        public void B_newPersonClick(object sender, EventArgs e)
        {
            person = new Person(TB_Name.Text, Convert.ToInt32(TB_Age.Text));
        }

        public void B_getPerson()
        {
            MessageBox.Show($"Person: \n {person.Name}, {person.Age}");
        }

        public void B_newStudentClick(object sender, EventArgs e)
        {
            student = new Student(TB_Name.Text, Convert.ToInt32(TB_Age.Text), TB_Class.Text);
        }

        public void B_getStudent()
        {
            MessageBox.Show($"Student: \n {student.Name}, {student.Age}, {student.Class}");
        }

        public void B_newTeacherClick(object sender, EventArgs e)
        {
            teacher = new Teacher(TB_Name.Text, Convert.ToInt32(TB_Age.Text), TB_Subject.Text);
        }

        public void B_getTeacher()
        {
            MessageBox.Show($"Student: \n {teacher.Name}, {teacher.Age}, {teacher.Subject}");
        }
    }
}
