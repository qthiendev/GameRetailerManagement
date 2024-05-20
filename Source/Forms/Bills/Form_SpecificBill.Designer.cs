namespace GameRetailerManagement.Source.Forms.Bills
{
    partial class Form_SpecificBill
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
            this.label_CustomerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_CreatedDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_TotalPayment = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.panel_GameList = new System.Windows.Forms.Panel();
            this.button_Export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_CustomerName
            // 
            this.label_CustomerName.AutoSize = true;
            this.label_CustomerName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerName.Location = new System.Drawing.Point(200, 27);
            this.label_CustomerName.Name = "label_CustomerName";
            this.label_CustomerName.Size = new System.Drawing.Size(195, 22);
            this.label_CustomerName.TabIndex = 4;
            this.label_CustomerName.Text = "[label_CustomerName]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer\'s name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Created date: ";
            // 
            // label_CreatedDate
            // 
            this.label_CreatedDate.AutoSize = true;
            this.label_CreatedDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CreatedDate.Location = new System.Drawing.Point(200, 59);
            this.label_CreatedDate.Name = "label_CreatedDate";
            this.label_CreatedDate.Size = new System.Drawing.Size(169, 22);
            this.label_CreatedDate.TabIndex = 6;
            this.label_CreatedDate.Text = "[label_CreatedDate]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total payment: ";
            // 
            // label_TotalPayment
            // 
            this.label_TotalPayment.AutoSize = true;
            this.label_TotalPayment.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalPayment.Location = new System.Drawing.Point(200, 91);
            this.label_TotalPayment.Name = "label_TotalPayment";
            this.label_TotalPayment.Size = new System.Drawing.Size(180, 22);
            this.label_TotalPayment.TabIndex = 9;
            this.label_TotalPayment.Text = "[label_TotalPayment]";
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(459, 87);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(143, 35);
            this.button_Delete.TabIndex = 17;
            this.button_Delete.Text = "Delete Bill";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Edit.Location = new System.Drawing.Point(459, 46);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(143, 35);
            this.button_Edit.TabIndex = 16;
            this.button_Edit.Text = "Edit Bill";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // panel_GameList
            // 
            this.panel_GameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_GameList.AutoScroll = true;
            this.panel_GameList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_GameList.Location = new System.Drawing.Point(16, 128);
            this.panel_GameList.Name = "panel_GameList";
            this.panel_GameList.Size = new System.Drawing.Size(820, 334);
            this.panel_GameList.TabIndex = 39;
            // 
            // button_Export
            // 
            this.button_Export.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Export.Location = new System.Drawing.Point(608, 46);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(143, 35);
            this.button_Export.TabIndex = 40;
            this.button_Export.Text = "Export";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // Form_SpecificBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 474);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.panel_GameList);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.label_TotalPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_CreatedDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_CustomerName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SpecificBill";
            this.Text = "Form_SpecificBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_CreatedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_TotalPayment;
        private System.Windows.Forms.Button button_Delete;
        public System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Panel panel_GameList;
        private System.Windows.Forms.Button button_Export;
    }
}