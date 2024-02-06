namespace pacman {
  partial class OberFlaeche {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components=null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing) {
      if (disposing&&(components!=null)) {
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
      this.B_Start = new System.Windows.Forms.Button();
      this.L_Punkte_Ueberschrift = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.L_Punkte = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // B_Start
      // 
      this.B_Start.Location = new System.Drawing.Point(422, 13);
      this.B_Start.Name = "B_Start";
      this.B_Start.Size = new System.Drawing.Size(75, 23);
      this.B_Start.TabIndex = 1;
      this.B_Start.Text = "Start";
      this.B_Start.UseVisualStyleBackColor = true;
      this.B_Start.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ereignisTastatur);
      this.B_Start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickStart);
      // 
      // L_Punkte_Ueberschrift
      // 
      this.L_Punkte_Ueberschrift.AutoSize = true;
      this.L_Punkte_Ueberschrift.Location = new System.Drawing.Point(422, 43);
      this.L_Punkte_Ueberschrift.Name = "L_Punkte_Ueberschrift";
      this.L_Punkte_Ueberschrift.Size = new System.Drawing.Size(41, 13);
      this.L_Punkte_Ueberschrift.TabIndex = 2;
      this.L_Punkte_Ueberschrift.Text = "Punkte";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.L_Punkte);
      this.groupBox1.Location = new System.Drawing.Point(425, 59);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(72, 53);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      // 
      // L_Punkte
      // 
      this.L_Punkte.AutoSize = true;
      this.L_Punkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_Punkte.Location = new System.Drawing.Point(23, 16);
      this.L_Punkte.Name = "L_Punkte";
      this.L_Punkte.Size = new System.Drawing.Size(25, 26);
      this.L_Punkte.TabIndex = 4;
      this.L_Punkte.Text = "0";
      // 
      // OberFlaeche
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(507, 262);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.L_Punkte_Ueberschrift);
      this.Controls.Add(this.B_Start);
      this.Name = "OberFlaeche";
      this.Text = "PacManMikro";
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ereignisTastatur);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button B_Start;
    private System.Windows.Forms.Label L_Punkte_Ueberschrift;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label L_Punkte;
  }
}

