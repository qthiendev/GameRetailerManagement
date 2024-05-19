using GameRetailerManagement.Source.Forms.Bills;
using GameRetailerManagement.Source.Forms.Games;
using GameRetailerManagement.Source.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms
{
    public partial class Form_Main : Form
    {
        private Form _currentSubForm;

        public enum SubFormType { Games, Bills }
        private SubFormType _currentSubFormType;

        public Form CurrentSubForm { get => _currentSubForm; set => _currentSubForm = value; }
        public SubFormType CurrentSubFormType { get => _currentSubFormType; set => _currentSubFormType = value; }

        public Form_Main()
        {
            InitializeComponent();
            toolStripStatusLabel_Datetime.Text = DateTime.Now.ToString();
            CurrentSubForm = null;
        }

        private EventHandler ButtonDetail(SubFormType formType, int id)
        {
            return (s, e) =>
            {
                CurrentSubForm?.Close();

                if (formType == SubFormType.Games)
                    CurrentSubForm = new Form_SpecificGame(id, panel_Main.Width, panel_Main.Height, this);
                else
                    CurrentSubForm = new Form_SpecificBill(id, panel_Main.Width, panel_Main.Height, this);

                panel_Main.Controls.Add(CurrentSubForm);
                CurrentSubForm.Show();
                CurrentSubForm.BringToFront();
            };
        }

        public void InitList(SubFormType formType, string criteria = "")
        {
            try
            {
                flowLayoutPanel_List.Controls.Clear();

                var queryGames = "Select [GAME_ID] as [ID], " +
                    "[GAME_NAME] as [NAME] " +
                    "from [dbo].[GAMES] " +
                    "order by [GAME_NAME];";

                var queryBills = "Select [BILL_ID] as [ID]," +
                    "('[' + convert(nvarchar(10), [BILL_CREATE_DATE], 103) + '] ' + [CUSTOMER_NAME]) as [NAME]" +
                    "from [dbo].[BILLS]" +
                    "order by [BILL_CREATE_DATE] desc";

                var data = new QueryGRDB().ExcuteList(formType == SubFormType.Games ? queryGames : queryBills);
                var posY = 0;

                for (int i = 0; i < data["ID"].Count; i++)
                {
                    var itemName = data["NAME"][i].ToString();
                    var id = int.Parse(data["ID"][i].ToString());

                    if (itemName.ToUpper().Contains(criteria.ToUpper()))
                    {
                        var button = new Button
                        {
                            Text = itemName,
                            Location = new Point(0, 26 * posY),
                            Font = new Font("Cambria", 12, FontStyle.Bold),
                            Size = new Size(250, 26),
                            BackColor = Color.Transparent,
                            FlatStyle = FlatStyle.Flat,
                            TextAlign = ContentAlignment.MiddleLeft,
                            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                            ForeColor = Color.DarkBlue,
                        };

                        button.FlatAppearance.BorderSize = 0;
                        button.BringToFront();
                        button.Click += ButtonDetail(formType, id);

                        flowLayoutPanel_List.Controls.Add(button);
                        posY += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripMenuItem_NewGame_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                var lastID = (decimal)new QueryGRDB().ExecuteScalar("SELECT MAX([GAME_ID]) FROM [dbo].[GAMES]");
                Form_AddGame form_AddGame = new Form_AddGame(this);
                form_AddGame.Show();
                form_AddGame.BringToFront();
            }
            catch (Exception ex)
            {
                Show();
                BringToFront();
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripMenuItem_OpenGameList_Click(object sender, EventArgs e)
        {
            CurrentSubFormType = SubFormType.Games;
            InitList(CurrentSubFormType);
            textBox_Search.Focus();
        }

        private void toolStripMenuItem_OpenBillList_Click(object sender, EventArgs e)
        {
            CurrentSubFormType = SubFormType.Bills;
            InitList(CurrentSubFormType);
            textBox_Search.Focus();
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            InitList(CurrentSubFormType, textBox_Search.Text);
            textBox_Search.Focus();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            InitList(CurrentSubFormType);
            textBox_Search.Text = "";
            CurrentSubForm?.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Datetime.Text = DateTime.Now.ToString();
        }
    }
}
