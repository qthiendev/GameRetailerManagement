using GameRetailerManagement.Source.Forms.Main;
using GameRetailerManagement.Source.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms.Games
{
    public partial class Form_EditGame : Form
    {
        private readonly Form_GameRetailer _formMain;
        private readonly Form_SpecificGame _formGame;
        private readonly int _gameID;

        public Form_EditGame(int gameID, Form_GameRetailer main, Form_SpecificGame formGame)
        {
            InitializeComponent();

            _gameID = gameID;
            _formMain = main;
            _formGame = formGame;

            LoadGame();
        }

        private void Form_EditGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formMain.Show();
            _formMain.BringToFront();
            _formMain.CurrentSubFormType = Form_GameRetailer.SubFormType.Games;
            _formMain.InitList();
            _formMain.TriggerButtonDetail(_gameID);
        }

        private void LoadGame()
        {
            var data = new QueryGRDB().ExcuteList($"select * from [dbo].[GAMES] where [GAME_ID] = {_gameID}");

            Text = "Edit " + data["GAME_NAME"][0].ToString();

            textBox_GameName.Text = data["GAME_NAME"][0].ToString();
            if (data["GAME_IMAGE"][0] != DBNull.Value)
            {
                var imageData = (byte[])data["GAME_IMAGE"][0];
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox_Game.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox_Game.Image = Properties.Resources.DefaultImage;
                ImageConverter converter = new ImageConverter();
                byte[] imageBytes = (byte[])converter.ConvertTo(pictureBox_Game.Image, typeof(byte[]));
                new QueryGRDB().ExecuteNonQuery(
                    $"UPDATE [dbo].[GAMES] SET [GAME_IMAGE] = @image WHERE [GAME_ID] = @id",
                    new SqlParameter("@image", imageBytes),
                    new SqlParameter("@id", _gameID));
            }

            pictureBox_Game.SizeMode = PictureBoxSizeMode.Zoom;
            textBox_Description.Text = data["GAME_DESCRIPTION"][0].ToString();
            textBox_Price.Text = data["GAME_PRICE"][0].ToString();
            dateTimePicker_ReleaseDate.Value = DateTime.ParseExact(data["GAME_RELEASE_DATE"][0].ToString().Substring(0, 10),
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);
            textBox_Developer.Text = data["GAME_DEVELOPER"][0].ToString();
            textBox_Publisher.Text = data["GAME_PUBLISHER"][0].ToString();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                var releaseDate = dateTimePicker_ReleaseDate.Value.ToString("yyyy-MM-dd");

                // Execute the update query
                if (new QueryGRDB().ExecuteNonQuery(
                    "UPDATE [dbo].[GAMES] SET GAME_NAME = @gameName, " +
                    "GAME_RELEASE_DATE = @releaseDate, " +
                    "GAME_DEVELOPER = @developer, " +
                    "GAME_PUBLISHER = @publisher, " +
                    "GAME_PRICE = @price," +
                    "GAME_DESCRIPTION = @description " +
                    "WHERE GAME_ID = @gameId",
                    new SqlParameter("@gameName", textBox_GameName.Text),
                    new SqlParameter("@releaseDate", releaseDate),
                    new SqlParameter("@developer", textBox_Developer.Text),
                    new SqlParameter("@publisher", textBox_Publisher.Text),
                    new SqlParameter("@price", textBox_Price.Text),
                    new SqlParameter("@description", textBox_Description.Text),
                    new SqlParameter("@gameId", _gameID)
                ) <= 0)
                    throw new Exception($"Cannot modify id:{_gameID}");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            LoadGame();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox_Game_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.JPG;*.GIF;*.PNG)|*.JPG;*.GIF;*.PNG";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_Game.Image = new Bitmap(openFileDialog.FileName);

                    ImageConverter converter = new ImageConverter();
                    byte[] imageBytes = (byte[])converter.ConvertTo(pictureBox_Game.Image, typeof(byte[]));

                    new QueryGRDB().ExecuteNonQuery(
                        $"UPDATE [dbo].[GAMES] SET [GAME_IMAGE] = @image WHERE [GAME_ID] = @id",
                        new SqlParameter("@image", imageBytes),
                        new SqlParameter("@id", _gameID));
                }
            }
        }
    }
}
