using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class GUI : Form
    {
        ApplicationLayer layer;
        public GUI()
        {
            InitializeComponent();
            layer = new ApplicationLayer(this);
        }

        private void BTN_Roll_Dice_Click(object sender, EventArgs e)
        {
            layer.play();
        }

        public void showRoll(int firstDice, int secDice, int thirdDice)
        {
            TB_First_Dice.Text = firstDice.ToString();
            TB_Sec_Dice.Text = secDice.ToString();
            TB_Third_Dice.Text = thirdDice.ToString();
        }
    }
}
