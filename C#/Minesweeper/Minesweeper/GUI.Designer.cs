namespace Minesweeper
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
            this.SG_GameBoard = new StringGrid.StringGrid();
            this.L_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SG_GameBoard
            // 
            this.SG_GameBoard.ColCount = 6;
            this.SG_GameBoard.DefaultColWidth = 25;
            this.SG_GameBoard.DefaultRowHeight = 25;
            this.SG_GameBoard.FixedCols = 1;
            this.SG_GameBoard.FixedRows = 1;
            this.SG_GameBoard.GridLineWidth = 1;
            this.SG_GameBoard.Location = new System.Drawing.Point(72, 46);
            this.SG_GameBoard.Name = "SG_GameBoard";
            this.SG_GameBoard.RowCount = 6;
            this.SG_GameBoard.Size = new System.Drawing.Size(132, 132);
            this.SG_GameBoard.TabIndex = 0;
            this.SG_GameBoard.SelectCell += new StringGrid.StringGrid.SelectCellEventHandler(this.SG_GameBoard_SelectCell);
            // 
            // L_Status
            // 
            this.L_Status.AutoSize = true;
            this.L_Status.Location = new System.Drawing.Point(72, 226);
            this.L_Status.Name = "L_Status";
            this.L_Status.Size = new System.Drawing.Size(0, 13);
            this.L_Status.TabIndex = 1;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.L_Status);
            this.Controls.Add(this.SG_GameBoard);
            this.Name = "GUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StringGrid.StringGrid SG_GameBoard;
        private System.Windows.Forms.Label L_Status;
    }
}

