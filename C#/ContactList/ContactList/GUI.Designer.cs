namespace ContactList
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
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Number = new System.Windows.Forms.TextBox();
            this.BTN_Create_Contact = new System.Windows.Forms.Button();
            this.BTN_Show_All = new System.Windows.Forms.Button();
            this.LB_Output = new System.Windows.Forms.ListBox();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mobile number";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(146, 45);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 20);
            this.TB_Name.TabIndex = 2;
            // 
            // TB_Number
            // 
            this.TB_Number.Location = new System.Drawing.Point(146, 93);
            this.TB_Number.Name = "TB_Number";
            this.TB_Number.Size = new System.Drawing.Size(100, 20);
            this.TB_Number.TabIndex = 3;
            // 
            // BTN_Create_Contact
            // 
            this.BTN_Create_Contact.Location = new System.Drawing.Point(146, 137);
            this.BTN_Create_Contact.Name = "BTN_Create_Contact";
            this.BTN_Create_Contact.Size = new System.Drawing.Size(100, 23);
            this.BTN_Create_Contact.TabIndex = 4;
            this.BTN_Create_Contact.Text = "Create Contact";
            this.BTN_Create_Contact.UseVisualStyleBackColor = true;
            this.BTN_Create_Contact.Click += new System.EventHandler(this.BTN_Create_Contact_Click);
            // 
            // BTN_Show_All
            // 
            this.BTN_Show_All.Location = new System.Drawing.Point(146, 308);
            this.BTN_Show_All.Name = "BTN_Show_All";
            this.BTN_Show_All.Size = new System.Drawing.Size(100, 23);
            this.BTN_Show_All.TabIndex = 5;
            this.BTN_Show_All.Text = "Show all";
            this.BTN_Show_All.UseVisualStyleBackColor = true;
            this.BTN_Show_All.Click += new System.EventHandler(this.BTN_Show_All_Contacts_Click);
            // 
            // LB_Output
            // 
            this.LB_Output.FormattingEnabled = true;
            this.LB_Output.Location = new System.Drawing.Point(377, 28);
            this.LB_Output.Name = "LB_Output";
            this.LB_Output.Size = new System.Drawing.Size(411, 303);
            this.LB_Output.TabIndex = 6;
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Location = new System.Drawing.Point(688, 415);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(100, 23);
            this.BTN_Exit.TabIndex = 7;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.LB_Output);
            this.Controls.Add(this.BTN_Show_All);
            this.Controls.Add(this.BTN_Create_Contact);
            this.Controls.Add(this.TB_Number);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Number;
        private System.Windows.Forms.Button BTN_Create_Contact;
        private System.Windows.Forms.Button BTN_Show_All;
        private System.Windows.Forms.ListBox LB_Output;
        private System.Windows.Forms.Button BTN_Exit;
    }
}

