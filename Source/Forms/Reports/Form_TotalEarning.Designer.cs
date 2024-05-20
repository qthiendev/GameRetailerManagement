namespace GameRetailerManagement.Source.Forms.Reports
{
    partial class Form_TotalEarning
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
            this.panel_GameList = new System.Windows.Forms.Panel();
            this.label_TotalEarning = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_MostSale = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_GameList
            // 
            this.panel_GameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_GameList.AutoScroll = true;
            this.panel_GameList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_GameList.Location = new System.Drawing.Point(386, 12);
            this.panel_GameList.Name = "panel_GameList";
            this.panel_GameList.Size = new System.Drawing.Size(581, 515);
            this.panel_GameList.TabIndex = 39;
            // 
            // label_TotalEarning
            // 
            this.label_TotalEarning.AutoSize = true;
            this.label_TotalEarning.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalEarning.Location = new System.Drawing.Point(161, 50);
            this.label_TotalEarning.Name = "label_TotalEarning";
            this.label_TotalEarning.Size = new System.Drawing.Size(172, 22);
            this.label_TotalEarning.TabIndex = 41;
            this.label_TotalEarning.Text = "[label_TotalEarning]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Total earnings: ";
            // 
            // label_MostSale
            // 
            this.label_MostSale.AutoSize = true;
            this.label_MostSale.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostSale.Location = new System.Drawing.Point(161, 85);
            this.label_MostSale.Name = "label_MostSale";
            this.label_MostSale.Size = new System.Drawing.Size(141, 22);
            this.label_MostSale.TabIndex = 43;
            this.label_MostSale.Text = "[label_MostSale]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Most sales: ";
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(12, 12);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 46;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            // 
            // Form_TotalEarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 539);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label_MostSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_TotalEarning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_GameList);
            this.Name = "Form_TotalEarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_TotalEarning";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_TotalEarning_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_GameList;
        private System.Windows.Forms.Label label_TotalEarning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_MostSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Back;
    }
}