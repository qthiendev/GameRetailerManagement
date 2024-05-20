using GameRetailerManagement.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms.Bills
{
    public partial class Form_ExportBill : Form
    {
        private int _billID;
        public Form_ExportBill(int billID)
        {
            InitializeComponent();
            _billID = billID;
            LoadBill();
        }

        public void LoadBill()
        {
            panel_GameList.Controls.Clear();
            var posY = 0;

            var dataBills = new QueryGRDB().ExcuteList($"select * from [dbo].[BILLS] where BILL_ID = {_billID}");
            var gameBills = new QueryGRDB().ExcuteList($"select * from [dbo].[GAME_BILL] where BILL_ID = {_billID}");

            label_Name.Text += " " + dataBills["CUSTOMER_NAME"][0].ToString();

            label_CreatedDate.Text += " " + DateTime.ParseExact(dataBills["BILL_CREATE_DATE"][0].ToString().Substring(0, 10),
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");

            label_TotalPayment.Text = "0.0";

            label_BillNumber.Text += " " + _billID;
            label_Date.Text += " " + DateTime.Now;

            posY = 10;

            // Create a dictionary to store the count of each game
            Dictionary<int, int> gameCounts = new Dictionary<int, int>();
            foreach (var gameid in gameBills["GAME_ID"])
            {
                var id = int.Parse(gameid.ToString());
                if (!gameCounts.ContainsKey(id))
                {
                    gameCounts[id] = 1;
                }
                else
                {
                    gameCounts[id]++;
                }
            }

            // Iterate over the dictionary to create labels
            foreach (var game in gameCounts)
            {
                var data = new QueryGRDB().ExcuteList($"select [GAME_NAME], [GAME_PRICE] from [dbo].[GAMES] where GAME_ID = {game.Key}");

                var label_Name = new Label()
                {
                    Text = data["GAME_NAME"][0].ToString(),
                    Location = new Point(10, posY),
                    AutoSize = true,
                    Font = new Font("Cambria", 12, FontStyle.Regular),
                };

                var label_Price = new Label()
                {
                    Text = data["GAME_PRICE"][0].ToString(),
                    Location = new Point(350, posY),
                    AutoSize = true,
                    Font = new Font("Cambria", 12, FontStyle.Regular),
                };

                var label_Quantity = new Label()
                {
                    Text = game.Value.ToString(),
                    Location = new Point(620, posY), // Adjust the position as needed
                    AutoSize = true,
                    Font = new Font("Cambria", 12, FontStyle.Regular),
                };

                panel_GameList.Controls.Add(label_Name);
                panel_GameList.Controls.Add(label_Price);
                panel_GameList.Controls.Add(label_Quantity);

                label_TotalPayment.Text =
                    (double.Parse(label_TotalPayment.Text) + double.Parse(data["GAME_PRICE"][0].ToString()) * game.Value).ToString();

                posY += 24;
            }

            label_TotalPayment.Text += " VND";
        }
    }
}
