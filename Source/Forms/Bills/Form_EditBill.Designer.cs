namespace GameRetailerManagement.Source.Forms.Bills
{
    partial class Form_EditBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_AddGame = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.label_TotalPayment = new System.Windows.Forms.Label();
            this.dateTimePicker_CreatedDate = new System.Windows.Forms.DateTimePicker();
            this.panel_GameList = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_GameID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Reset
            // 
            this.button_Reset.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.Location = new System.Drawing.Point(563, 128);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(101, 39);
            this.button_Reset.TabIndex = 26;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirm.Location = new System.Drawing.Point(456, 128);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(101, 39);
            this.button_Confirm.TabIndex = 25;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Total payment: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Created date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer\'s name: ";
            // 
            // button_Back
            // 
            this.button_Back.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Back.Location = new System.Drawing.Point(670, 128);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(101, 39);
            this.button_Back.TabIndex = 27;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_AddGame
            // 
            this.button_AddGame.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddGame.Location = new System.Drawing.Point(72, 150);
            this.button_AddGame.Name = "button_AddGame";
            this.button_AddGame.Size = new System.Drawing.Size(51, 25);
            this.button_AddGame.TabIndex = 28;
            this.button_AddGame.Text = "Add";
            this.button_AddGame.UseVisualStyleBackColor = true;
            this.button_AddGame.Click += new System.EventHandler(this.button_AddGame_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remove.Location = new System.Drawing.Point(131, 150);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(79, 25);
            this.button_Remove.TabIndex = 29;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CustomerName.Location = new System.Drawing.Point(200, 6);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(260, 30);
            this.textBox_CustomerName.TabIndex = 36;
            // 
            // label_TotalPayment
            // 
            this.label_TotalPayment.AutoSize = true;
            this.label_TotalPayment.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalPayment.Location = new System.Drawing.Point(196, 79);
            this.label_TotalPayment.Name = "label_TotalPayment";
            this.label_TotalPayment.Size = new System.Drawing.Size(180, 22);
            this.label_TotalPayment.TabIndex = 24;
            this.label_TotalPayment.Text = "[label_TotalPayment]";
            // 
            // dateTimePicker_CreatedDate
            // 
            this.dateTimePicker_CreatedDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_CreatedDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_CreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_CreatedDate.Location = new System.Drawing.Point(200, 43);
            this.dateTimePicker_CreatedDate.Name = "dateTimePicker_CreatedDate";
            this.dateTimePicker_CreatedDate.Size = new System.Drawing.Size(260, 30);
            this.dateTimePicker_CreatedDate.TabIndex = 37;
            // 
            // panel_GameList
            // 
            this.panel_GameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_GameList.AutoScroll = true;
            this.panel_GameList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_GameList.Location = new System.Drawing.Point(12, 181);
            this.panel_GameList.Name = "panel_GameList";
            this.panel_GameList.Size = new System.Drawing.Size(759, 352);
            this.panel_GameList.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 40;
            this.label4.Text = "Game ID:";
            // 
            // comboBox_GameID
            // 
            this.comboBox_GameID.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_GameID.FormattingEnabled = true;
            this.comboBox_GameID.Location = new System.Drawing.Point(72, 125);
            this.comboBox_GameID.Name = "comboBox_GameID";
            this.comboBox_GameID.Size = new System.Drawing.Size(138, 20);
            this.comboBox_GameID.TabIndex = 41;
            // 
            // Form_EditBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 545);
            this.Controls.Add(this.comboBox_GameID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel_GameList);
            this.Controls.Add(this.dateTimePicker_CreatedDate);
            this.Controls.Add(this.textBox_CustomerName);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_AddGame);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.label_TotalPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_EditBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_EditBill";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_EditBill_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Reset;
        public System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Back;
        public System.Windows.Forms.Button button_AddGame;
        public System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private System.Windows.Forms.Label label_TotalPayment;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CreatedDate;
        private System.Windows.Forms.Panel panel_GameList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_GameID;
    }
}