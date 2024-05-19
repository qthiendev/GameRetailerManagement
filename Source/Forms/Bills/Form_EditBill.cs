using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms.Bills
{
    public partial class Form_EditBill : Form
    {
        private readonly Form_Main _formMain;
        private readonly int _billID;

        public Form_EditBill(int billID, Form_Main main)
        {
            InitializeComponent();
            _billID = billID;
            _formMain = main;
        }

        private void Form_EditBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formMain.Show();
            _formMain.BringToFront();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
            _formMain.Show();
            _formMain.BringToFront();
        }

        private void button_AddGame_Click(object sender, EventArgs e)
        {

        }
    }
}
