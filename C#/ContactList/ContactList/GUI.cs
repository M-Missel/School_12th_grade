using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class GUI : Form
    {
        ApplicationLayer application;

        public GUI()
        {
            InitializeComponent();
            application = new ApplicationLayer(this);
        }

        private void BTN_Create_Contact_Click(object sender, EventArgs e)
        {
            application.createPerson(TB_Name.Text, Convert.ToInt64(TB_Number.Text));
        }

        private void BTN_Show_All_Contacts_Click(object sender, EventArgs e)
        {
            application.printAllCodes();
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void addItem(string str)
        {
            LB_Output.Items.Add(str);
        }

        public void removeItem()
        {
            LB_Output.Items.Clear();
        }
    }
}
