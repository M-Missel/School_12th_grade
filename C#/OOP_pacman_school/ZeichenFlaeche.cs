using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace pacman
{
    public class ZeichenFlaeche : StringGrid.StringGrid
    {
        private OberFlaeche dieOberFlaeche;
        public ZeichenFlaeche(OberFlaeche pOberFlaeche)
        {
            dieOberFlaeche = pOberFlaeche;
            this.ColCount = 15;
            this.DefaultColWidth = 25;
            this.DefaultRowHeight = 25;
            this.FixedCols = 0;
            this.FixedRows = 0;
            this.GridLineWidth = 1;
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "zeichenflaeche";
            this.RowCount = 9;
            this.Size = new System.Drawing.Size(392, 236);
            this.TabIndex = 0;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(dieOberFlaeche.ereignisTastatur);
        }
    }
}