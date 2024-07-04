namespace snake {
  partial class GUI {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent() {
      this.B_Neu = new System.Windows.Forms.Button();
      this.SG_spielplan = new StringGrid.StringGrid();
      this.L_Punkte = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // B_Neu
      // 
      this.B_Neu.Location = new System.Drawing.Point(13, 13);
      this.B_Neu.Name = "B_Neu";
      this.B_Neu.Size = new System.Drawing.Size(155, 33);
      this.B_Neu.TabIndex = 0;
      this.B_Neu.Text = "neues Spiel\r\n";
      this.B_Neu.UseVisualStyleBackColor = true;
      this.B_Neu.Click += new System.EventHandler(this.B_Neu_Click);
      // 
      // SG_spielplan
      // 
      this.SG_spielplan.ColCount = 50;
      this.SG_spielplan.DefaultColWidth = 20;
      this.SG_spielplan.DefaultRowHeight = 20;
      this.SG_spielplan.FixedCols = 0;
      this.SG_spielplan.FixedRows = 0;
      this.SG_spielplan.GridLineWidth = 0;
      this.SG_spielplan.Location = new System.Drawing.Point(13, 52);
      this.SG_spielplan.Name = "SG_spielplan";
      this.SG_spielplan.RowCount = 30;
      this.SG_spielplan.Size = new System.Drawing.Size(1052, 632);
      this.SG_spielplan.TabIndex = 1;
      this.SG_spielplan.DrawCell += new StringGrid.StringGrid.DrawCellEventHandler(this.SG_spielplan_DrawCell);
      this.SG_spielplan.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SG_spielplan_PreviewKeyDown);
      // 
      // L_Punkte
      // 
      this.L_Punkte.AutoSize = true;
      this.L_Punkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_Punkte.Location = new System.Drawing.Point(212, 13);
      this.L_Punkte.Name = "L_Punkte";
      this.L_Punkte.Size = new System.Drawing.Size(332, 26);
      this.L_Punkte.TabIndex = 2;
      this.L_Punkte.Text = "Bitte auf \"neues Spiel\" klicken";
      // 
      // GUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1085, 692);
      this.Controls.Add(this.L_Punkte);
      this.Controls.Add(this.SG_spielplan);
      this.Controls.Add(this.B_Neu);
      this.Name = "GUI";
      this.Text = "Snake";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button B_Neu;
    private StringGrid.StringGrid SG_spielplan;
    private System.Windows.Forms.Label L_Punkte;
  }
}

