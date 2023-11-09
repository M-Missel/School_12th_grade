namespace DiceGame
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
            this.BTN_Roll_Dice = new System.Windows.Forms.Button();
            this.TB_First_Dice = new System.Windows.Forms.TextBox();
            this.TB_Sec_Dice = new System.Windows.Forms.TextBox();
            this.TB_Third_Dice = new System.Windows.Forms.TextBox();
            this.TB_Rollcount = new System.Windows.Forms.TextBox();
            this.TB_Total_Score = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Roll_Dice
            // 
            this.BTN_Roll_Dice.Location = new System.Drawing.Point(92, 12);
            this.BTN_Roll_Dice.Name = "BTN_Roll_Dice";
            this.BTN_Roll_Dice.Size = new System.Drawing.Size(97, 38);
            this.BTN_Roll_Dice.TabIndex = 0;
            this.BTN_Roll_Dice.Text = "Roll Dice";
            this.BTN_Roll_Dice.UseVisualStyleBackColor = true;
            this.BTN_Roll_Dice.Click += new System.EventHandler(this.BTN_Roll_Dice_Click);
            // 
            // TB_First_Dice
            // 
            this.TB_First_Dice.Location = new System.Drawing.Point(17, 87);
            this.TB_First_Dice.Name = "TB_First_Dice";
            this.TB_First_Dice.Size = new System.Drawing.Size(55, 20);
            this.TB_First_Dice.TabIndex = 1;
            // 
            // TB_Sec_Dice
            // 
            this.TB_Sec_Dice.Location = new System.Drawing.Point(97, 87);
            this.TB_Sec_Dice.Name = "TB_Sec_Dice";
            this.TB_Sec_Dice.Size = new System.Drawing.Size(55, 20);
            this.TB_Sec_Dice.TabIndex = 2;
            // 
            // TB_Third_Dice
            // 
            this.TB_Third_Dice.Location = new System.Drawing.Point(177, 87);
            this.TB_Third_Dice.Name = "TB_Third_Dice";
            this.TB_Third_Dice.Size = new System.Drawing.Size(55, 20);
            this.TB_Third_Dice.TabIndex = 3;
            // 
            // TB_Rollcount
            // 
            this.TB_Rollcount.Location = new System.Drawing.Point(177, 152);
            this.TB_Rollcount.Name = "TB_Rollcount";
            this.TB_Rollcount.Size = new System.Drawing.Size(100, 20);
            this.TB_Rollcount.TabIndex = 4;
            // 
            // TB_Total_Score
            // 
            this.TB_Total_Score.Location = new System.Drawing.Point(177, 189);
            this.TB_Total_Score.Name = "TB_Total_Score";
            this.TB_Total_Score.Size = new System.Drawing.Size(100, 20);
            this.TB_Total_Score.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "1. Dice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "2. Dice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "3. Dice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rollcount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total score";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 241);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Total_Score);
            this.Controls.Add(this.TB_Rollcount);
            this.Controls.Add(this.TB_Third_Dice);
            this.Controls.Add(this.TB_Sec_Dice);
            this.Controls.Add(this.TB_First_Dice);
            this.Controls.Add(this.BTN_Roll_Dice);
            this.Name = "GUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Roll_Dice;
        private System.Windows.Forms.TextBox TB_First_Dice;
        private System.Windows.Forms.TextBox TB_Sec_Dice;
        private System.Windows.Forms.TextBox TB_Third_Dice;
        private System.Windows.Forms.TextBox TB_Rollcount;
        private System.Windows.Forms.TextBox TB_Total_Score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

