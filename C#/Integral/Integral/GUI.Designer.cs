namespace Integral
{
    partial class GUI
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
            this.RB_Gerade = new System.Windows.Forms.RadioButton();
            this.RB_Parabel = new System.Windows.Forms.RadioButton();
            this.RB_Sinus = new System.Windows.Forms.RadioButton();
            this.TB_A = new System.Windows.Forms.TextBox();
            this.TB_B = new System.Windows.Forms.TextBox();
            this.TB_C = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_xMax = new System.Windows.Forms.TextBox();
            this.TB_XMin = new System.Windows.Forms.TextBox();
            this.BTN_Calc = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Flaeche = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funktionstyp";
            // 
            // RB_Gerade
            // 
            this.RB_Gerade.AutoSize = true;
            this.RB_Gerade.Location = new System.Drawing.Point(26, 52);
            this.RB_Gerade.Name = "RB_Gerade";
            this.RB_Gerade.Size = new System.Drawing.Size(60, 17);
            this.RB_Gerade.TabIndex = 1;
            this.RB_Gerade.TabStop = true;
            this.RB_Gerade.Text = "Gerade";
            this.RB_Gerade.UseVisualStyleBackColor = true;
            // 
            // RB_Parabel
            // 
            this.RB_Parabel.AutoSize = true;
            this.RB_Parabel.Location = new System.Drawing.Point(26, 75);
            this.RB_Parabel.Name = "RB_Parabel";
            this.RB_Parabel.Size = new System.Drawing.Size(61, 17);
            this.RB_Parabel.TabIndex = 2;
            this.RB_Parabel.TabStop = true;
            this.RB_Parabel.Text = "Parabel";
            this.RB_Parabel.UseVisualStyleBackColor = true;
            // 
            // RB_Sinus
            // 
            this.RB_Sinus.AutoSize = true;
            this.RB_Sinus.Location = new System.Drawing.Point(26, 98);
            this.RB_Sinus.Name = "RB_Sinus";
            this.RB_Sinus.Size = new System.Drawing.Size(51, 17);
            this.RB_Sinus.TabIndex = 3;
            this.RB_Sinus.TabStop = true;
            this.RB_Sinus.Text = "Sinus";
            this.RB_Sinus.UseVisualStyleBackColor = true;
            // 
            // TB_A
            // 
            this.TB_A.Location = new System.Drawing.Point(219, 52);
            this.TB_A.Name = "TB_A";
            this.TB_A.Size = new System.Drawing.Size(100, 20);
            this.TB_A.TabIndex = 4;
            // 
            // TB_B
            // 
            this.TB_B.Location = new System.Drawing.Point(219, 79);
            this.TB_B.Name = "TB_B";
            this.TB_B.Size = new System.Drawing.Size(100, 20);
            this.TB_B.TabIndex = 5;
            // 
            // TB_C
            // 
            this.TB_C.Location = new System.Drawing.Point(219, 105);
            this.TB_C.Name = "TB_C";
            this.TB_C.Size = new System.Drawing.Size(100, 20);
            this.TB_C.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "xMax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "xMin";
            // 
            // TB_xMax
            // 
            this.TB_xMax.Location = new System.Drawing.Point(380, 98);
            this.TB_xMax.Name = "TB_xMax";
            this.TB_xMax.Size = new System.Drawing.Size(100, 20);
            this.TB_xMax.TabIndex = 11;
            // 
            // TB_XMin
            // 
            this.TB_XMin.Location = new System.Drawing.Point(380, 72);
            this.TB_XMin.Name = "TB_XMin";
            this.TB_XMin.Size = new System.Drawing.Size(100, 20);
            this.TB_XMin.TabIndex = 10;
            // 
            // BTN_Calc
            // 
            this.BTN_Calc.Location = new System.Drawing.Point(26, 145);
            this.BTN_Calc.Name = "BTN_Calc";
            this.BTN_Calc.Size = new System.Drawing.Size(454, 47);
            this.BTN_Calc.TabIndex = 14;
            this.BTN_Calc.Text = "berechne Fläche";
            this.BTN_Calc.UseVisualStyleBackColor = true;
            this.BTN_Calc.Click += new System.EventHandler(this.clickBerechne);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Location = new System.Drawing.Point(405, 224);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(75, 23);
            this.BTN_Exit.TabIndex = 15;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.clickBeende);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fläche";
            // 
            // TB_Flaeche
            // 
            this.TB_Flaeche.Location = new System.Drawing.Point(219, 227);
            this.TB_Flaeche.Name = "TB_Flaeche";
            this.TB_Flaeche.Size = new System.Drawing.Size(100, 20);
            this.TB_Flaeche.TabIndex = 16;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 266);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_Flaeche);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_Calc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_xMax);
            this.Controls.Add(this.TB_XMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_C);
            this.Controls.Add(this.TB_B);
            this.Controls.Add(this.TB_A);
            this.Controls.Add(this.RB_Sinus);
            this.Controls.Add(this.RB_Parabel);
            this.Controls.Add(this.RB_Gerade);
            this.Controls.Add(this.label1);
            this.Name = "GUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RB_Gerade;
        private System.Windows.Forms.RadioButton RB_Parabel;
        private System.Windows.Forms.RadioButton RB_Sinus;
        private System.Windows.Forms.TextBox TB_A;
        private System.Windows.Forms.TextBox TB_B;
        private System.Windows.Forms.TextBox TB_C;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_xMax;
        private System.Windows.Forms.TextBox TB_XMin;
        private System.Windows.Forms.Button BTN_Calc;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Flaeche;
    }
}

