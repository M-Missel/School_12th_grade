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
    public partial class GUI : Form
    {
        Car[] garage = new Car[10];

        public GUI()
        {
            InitializeComponent();
        }

        public void BTN_Create_Click(object sender, EventArgs e)
        {
            garage[Convert.ToInt32(TB_Number.Text)] = new Car();
        }

        public void BTN_Set_Click(object sender, EventArgs e)
        {
            garage[Convert.ToInt32(TB_Number.Text)].Price = Convert.ToInt32(TB_Price.Text);
            garage[Convert.ToInt32(TB_Number.Text)].Color = TB_Color.Text;
        }

        public void BTN_Get_Click(object sender, EventArgs e)
        {
            TB_Price.Text = garage[Convert.ToInt32(TB_Number.Text)].Price.ToString();
            TB_Color.Text = garage[Convert.ToInt32(TB_Number.Text)].Color;
        }

        public void BTN_Delete_Click(object sender, EventArgs e)
        {
            garage[Convert.ToInt32(TB_Number.Text)] = null;
            GC.Collect();
        }

        public void BTN_Show_Cars_Click(object sender, EventArgs e)
        {
            showCars();
        }

        public void BTN_Show_All_Cars(object sender, EventArgs e)
        {
            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i] != null)
                    garage[i].do_show();
            }

            showCars();
        }

        public void BTN_Sort_Cars(object sender, EventArgs e)
        {
            switch (CB_Input.SelectedText)
            {
                case "<":
                    for (int i = 0; i < garage.Length; i++)
                    {
                        if (garage[i].Price < Convert.ToInt32(TB_Input.Text))
                            LB_Output.Items.Add($"{i}: {garage[i].Color}, {garage[i].Price}");
                    }
                    break;
                case ">":
                    for (int i = 0; i < garage.Length; i++)
                    {
                        if (garage[i].Price > Convert.ToInt32(TB_Input.Text))
                            LB_Output.Items.Add($"{i}: {garage[i].Color}, {garage[i].Price}");
                    }
                    break;
                case "=":
                    for (int i = 0; i < garage.Length; i++)
                    {
                        if (garage[i].Price == Convert.ToInt32(TB_Input.Text))
                            LB_Output.Items.Add($"{i}: {garage[i].Color}, {garage[i].Price}");
                    }
                    break;
            }
        }

        private void showCars()
        {
            LB_Output.Items.Clear();
            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i].Show && garage[i].Color != null && garage[i].Price != 0)
                    LB_Output.Items.Add($"{i}: {garage[i].Color}, {garage[i].Price}");
                else if (garage[i].Color == null || garage[i].Price == 0)
                    LB_Output.Items.Add($"{i}: unknown");
                else
                    LB_Output.Items.Add($"{i}: Not existing");
            }
        }
    }
}
