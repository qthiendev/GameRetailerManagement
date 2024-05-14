﻿using GameRetailerManagement.Source.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GameRetailerManagement.Source.Forms
{
    public partial class Form_Main : Form
    {
        private Form currentSubForm = null;
        private Form_SpecificGame currentSpecificGameForm = null;

        public Form_Main()
        {
            InitializeComponent();
            InitGamesList();
        }

        private EventHandler ButtonGame(int id,
            string gameName,
            object dataImage,
            string description,
            string price,
            string releaseDate,
            string developer,
            string publisher)
        {
            return (s, e) =>
            {
                if (currentSpecificGameForm != null && currentSpecificGameForm.Text == gameName)
                {
                    currentSpecificGameForm.BringToFront();
                }
                else
                {
                    currentSubForm?.Hide();

                    currentSpecificGameForm = new Form_SpecificGame(
                        gameName,
                        panel_Main.Width,
                        panel_Main.Height,
                        dataImage,
                        description,
                        price,
                        releaseDate,
                        developer,
                        publisher,
                        ButtonEdit(id, gameName, dataImage, description, price, releaseDate, developer, publisher));

                    panel_Main.Controls.Add(currentSpecificGameForm);
                    currentSubForm = currentSpecificGameForm;
                    InitGamesList();
                }
            };
        }

        private EventHandler ButtonEdit(int id,
            string gameName,
            object dataImage,
            string description,
            string price,
            string releaseDate,
            string developer,
            string publisher)
        {
            return (s, e) =>
            {
                currentSubForm?.Hide();
                currentSpecificGameForm?.Hide();

                Form_EditGame subForm = new Form_EditGame(id,
                    gameName,
                    panel_Main.Width,
                    panel_Main.Height,
                    dataImage,
                    description,
                    price,
                    releaseDate,
                    developer,
                    publisher,
                    currentSpecificGameForm);

                panel_Main.Controls.Add(subForm);
                currentSubForm = currentSpecificGameForm;
                InitGamesList();
            };
        }

        private void InitGamesList(string criteria = "")
        {
            try
            {
                flowLayoutPanel_GamesList.Controls.Clear();
                var data = new QueryGRDB().ExcuteList("Select * from [dbo].[GAMES] order by [GAME_NAME]");
                var posY = 0;

                for (int i = 0; i < data["GAME_NAME"].Count; i++)
                {
                    var gameName = data["GAME_NAME"][i].ToString();
                    if (gameName.ToUpper().Contains(criteria.ToUpper()))
                    {
                        var dataImage = data["GAME_IMAGE"][i]; // Get the game image from the data

                        var button = new Button
                        {
                            Text = gameName,
                            Location = new Point(0, 26 * posY),
                            Font = new Font("Cambria", 12, FontStyle.Bold),
                            Size = new Size(250, 26),
                            BackColor = Color.Transparent,
                            FlatStyle = FlatStyle.Flat,
                            TextAlign = ContentAlignment.MiddleLeft,
                            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                            Padding = new Padding(0, 0, 0, 0),
                            ForeColor = Color.DarkBlue,
                        };
                        button.FlatAppearance.BorderSize = 0;
                        button.SendToBack();

                        Form_SpecificGame specificGameForm = new Form_SpecificGame(
                            gameName,
                            panel_Main.Width,
                            panel_Main.Height,
                            dataImage,
                            data["GAME_DESCRIPTION"][i].ToString(),
                            data["GAME_PRICE"][i].ToString(),
                            data["GAME_RELEASE_DATE"][i].ToString(),
                            data["GAME_DEVELOPER"][i].ToString(),
                            data["GAME_PUBLISHER"][i].ToString(),
                            ButtonEdit(int.Parse(data["GAME_ID"][i].ToString()),
                            gameName,
                            dataImage,
                            data["GAME_DESCRIPTION"][i].ToString(),
                            data["GAME_PRICE"][i].ToString(),
                            data["GAME_RELEASE_DATE"][i].ToString().Substring(0, 10),
                            data["GAME_DEVELOPER"][i].ToString(),
                            data["GAME_PUBLISHER"][i].ToString()));

                        button.Click += ButtonGame(int.Parse(data["GAME_ID"][i].ToString()),
                            gameName,
                            dataImage,
                            data["GAME_DESCRIPTION"][i].ToString(),
                            data["GAME_PRICE"][i].ToString(),
                            data["GAME_RELEASE_DATE"][i].ToString().Substring(0, 10),
                            data["GAME_DEVELOPER"][i].ToString(),
                            data["GAME_PUBLISHER"][i].ToString());

                        flowLayoutPanel_GamesList.Controls.Add(button);
                        posY += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripStatusLabel_Datetime.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Datetime.Text = DateTime.Now.ToString();
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            InitGamesList(textBox_Search.Text);
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            InitGamesList(textBox_Search.Text);
            currentSubForm?.Close();
        }
    }
}
