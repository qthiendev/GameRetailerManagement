namespace GameRetailerManagement.Source.Forms.Bills
{
    partial class Form_AddBill
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
            this.dateTimePicker_CreatedDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_BillID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker_CreatedDate
            // 
            this.dateTimePicker_CreatedDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_CreatedDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_CreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_CreatedDate.Location = new System.Drawing.Point(204, 106);
            this.dateTimePicker_CreatedDate.Name = "dateTimePicker_CreatedDate";
            this.dateTimePicker_CreatedDate.Size = new System.Drawing.Size(288, 30);
            this.dateTimePicker_CreatedDate.TabIndex = 52;
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CustomerName.Location = new System.Drawing.Point(204, 69);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(288, 30);
            this.textBox_CustomerName.TabIndex = 51;
            // 
            // button_Back
            // 
            this.button_Back.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Back.Location = new System.Drawing.Point(338, 195);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(101, 39);
            this.button_Back.TabIndex = 48;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.Location = new System.Drawing.Point(193, 195);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(101, 39);
            this.button_Reset.TabIndex = 47;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirm.Location = new System.Drawing.Point(40, 195);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(101, 39);
            this.button_Confirm.TabIndex = 46;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "Created date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Customer\'s name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 53;
            this.label3.Text = "Bill ID: ";
            // 
            // label_BillID
            // 
            this.label_BillID.AutoSize = true;
            this.label_BillID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BillID.Location = new System.Drawing.Point(200, 36);
            this.label_BillID.Name = "label_BillID";
            this.label_BillID.Size = new System.Drawing.Size(115, 22);
            this.label_BillID.TabIndex = 54;
            this.label_BillID.Text = "[label_BillID]";
            // 
            // Form_AddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 257);
            this.Controls.Add(this.label_BillID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_CreatedDate);
            this.Controls.Add(this.textBox_CustomerName);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBill";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AddBill_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker_CreatedDate;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Reset;
        public System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_BillID;
    }
}