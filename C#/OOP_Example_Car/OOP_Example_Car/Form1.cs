using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Example_Car
{
    public partial class Form1 : Form
    {
        Car car;

        public Form1()
        {
            InitializeComponent();
        }

        public void BTN_Create_Click(object sender, EventArgs e)
        {
            car = new Car();
        }

        public void BTN_Set_Click(object sender, EventArgs e)
        {
            car.Price = Convert.ToInt32(TB_Price.Text);
            car.Color = TB_Color.Text;
        }

        public void BTN_Get_Click(object sender, EventArgs e)
        {
            TB_Price.Text = car.Price.ToString();
            TB_Color.Text = car.Color;
        }

        public void BTN_Delete_Click(object sender, EventArgs e)
        {
            car = null;
        }
    }
}
