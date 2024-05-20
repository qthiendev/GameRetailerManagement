using GameRetailerManagement.Source.Forms.Main;
using GameRetailerManagement.Source.Utilities;
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
    public partial class Form_AddBill : Form
    {
        private readonly Form_GameRetailer _formMain;
        private readonly int _billID;

        public Form_AddBill(Form_GameRetailer main)
        {
            InitializeComponent();

            _formMain = main;

            textBox_CustomerName.Text = string.Empty;
            dateTimePicker_CreatedDate.Value = DateTime.Now;

            _billID = 0;
            while (true)
            {
                if (int.Parse(new QueryGRDB().ExecuteScalar(
                    $"select count(*) from [dbo].[BILLS] WHERE [BILL_ID] = {_billID}").ToString()) == 0)
                    break;
                _billID++;
            }

            label_BillID.Text = _billID.ToString();
        }

        private void Form_AddBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formMain.Show();
            _formMain.BringToFront();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                var cusName = textBox_CustomerName.Text;
                var createdDate = dateTimePicker_CreatedDate.Value.ToString("yyyy-MM-dd");

                if (new QueryGRDB().ExecuteNonQuery("insert into [BILLS]" +
                    $"values ({_billID}, N'{cusName}', convert(date, '{createdDate}'));") <= 0)
                    throw new Exception($"Failed to add bill {_billID} to database.");

                Close();
                _formMain.CurrentSubFormType = Form_GameRetailer.SubFormType.Bills;
                _formMain.TriggerButtonDetail(_billID);
                _formMain.InitList();

                new Form_EditBill(_billID,
                    _formMain,
                    new Form_SpecificBill(_billID, _formMain.panel_Main.Width, _formMain.panel_Main.Height, _formMain)).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_CustomerName.Text = string.Empty;
            dateTimePicker_CreatedDate.Value = DateTime.Now;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
