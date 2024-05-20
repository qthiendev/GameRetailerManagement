using GameRetailerManagement.Source.Forms.Main;
using GameRetailerManagement.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms.Bills
{
    public partial class Form_EditBill : Form
    {
        private readonly Form_GameRetailer _formMain;
        private readonly Form_SpecificBill _formBill;
        private readonly int _billID;

        public Form_EditBill(int billID, Form_GameRetailer main, Form_SpecificBill formBill)
        {
            InitializeComponent();
            _billID = billID;
            _formMain = main;

            var dataGames = new QueryGRDB().ExcuteList("Select [GAME_NAME] from [dbo].[GAMES]");
            foreach (var name in dataGames["GAME_NAME"])
                comboBox_GameID.Items.Add(name);

            LoadBill();
            _formBill = formBill;
        }

        private void Form_EditBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formMain.Show();
            _formMain.BringToFront();
            _formBill.LoadBill();
            _formMain.CurrentSubFormType = Form_GameRetailer.SubFormType.Bills;
            _formMain.TriggerButtonDetail(_billID);
        }

        private void LoadBill()
        {
            panel_GameList.Controls.Clear();
            var posY = 0;

            var dataBills = new QueryGRDB().ExcuteList($"select * from [dbo].[BILLS] where BILL_ID = {_billID}");
            var gameBills = new QueryGRDB().ExcuteList($"select * from [dbo].[GAME_BILL] where BILL_ID = {_billID}");

            textBox_CustomerName.Text = dataBills["CUSTOMER_NAME"][0].ToString();

            dateTimePicker_CreatedDate.Value = DateTime.ParseExact(dataBills["BILL_CREATE_DATE"][0].ToString().Substring(0, 10),
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);

            label_TotalPayment.Text = "0.0";

            panel_GameList.Controls.Add(new Label()
            {
                Text = "Game",
                Location = new Point(0, posY),
                AutoSize = true,
                Font = new Font("Cambria", 13, FontStyle.Regular),
                ForeColor = Color.Blue,
            });

            panel_GameList.Controls.Add(new Label()
            {
                Text = "Price",
                Location = new Point(300, posY),
                AutoSize = true,
                Font = new Font("Cambria", 13, FontStyle.Regular),
                ForeColor = Color.Blue,
            });

            panel_GameList.Controls.Add(new Label()
            {
                Text = "Quantity",
                Location = new Point(600, posY),
                AutoSize = true,
                Font = new Font("Cambria", 13, FontStyle.Regular),
                ForeColor = Color.Blue,
            });

            posY = 30;

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
                    Location = new Point(0, posY),
                    AutoSize = true,
                    Font = new Font("Cambria", 12, FontStyle.Regular),
                };

                var label_Price = new Label()
                {
                    Text = data["GAME_PRICE"][0].ToString(),
                    Location = new Point(300, posY),
                    AutoSize = true,
                    Font = new Font("Cambria", 12, FontStyle.Regular),
                };

                var label_Quantity = new Label()
                {
                    Text = game.Value.ToString(),
                    Location = new Point(600, posY), // Adjust the position as needed
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
        }


        private void button_AddGame_Click(object sender, EventArgs e)
        {
            try
            {
                var gameName = comboBox_GameID.SelectedItem.ToString();

                if (int.Parse(new QueryGRDB().ExecuteScalar(
                    $"select count(*) from [dbo].[GAMES] where [GAME_NAME] = '{gameName}'").ToString()) <= 0)
                    throw new Exception($"'{gameName}' is not exist in Database");

                var gameID = new QueryGRDB().ExecuteScalar(
                    $"select top 1 [GAME_ID] from [dbo].[GAMES] where [GAME_NAME] = '{gameName}'").ToString();

                var lastID = int.Parse(new QueryGRDB().ExecuteScalar(
                    $"SELECT ISNULL(MAX(GAME_BILL_ID), 0) FROM [dbo].[GAME_BILL]").ToString()) + 1;

                if (new QueryGRDB().ExecuteNonQuery("insert into GAME_BILL " +
                    $"values ({lastID}, {_billID}, {gameID});") <= 0)
                    throw new Exception($"Cannot add '{gameName}' to bill {_billID}");

                LoadBill();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                var gameName = comboBox_GameID.SelectedItem.ToString();

                if (int.Parse(new QueryGRDB().ExecuteScalar(
                    $"select count(*) from [dbo].[GAMES] where [GAME_NAME] = '{gameName}'").ToString()) <= 0)
                    throw new Exception($"'{gameName}' is not exist in Database");

                var gameID = new QueryGRDB().ExecuteScalar(
                    $"select top 1 [GAME_ID] from [dbo].[GAMES] where [GAME_NAME] = '{gameName}'").ToString();

                if ((int)new QueryGRDB().ExecuteScalar(
                    $"select count(*) from [dbo].[GAME_BILL] " +
                    $"where [GAME_ID] = {gameID} and [BILL_ID] = {_billID}") <= 0)
                    throw new Exception($"'{gameName}' not exist in bill {_billID}");

                var gameBillID = int.Parse(new QueryGRDB().ExecuteScalar(
                    $"select top 1 [GAME_BILL_ID] from [GAME_BILL] " +
                    $"where [GAME_ID] = {gameID} and [BILL_ID] = {_billID};").ToString());

                Console.WriteLine(gameBillID);

                var check = new QueryGRDB().ExecuteNonQuery($"delete from [GAME_BILL] where [GAME_BILL_ID] = {gameBillID};");

                Console.WriteLine(check);
                
                if (check <= 0)
                    throw new Exception($"Cannot remove '{gameName}' from bill {_billID}");

                LoadBill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                var cusName = textBox_CustomerName.Text;
                var createdDate = dateTimePicker_CreatedDate.Value.ToString("yyyy-MM-dd");

                if (new QueryGRDB().ExecuteNonQuery("update [BILLS] " +
                    $"set [CUSTOMER_NAME] = N'{cusName}', [BILL_CREATE_DATE] = CONVERT(date, '{createdDate}')" +
                    $"where [BILL_ID] = {_billID};") <= 0)
                    throw new Exception($"Cannot update bill {_billID}");

                Close();
                _formMain.Show();
                _formMain.BringToFront();
                _formMain.CurrentSubFormType = Form_GameRetailer.SubFormType.Bills;
                _formMain.InitList();
                _formBill.LoadBill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
            _formMain.Show();
            _formMain.BringToFront();
        }
    }
}
