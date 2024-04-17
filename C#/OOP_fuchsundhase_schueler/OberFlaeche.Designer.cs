namespace fuchsundhase {
  partial class OberFlaeche {
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
      this.L_Anzahl = new System.Windows.Forms.Label();
      this.L_Futter = new System.Windows.Forms.Label();
      this.L_Fuchs = new System.Windows.Forms.Label();
      this.L_Hase = new System.Windows.Forms.Label();
      this.L_AnzF = new System.Windows.Forms.Label();
      this.L_AnzH = new System.Windows.Forms.Label();
      this.L_FutF = new System.Windows.Forms.Label();
      this.L_FutH = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // L_Anzahl
      // 
      this.L_Anzahl.AutoSize = true;
      this.L_Anzahl.Location = new System.Drawing.Point(52, 448);
      this.L_Anzahl.Name = "L_Anzahl";
      this.L_Anzahl.Size = new System.Drawing.Size(39, 13);
      this.L_Anzahl.TabIndex = 0;
      this.L_Anzahl.Text = "Anzahl";
      // 
      // L_Futter
      // 
      this.L_Futter.AutoSize = true;
      this.L_Futter.Location = new System.Drawing.Point(52, 474);
      this.L_Futter.Name = "L_Futter";
      this.L_Futter.Size = new System.Drawing.Size(34, 13);
      this.L_Futter.TabIndex = 1;
      this.L_Futter.Text = "Futter";
      // 
      // L_Fuchs
      // 
      this.L_Fuchs.AutoSize = true;
      this.L_Fuchs.Location = new System.Drawing.Point(97, 424);
      this.L_Fuchs.Name = "L_Fuchs";
      this.L_Fuchs.Size = new System.Drawing.Size(36, 13);
      this.L_Fuchs.TabIndex = 2;
      this.L_Fuchs.Text = "Fuchs";
      // 
      // L_Hase
      // 
      this.L_Hase.AutoSize = true;
      this.L_Hase.Location = new System.Drawing.Point(154, 424);
      this.L_Hase.Name = "L_Hase";
      this.L_Hase.Size = new System.Drawing.Size(32, 13);
      this.L_Hase.TabIndex = 3;
      this.L_Hase.Text = "Hase";
      // 
      // L_AnzF
      // 
      this.L_AnzF.AutoSize = true;
      this.L_AnzF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_AnzF.Location = new System.Drawing.Point(97, 448);
      this.L_AnzF.Name = "L_AnzF";
      this.L_AnzF.Size = new System.Drawing.Size(14, 13);
      this.L_AnzF.TabIndex = 4;
      this.L_AnzF.Text = "0";
      // 
      // L_AnzH
      // 
      this.L_AnzH.AutoSize = true;
      this.L_AnzH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_AnzH.Location = new System.Drawing.Point(154, 448);
      this.L_AnzH.Name = "L_AnzH";
      this.L_AnzH.Size = new System.Drawing.Size(14, 13);
      this.L_AnzH.TabIndex = 5;
      this.L_AnzH.Text = "0";
      // 
      // L_FutF
      // 
      this.L_FutF.AutoSize = true;
      this.L_FutF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_FutF.Location = new System.Drawing.Point(97, 474);
      this.L_FutF.Name = "L_FutF";
      this.L_FutF.Size = new System.Drawing.Size(14, 13);
      this.L_FutF.TabIndex = 6;
      this.L_FutF.Text = "0";
      // 
      // L_FutH
      // 
      this.L_FutH.AutoSize = true;
      this.L_FutH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_FutH.Location = new System.Drawing.Point(154, 474);
      this.L_FutH.Name = "L_FutH";
      this.L_FutH.Size = new System.Drawing.Size(14, 13);
      this.L_FutH.TabIndex = 7;
      this.L_FutH.Text = "0";
      // 
      // OberFlaeche
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(532, 506);
      this.Controls.Add(this.L_FutH);
      this.Controls.Add(this.L_FutF);
      this.Controls.Add(this.L_AnzH);
      this.Controls.Add(this.L_AnzF);
      this.Controls.Add(this.L_Hase);
      this.Controls.Add(this.L_Fuchs);
      this.Controls.Add(this.L_Futter);
      this.Controls.Add(this.L_Anzahl);
      this.Name = "OberFlaeche";
      this.Text = "Fuchs und Hase";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label L_Anzahl;
    private System.Windows.Forms.Label L_Futter;
    private System.Windows.Forms.Label L_Fuchs;
    private System.Windows.Forms.Label L_Hase;
    private System.Windows.Forms.Label L_AnzF;
    private System.Windows.Forms.Label L_AnzH;
    private System.Windows.Forms.Label L_FutF;
    private System.Windows.Forms.Label L_FutH;
  }
}

