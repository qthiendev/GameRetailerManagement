using GameRetailerManagement.Source.Forms.Bills;
using GameRetailerManagement.Source.Forms.Main;
using GameRetailerManagement.Source.Utilities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms.Games
{
    public partial class Form_AddGame : Form
    {
        private readonly Form_GameRetailer _formMain;
        private readonly int _gameID;

        public Form_AddGame(Form_GameRetailer main)
        {
            InitializeComponent();

            _formMain = main;

            textBox_GameName.Text = string.Empty;
            textBox_Price.Text = string.Empty;

            _formMain = main;
            _gameID = 0;

            while (true)
            {
                if ((int)new QueryGRDB().ExecuteScalar($"select count(*) from [dbo].[GAMES] WHERE [GAME_ID] = {_gameID}") == 0)
                    break;
                _gameID++;
            }

            Text = "Add id: " + _gameID;
        }

        private void Form_AddGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formMain.Show();
            _formMain.BringToFront();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_GameName.Text == string.Empty)
                    throw new Exception("Please fill Product's Name");

                if (textBox_Price.Text == String.Empty)
                    throw new Exception("Please fill Product's Price");

                var releaseDate = dateTimePicker_ReleaseDate.Value.ToString("yyyy-MM-dd");

                var check = new QueryGRDB().ExecuteNonQuery("INSERT INTO [dbo].[GAMES] " +
                    "(GAME_ID, GAME_NAME, GAME_RELEASE_DATE, GAME_DEVELOPER, GAME_PUBLISHER, GAME_PRICE, GAME_DESCRIPTION) " +
                    "VALUES" +
                    "(@gameId, @gameName, @releaseDate, @developer, @publisher, @price, @description)",
                    new SqlParameter("@gameId", _gameID),
                    new SqlParameter("@gameName", textBox_GameName.Text),
                    new SqlParameter("@releaseDate", releaseDate),
                    new SqlParameter("@developer", DBNull.Value),
                    new SqlParameter("@publisher", DBNull.Value),
                    new SqlParameter("@price", textBox_Price.Text),
                    new SqlParameter("@description", DBNull.Value));

                if (check <= 0)
                    throw new Exception("Cannot add to database!");

                Close();
                _formMain.CurrentSubFormType = Form_GameRetailer.SubFormType.Games;
                _formMain.TriggerButtonDetail(_gameID);
                _formMain.InitList();

                new Form_EditGame(_gameID,
                    _formMain,
                    new Form_SpecificGame(_gameID, _formMain.panel_Main.Width, _formMain.panel_Main.Height, _formMain)).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_GameName.Text = string.Empty;
            textBox_Price.Text = string.Empty;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
