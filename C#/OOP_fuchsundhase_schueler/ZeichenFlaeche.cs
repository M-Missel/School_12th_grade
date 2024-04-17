using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuchsundhase {
  public class ZeichenFlaeche : StringGrid.StringGrid {
     
      public ZeichenFlaeche() {
      // 
      // dieZeichenFlaeche
      // 
      this.ColCount = 20;
      this.DefaultColWidth = 25;
      this.DefaultRowHeight = 25;
      this.FixedCols = 0;
      this.FixedRows = 0;
      this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.GridLineWidth = 1;
      this.Location = new System.Drawing.Point(5, 5);
      this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
      this.Name = "dieZeichenFlaeche";
      this.RowCount = 15;
      this.Size = new System.Drawing.Size(522, 392);
      this.TabIndex = 0;
    }
  }
}
