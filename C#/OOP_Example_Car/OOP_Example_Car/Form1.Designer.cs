namespace OOP_Example_Car
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
            this.BTN_Create = new System.Windows.Forms.Button();
            this.BTN_Set = new System.Windows.Forms.Button();
            this.BTN_Get = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.TB_Color = new System.Windows.Forms.TextBox();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Create
            // 
            this.BTN_Create.Location = new System.Drawing.Point(29, 21);
            this.BTN_Create.Name = "BTN_Create";
            this.BTN_Create.Size = new System.Drawing.Size(75, 23);
            this.BTN_Create.TabIndex = 0;
            this.BTN_Create.Text = "Create";
            this.BTN_Create.UseVisualStyleBackColor = true;
            this.BTN_Create.Click += new System.EventHandler(this.BTN_Create_Click);
            // 
            // BTN_Set
            // 
            this.BTN_Set.Location = new System.Drawing.Point(29, 50);
            this.BTN_Set.Name = "BTN_Set";
            this.BTN_Set.Size = new System.Drawing.Size(75, 23);
            this.BTN_Set.TabIndex = 1;
            this.BTN_Set.Text = "Set Value";
            this.BTN_Set.UseVisualStyleBackColor = true;
            this.BTN_Set.Click += new System.EventHandler(this.BTN_Set_Click);
            // 
            // BTN_Get
            // 
            this.BTN_Get.Location = new System.Drawing.Point(29, 79);
            this.BTN_Get.Name = "BTN_Get";
            this.BTN_Get.Size = new System.Drawing.Size(75, 23);
            this.BTN_Get.TabIndex = 2;
            this.BTN_Get.Text = "Get Value";
            this.BTN_Get.UseVisualStyleBackColor = true;
            this.BTN_Get.Click += new System.EventHandler(this.BTN_Get_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(29, 108);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 3;
            this.BTN_Delete.Text = "Delete";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // TB_Color
            // 
            this.TB_Color.Location = new System.Drawing.Point(155, 53);
            this.TB_Color.Name = "TB_Color";
            this.TB_Color.Size = new System.Drawing.Size(100, 20);
            this.TB_Color.TabIndex = 4;
            // 
            // TB_Price
            // 
            this.TB_Price.Location = new System.Drawing.Point(155, 111);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(100, 20);
            this.TB_Price.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 168);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.TB_Color);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Get);
            this.Controls.Add(this.BTN_Set);
            this.Controls.Add(this.BTN_Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Create;
        private System.Windows.Forms.Button BTN_Set;
        private System.Windows.Forms.Button BTN_Get;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.TextBox TB_Color;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

