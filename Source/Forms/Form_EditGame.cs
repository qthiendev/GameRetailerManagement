using GameRetailerManagement.Source.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms
{
    public partial class Form_EditGame : Form
    {
        private readonly Form_Main _formMain;
        private readonly int _id;

        public Form_EditGame(int id,
            string gameName,
            object dataImage,
            string description,
            string price,
            string releaseDate,
            string developer,
            string publisher,
            Form_Main main)
        {
            InitializeComponent();
            _id = id;
            Text = "Edit " + gameName;
            textBox_GameName.Text = gameName;
            if (dataImage != DBNull.Value)
            {
                var imageData = (byte[])dataImage;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox_Game.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox_Game.Image = Properties.Resources.DefaultImage;
            }
            pictureBox_Game.SizeMode = PictureBoxSizeMode.Zoom;
            textBox_Description.Text = description;
            textBox_Price.Text = price;
            textBox_ReleaseDate.Text = releaseDate;
            textBox_Developer.Text = developer;
            textBox_Publisher.Text = publisher;
            _formMain = main;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime releaseDate = DateTime.ParseExact(textBox_ReleaseDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string sqlFormattedDate = releaseDate.ToString("yyyy-MM-dd");

                // Execute the update query
                Console.WriteLine(new QueryGRDB().ExecuteNonQuery(
                    "UPDATE [dbo].[GAMES] SET GAME_NAME = @gameName, " +
                    "GAME_RELEASE_DATE = @releaseDate, " +
                    "GAME_DEVELOPER = @developer, " +
                    "GAME_PUBLISHER = @publisher, " +
                    "GAME_PRICE = @price," +
                    "GAME_DESCRIPTION = @description " +
                    "WHERE GAME_ID = @gameId",
                    new SqlParameter("@gameName", textBox_GameName.Text),
                    new SqlParameter("@releaseDate", sqlFormattedDate),
                    new SqlParameter("@developer", textBox_Developer.Text),
                    new SqlParameter("@publisher", textBox_Publisher.Text),
                    new SqlParameter("@price", textBox_Price.Text),
                    new SqlParameter("@description", textBox_Description.Text),
                    new SqlParameter("@gameId", _id)
                ));
            }
            catch
            {

            }
            finally
            {
                this.Close();
                _formMain.Show();
                _formMain.BringToFront();
                _formMain.InitGamesList();
            }
        }


        private void button_Reset_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
            _formMain.Show();
            _formMain.BringToFront();
        }

        private void Form_EditGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formMain.Show();
            _formMain.BringToFront();
        }
    }
}
