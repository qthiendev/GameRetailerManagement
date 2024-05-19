using GameRetailerManagement.Source.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms.Games
{
    public partial class Form_AddGame : Form
    {
        private int _lastID;
        private Form _main;

        public Form_AddGame(Form main)
        {
            InitializeComponent();
            textBox_Description.Text = string.Empty;
            textBox_Developer.Text = string.Empty;
            textBox_GameName.Text = string.Empty;
            textBox_Price.Text = string.Empty;
            textBox_Publisher.Text = string.Empty;
            textBox_ReleaseDate.Text = string.Empty;
            _main = main;
            _lastID = 0;
            while (true)
            {
                if ((int)new QueryGRDB().ExecuteScalar($"select count(*) from [dbo].[GAMES] WHERE [GAME_ID] = {_lastID}") == 0)
                    break;
                _lastID++;
            }
            Text = "Add id: " + _lastID;
        }

        private void Form_AddGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.Show();
            _main.BringToFront();
            _main.Focus();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_GameName.Text == string.Empty)
                    throw new Exception("Please fill Product's Name");

                if (textBox_Price.Text == String.Empty)
                    throw new Exception("Please fill Product's Price");

                string sqlFormattedDate = textBox_ReleaseDate.Text != String.Empty ?
                    DateTime.ParseExact(textBox_ReleaseDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd")
                    : null;

                var check = new QueryGRDB().ExecuteNonQuery("INSERT INTO [dbo].[GAMES] " +
                    "(GAME_ID, GAME_NAME, GAME_RELEASE_DATE, GAME_DEVELOPER, GAME_PUBLISHER, GAME_PRICE, GAME_DESCRIPTION) " +
                    "VALUES" +
                    "(@gameId, @gameName, @releaseDate, @developer, @publisher, @price, @description)",
                    new SqlParameter("@gameId", _lastID),
                    new SqlParameter("@gameName", textBox_GameName.Text),
                    new SqlParameter("@releaseDate", sqlFormattedDate ?? (object)DBNull.Value),
                    new SqlParameter("@developer", textBox_Developer.Text),
                    new SqlParameter("@publisher", textBox_Publisher.Text),
                    new SqlParameter("@price", textBox_Price.Text),
                    new SqlParameter("@description", textBox_Description.Text));

                if (check <= 0)
                    throw new Exception("Cannot add to database!");

                Close();
                _main.Show();
                _main.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_Description.Text = string.Empty;
            textBox_Developer.Text = string.Empty;
            textBox_GameName.Text = string.Empty;
            textBox_Price.Text = string.Empty;
            textBox_Publisher.Text = string.Empty;
            textBox_ReleaseDate.Text = string.Empty;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
            _main.Show();
            _main.BringToFront();
        }
    }
}
