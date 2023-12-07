namespace Horse_racing
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
            this.PB_Track = new System.Windows.Forms.PictureBox();
            this.BTN_Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Track)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Track
            // 
            this.PB_Track.Location = new System.Drawing.Point(12, 12);
            this.PB_Track.Name = "PB_Track";
            this.PB_Track.Size = new System.Drawing.Size(525, 275);
            this.PB_Track.TabIndex = 0;
            this.PB_Track.TabStop = false;
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(12, 309);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(75, 23);
            this.BTN_Start.TabIndex = 1;
            this.BTN_Start.Text = "Start Race";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 373);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.PB_Track);
            this.Name = "GUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Track)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Track;
        private System.Windows.Forms.Button BTN_Start;
    }
}

