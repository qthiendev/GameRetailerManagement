using GameRetailerManagement.Source.Forms.Games;
using GameRetailerManagement.Source.Forms.Main;
using GameRetailerManagement.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms.Bills
{
    public partial class Form_SpecificBill : Form
    {
        private readonly int _billID;
        private readonly Form_GameRetailer _formMain;
        Bitmap _image;

        public Form_SpecificBill(int billID,
            int width,
            int height,
            Form_GameRetailer main)
        {
            InitializeComponent();

            TopLevel = false;
            Visible = true;
            Location = new Point(0, 0);
            WindowState = FormWindowState.Maximized;
            Width = width;
            Height = height;
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            _billID = billID;
            _formMain = main;

            LoadBill();
        }

        public void LoadBill()
        {
            panel_GameList.Controls.Clear();
            var posY = 0;

            var dataBills = new QueryGRDB().ExcuteList($"select * from [dbo].[BILLS] where BILL_ID = {_billID}");
            var gameBills = new QueryGRDB().ExcuteList($"select * from [dbo].[GAME_BILL] where BILL_ID = {_billID}");

            label_CustomerName.Text = dataBills["CUSTOMER_NAME"][0].ToString();

            label_CreatedDate.Text = DateTime.ParseExact(dataBills["BILL_CREATE_DATE"][0].ToString().Substring(0, 10),
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");

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

        private void button_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Form_EditBill editForm = new Form_EditBill(_billID, _formMain, this);
                editForm.Show();
                editForm.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var dialogResult = MessageBox.Show($"Are you sure want to delete bill {_billID}!", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    new QueryGRDB().ExecuteNonQuery($"delete from [GAME_BILL] where [BILL_ID] = {_billID}");

                    if (new QueryGRDB().ExecuteNonQuery($"delete from [BILLS] where [BILL_ID] = {_billID}") <= 0)
                        throw new Exception($"Failed to delete bill {_billID} | Data gone x.x");

                    Close();
                    _formMain.InitList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            var formExport = new Form_ExportBill(_billID);
            formExport.Visible = true;
            formExport.Show();
            _image = new Bitmap(formExport.Width, formExport.Height);
            formExport.DrawToBitmap(_image, new Rectangle(0, 0, formExport.Width, formExport.Height));
            formExport.Close();

            string date = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string filePath = $@"D:\\bill{_billID}_{date}.png";

            _image.Save(filePath, ImageFormat.Png);
            System.Diagnostics.Process.Start(filePath);
        }
    }
}
