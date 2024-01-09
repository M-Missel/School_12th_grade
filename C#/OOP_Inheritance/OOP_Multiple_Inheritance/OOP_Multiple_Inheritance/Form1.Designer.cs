namespace OOP_Multiple_Inheritance
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Age = new System.Windows.Forms.TextBox();
            this.B_Create_Person = new System.Windows.Forms.Button();
            this.B_Person_Value = new System.Windows.Forms.Button();
            this.B_Student_Value = new System.Windows.Forms.Button();
            this.B_Create_Student = new System.Windows.Forms.Button();
            this.TB_Class = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.B_Teacher_Value = new System.Windows.Forms.Button();
            this.B_Create_Teacher = new System.Windows.Forms.Button();
            this.TB_Subject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(210, 32);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(158, 20);
            this.TB_Name.TabIndex = 2;
            // 
            // TB_Age
            // 
            this.TB_Age.Location = new System.Drawing.Point(210, 72);
            this.TB_Age.Name = "TB_Age";
            this.TB_Age.Size = new System.Drawing.Size(158, 20);
            this.TB_Age.TabIndex = 3;
            // 
            // B_Create_Person
            // 
            this.B_Create_Person.Location = new System.Drawing.Point(172, 117);
            this.B_Create_Person.Name = "B_Create_Person";
            this.B_Create_Person.Size = new System.Drawing.Size(75, 23);
            this.B_Create_Person.TabIndex = 4;
            this.B_Create_Person.Text = "create";
            this.B_Create_Person.UseVisualStyleBackColor = true;
            this.B_Create_Person.Click += new System.EventHandler(this.B_newPersonClick);
            // 
            // B_Person_Value
            // 
            this.B_Person_Value.Location = new System.Drawing.Point(293, 117);
            this.B_Person_Value.Name = "B_Person_Value";
            this.B_Person_Value.Size = new System.Drawing.Size(75, 23);
            this.B_Person_Value.TabIndex = 5;
            this.B_Person_Value.Text = "get Value";
            this.B_Person_Value.UseVisualStyleBackColor = true;
            this.B_Person_Value.Click += new System.EventHandler(this.B_getPerson);
            // 
            // B_Student_Value
            // 
            this.B_Student_Value.Location = new System.Drawing.Point(156, 229);
            this.B_Student_Value.Name = "B_Student_Value";
            this.B_Student_Value.Size = new System.Drawing.Size(75, 23);
            this.B_Student_Value.TabIndex = 9;
            this.B_Student_Value.Text = "get Value";
            this.B_Student_Value.UseVisualStyleBackColor = true;
            this.B_Student_Value.Click += new System.EventHandler(this.B_getStudent);
            // 
            // B_Create_Student
            // 
            this.B_Create_Student.Location = new System.Drawing.Point(28, 229);
            this.B_Create_Student.Name = "B_Create_Student";
            this.B_Create_Student.Size = new System.Drawing.Size(122, 23);
            this.B_Create_Student.TabIndex = 8;
            this.B_Create_Student.Text = "create Student";
            this.B_Create_Student.UseVisualStyleBackColor = true;
            this.B_Create_Student.Click += new System.EventHandler(this.B_newStudentClick);
            // 
            // TB_Class
            // 
            this.TB_Class.Location = new System.Drawing.Point(73, 184);
            this.TB_Class.Name = "TB_Class";
            this.TB_Class.Size = new System.Drawing.Size(158, 20);
            this.TB_Class.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class";
            // 
            // B_Teacher_Value
            // 
            this.B_Teacher_Value.Location = new System.Drawing.Point(412, 229);
            this.B_Teacher_Value.Name = "B_Teacher_Value";
            this.B_Teacher_Value.Size = new System.Drawing.Size(75, 23);
            this.B_Teacher_Value.TabIndex = 13;
            this.B_Teacher_Value.Text = "get Value";
            this.B_Teacher_Value.UseVisualStyleBackColor = true;
            this.B_Teacher_Value.Click += new System.EventHandler(this.B_getTeacher);
            // 
            // B_Create_Teacher
            // 
            this.B_Create_Teacher.Location = new System.Drawing.Point(291, 229);
            this.B_Create_Teacher.Name = "B_Create_Teacher";
            this.B_Create_Teacher.Size = new System.Drawing.Size(115, 23);
            this.B_Create_Teacher.TabIndex = 12;
            this.B_Create_Teacher.Text = "create Teacher";
            this.B_Create_Teacher.UseVisualStyleBackColor = true;
            this.B_Create_Teacher.Click += new System.EventHandler(this.B_newTeacherClick);
            // 
            // TB_Subject
            // 
            this.TB_Subject.Location = new System.Drawing.Point(329, 184);
            this.TB_Subject.Name = "TB_Subject";
            this.TB_Subject.Size = new System.Drawing.Size(158, 20);
            this.TB_Subject.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Subject";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 282);
            this.Controls.Add(this.B_Teacher_Value);
            this.Controls.Add(this.B_Create_Teacher);
            this.Controls.Add(this.TB_Subject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.B_Student_Value);
            this.Controls.Add(this.B_Create_Student);
            this.Controls.Add(this.TB_Class);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_Person_Value);
            this.Controls.Add(this.B_Create_Person);
            this.Controls.Add(this.TB_Age);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Age;
        private System.Windows.Forms.Button B_Create_Person;
        private System.Windows.Forms.Button B_Person_Value;
        private System.Windows.Forms.Button B_Student_Value;
        private System.Windows.Forms.Button B_Create_Student;
        private System.Windows.Forms.TextBox TB_Class;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_Teacher_Value;
        private System.Windows.Forms.Button B_Create_Teacher;
        private System.Windows.Forms.TextBox TB_Subject;
        private System.Windows.Forms.Label label4;
    }
}

