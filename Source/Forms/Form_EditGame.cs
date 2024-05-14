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
        private Form_SpecificGame _previousForm;
        private int _id;

        public Form_EditGame(int id,
            string gameName,
            int width,
            int height,
            object dataImage,
            string description,
            string price,
            string releaseDate,
            string developer,
            string publisher,
            Form_SpecificGame previousForm)
        {
            InitializeComponent();
            _id = id;
            TopLevel = false;
            Visible = true;
            Width = width;
            Height = height;
            Location = new Point(0, 0);
            WindowState = FormWindowState.Maximized;
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Text = gameName;
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
            _previousForm = previousForm;
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
                _previousForm.Show();
                _previousForm.BringToFront();
            }
        }


        private void button_Reset_Click(object sender, EventArgs e)
        {
            this.Close();
            _previousForm.Show();
            _previousForm.BringToFront();
            _previousForm.button_Edit.PerformClick();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            _previousForm.Show();
            _previousForm.BringToFront();
        }
    }
}
