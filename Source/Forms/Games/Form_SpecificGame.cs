using GameRetailerManagement.Source.Utilities;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms.Games
{
    public partial class Form_SpecificGame : Form
    {
        private int _gameID;
        private Form_Main _formMain;
        public Form_SpecificGame(int gameID,
            int width,
            int height,
            Form_Main _main)
        {
            InitializeComponent();
            _gameID = gameID;
            _formMain = _main;

            var data = new QueryGRDB().ExcuteList($"select * from [dbo].[GAMES] where [GAME_ID] = {_gameID}");

            TopLevel = false;
            Visible = true;
            Location = new Point(0, 0);
            WindowState = FormWindowState.Maximized;
            Width = width;
            Height = height;
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Text = data["GAME_NAME"][0].ToString();
            label_GameName.Text = data["GAME_NAME"][0].ToString();


            if (data["GAME_IMAGE"][0] != DBNull.Value)
            {
                var imageData = (byte[])data["GAME_IMAGE"][0];
                using (MemoryStream ms = new MemoryStream(imageData))
                    pictureBox_Game.Image = Image.FromStream(ms);
            }
            else
                pictureBox_Game.Image = Properties.Resources.DefaultImage;

            pictureBox_Game.SizeMode = PictureBoxSizeMode.Zoom;

            textBox_Description.Text = data["GAME_DESCRIPTION"][0].ToString();
            label_Price.Text = data["GAME_PRICE"][0].ToString();
            label_ReleaseDate.Text = data["GAME_RELEASE_DATE"][0].ToString().Substring(0, 10);
            label_Developer.Text = data["GAME_DEVELOPER"][0].ToString();
            label_Publisher.Text = data["GAME_PUBLISHER"][0].ToString();
        }

        private void button_CreateBill_Click(object sender, EventArgs e)
        {

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                _formMain.Hide();
                Form_EditGame editForm = new Form_EditGame(_gameID, _formMain);
                editForm.Show();
                editForm.BringToFront();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (new QueryGRDB().ExecuteNonQuery($"delete from [dbo].[Games] where GAME_ID = {_gameID}") <= 0)
                    throw new Exception("Cannot delete Product!");

                Close();
                _formMain.InitList(_formMain.CurrentSubFormType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
