using GameRetailerManagement.Source.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms
{
    public partial class Form_SpecificGame : Form
    {
        public Form_SpecificGame(string gameName,
            int width,
            int height,
            object dataImage,
            string description,
            string price,
            string releaseDate,
            string developer,
            string publisher,
            EventHandler buttonEdit)
        {
            InitializeComponent();
            TopLevel = false;
            Visible = true;
            Width = width;
            Height = height;
            Location = new Point(0, 0);
            WindowState = FormWindowState.Maximized;
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Text = gameName;
            label_GameName.Text = gameName;
            

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

            label_Description.Text = description;
            label_Price.Text = price;
            label_ReleaseDate.Text = releaseDate;
            label_Developer.Text = developer;
            label_Publisher.Text = publisher;
            button_Edit.Click += buttonEdit;
        }

        private void Form_SpecificGame_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Game_DoubleClick(object sender, EventArgs e)
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
                        $"UPDATE [dbo].[GAMES] SET [GAME_IMAGE] = @image WHERE [GAME_NAME] = @name",
                        new SqlParameter("@image", imageBytes),
                        new SqlParameter("@name", label_GameName.Text));
                }
            }
        }

        private void button_CreateBill_Click(object sender, EventArgs e)
        {

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
