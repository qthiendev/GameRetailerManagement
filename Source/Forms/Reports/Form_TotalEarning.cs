using GameRetailerManagement.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms.Reports
{
    public partial class Form_TotalEarning : Form
    {
        public Form_TotalEarning()
        {
            InitializeComponent();
            panel_GameList.Controls.Clear();
            label_TotalEarning.Text = "0.0";
            var posY = 0;

            var allGames = new QueryGRDB().ExcuteList($"select * from [dbo].[GAMES]");
            Dictionary<int, Tuple<string, double, int>> gameCounts = new Dictionary<int, Tuple<string, double, int>>();
            for (int i = 0; i < allGames["GAME_ID"].Count; i++)
            {
                var id = int.Parse(allGames["GAME_ID"][i].ToString());
                var name = allGames["GAME_NAME"][i].ToString();
                var price = double.Parse(allGames["GAME_PRICE"][i].ToString());
                gameCounts[id] = new Tuple<string, double, int>(name, price, 0);
            }


            // Update quantities
            var gameBills = new QueryGRDB().ExcuteList($"select * from [dbo].[GAME_BILL]");
            foreach (var gameid in gameBills["GAME_ID"])
            {
                var id = int.Parse(gameid.ToString());
                if (gameCounts.ContainsKey(id))
                {
                    gameCounts[id] = Tuple.Create(gameCounts[id].Item1, gameCounts[id].Item2, gameCounts[id].Item3 + 1);
                }
            }

            // Find the game with the greatest quantity sold
            var mostSoldGame = gameCounts.Aggregate((l, r) => l.Value.Item3 > r.Value.Item3 ? l : r);

            label_MostSale.Text = $"{mostSoldGame.Value.Item1}: {mostSoldGame.Value.Item3}";

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
                Location = new Point(200, posY),
                AutoSize = true,
                Font = new Font("Cambria", 13, FontStyle.Regular),
                ForeColor = Color.Blue,
            });

            panel_GameList.Controls.Add(new Label()
            {
                Text = "Quantity",
                Location = new Point(400, posY),
                AutoSize = true,
                Font = new Font("Cambria", 13, FontStyle.Regular),
                ForeColor = Color.Blue,
            });

            posY += 30;

            foreach (var game in gameCounts)
            {
                var label_Name = new Label()
                {
                    Text = game.Value.Item1,
                    Location = new Point(0, posY),
                    AutoSize = true,
                    Font = new Font("Cambria", 12, FontStyle.Regular),
                };

                var label_Price = new Label()
                {
                    Text = game.Value.Item2.ToString(),
                    Location = new Point(200, posY),
                    AutoSize = true,
                    Font = new Font("Cambria", 12, FontStyle.Regular),
                };

                var label_Quantity = new Label()
                {
                    Text = game.Value.Item3.ToString(),
                    Location = new Point(400, posY),
                    AutoSize = true,
                    Font = new Font("Cambria", 12, FontStyle.Regular),
                };

                panel_GameList.Controls.Add(label_Name);
                panel_GameList.Controls.Add(label_Price);
                panel_GameList.Controls.Add(label_Quantity);

                label_TotalEarning.Text =
                    (double.Parse(label_TotalEarning.Text) + game.Value.Item2 * game.Value.Item3).ToString();

                posY += 24;
            }
        }

        private void Form_TotalEarning_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
