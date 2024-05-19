using GameRetailerManagement.Source.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms.Bills
{
    public partial class Form_SpecificBill : Form
    {
        public Form_SpecificBill(int billID,
            int width,
            int height,
            Form_Main main)
        {
            InitializeComponent();

            TopLevel = false;
            Visible = true;
            Location = new Point(0, 0);
            WindowState = FormWindowState.Maximized;
            Width = width;
            Height = height;
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            var dataBills = new QueryGRDB().ExcuteList($"select * from [dbo].[BILLS] where BILL_ID = {billID}");
            var gameBills = new QueryGRDB().ExcuteList($"select * from [dbo].[GAME_BILL] where BILL_ID = {billID}");

            label_CustomerName.Text = dataBills["CUSTOMER_NAME"][0].ToString();
            label_CreatedDate.Text = dataBills["BILL_CREATE_DATE"][0].ToString().Substring(0, 10);
            label_TotalPayment.Text = "0.0";

            foreach (var gameid in gameBills["GAME_ID"])
            {
                var data = new QueryGRDB().ExcuteList($"select [GAME_NAME], [GAME_PRICE] from [dbo].[GAMES] where GAME_ID = {gameid}");
                string gameName = data["GAME_NAME"][0].ToString();
                string gamePrice = data["GAME_PRICE"][0].ToString();
                string formattedItem = $"{gameName}:                  {gamePrice}";
                listBox_Games.Items.Add(formattedItem);
                label_TotalPayment.Text =
                    (double.Parse(label_TotalPayment.Text) + double.Parse(data["GAME_PRICE"][0].ToString())).ToString();
            }
        }
    }
}
