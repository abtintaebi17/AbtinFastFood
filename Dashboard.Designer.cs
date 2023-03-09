namespace AbtinFastFood
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnlLogOut = new System.Windows.Forms.LinkLabel();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnAdditem = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Report1 = new AbtinFastFood.AllUserControl.UC_Report();
            this.uC_RemoveItems1 = new AbtinFastFood.AllUserControl.UC_RemoveItems();
            this.uC_UpdateItems1 = new AbtinFastFood.AllUserControl.UC_UpdateItems();
            this.uC_welcome2 = new AbtinFastFood.AllUserControl.UC_welcome();
            this.uC_Order1 = new AbtinFastFood.AllUserControl.UC_Order();
            this.uC_AddItem1 = new AbtinFastFood.AllUserControl.UC_AddItem();
            this.uC_welcome1 = new AbtinFastFood.AllUserControl.UC_welcome();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.lnlLogOut);
            this.panel1.Controls.Add(this.btnRemoveItem);
            this.panel1.Controls.Add(this.btnUpdateItem);
            this.panel1.Controls.Add(this.btnAdditem);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnorder);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 0;
            // 
            // lnlLogOut
            // 
            this.lnlLogOut.AutoSize = true;
            this.lnlLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlLogOut.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lnlLogOut.Location = new System.Drawing.Point(61, 439);
            this.lnlLogOut.Name = "lnlLogOut";
            this.lnlLogOut.Size = new System.Drawing.Size(73, 20);
            this.lnlLogOut.TabIndex = 1;
            this.lnlLogOut.TabStop = true;
            this.lnlLogOut.Text = "Log Out";
            this.lnlLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlLogOut_LinkClicked);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(20, 278);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(156, 36);
            this.btnRemoveItem.TabIndex = 0;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdateItem.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnUpdateItem.FlatAppearance.BorderSize = 0;
            this.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItem.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItem.Location = new System.Drawing.Point(20, 210);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(156, 36);
            this.btnUpdateItem.TabIndex = 0;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnAdditem
            // 
            this.btnAdditem.BackColor = System.Drawing.Color.Maroon;
            this.btnAdditem.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAdditem.FlatAppearance.BorderSize = 0;
            this.btnAdditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdditem.ForeColor = System.Drawing.Color.White;
            this.btnAdditem.Location = new System.Drawing.Point(20, 146);
            this.btnAdditem.Name = "btnAdditem";
            this.btnAdditem.Size = new System.Drawing.Size(156, 36);
            this.btnAdditem.TabIndex = 0;
            this.btnAdditem.Text = "Add Item";
            this.btnAdditem.UseVisualStyleBackColor = false;
            this.btnAdditem.Click += new System.EventHandler(this.btnAdditem_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 31);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.Color.Maroon;
            this.btnorder.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnorder.FlatAppearance.BorderSize = 0;
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.ForeColor = System.Drawing.Color.White;
            this.btnorder.Location = new System.Drawing.Point(20, 79);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(156, 36);
            this.btnorder.TabIndex = 0;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.uC_Report1);
            this.panel2.Controls.Add(this.uC_RemoveItems1);
            this.panel2.Controls.Add(this.uC_UpdateItems1);
            this.panel2.Controls.Add(this.uC_welcome2);
            this.panel2.Controls.Add(this.uC_Order1);
            this.panel2.Controls.Add(this.uC_AddItem1);
            this.panel2.Controls.Add(this.uC_welcome1);
            this.panel2.Location = new System.Drawing.Point(218, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 514);
            this.panel2.TabIndex = 0;
            // 
            // uC_Report1
            // 
            this.uC_Report1.BackColor = System.Drawing.Color.Yellow;
            this.uC_Report1.Location = new System.Drawing.Point(0, 0);
            this.uC_Report1.Name = "uC_Report1";
            this.uC_Report1.Size = new System.Drawing.Size(781, 514);
            this.uC_Report1.TabIndex = 6;
            // 
            // uC_RemoveItems1
            // 
            this.uC_RemoveItems1.AllowDrop = true;
            this.uC_RemoveItems1.BackColor = System.Drawing.Color.Yellow;
            this.uC_RemoveItems1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_RemoveItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_RemoveItems1.Name = "uC_RemoveItems1";
            this.uC_RemoveItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_RemoveItems1.TabIndex = 5;
            // 
            // uC_UpdateItems1
            // 
            this.uC_UpdateItems1.BackColor = System.Drawing.Color.Yellow;
            this.uC_UpdateItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItems1.Name = "uC_UpdateItems1";
            this.uC_UpdateItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_UpdateItems1.TabIndex = 4;
            // 
            // uC_welcome2
            // 
            this.uC_welcome2.BackColor = System.Drawing.Color.White;
            this.uC_welcome2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_welcome2.BackgroundImage")));
            this.uC_welcome2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_welcome2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_welcome2.Location = new System.Drawing.Point(0, 0);
            this.uC_welcome2.Name = "uC_welcome2";
            this.uC_welcome2.Size = new System.Drawing.Size(781, 515);
            this.uC_welcome2.TabIndex = 3;
            // 
            // uC_Order1
            // 
            this.uC_Order1.BackColor = System.Drawing.Color.Yellow;
            this.uC_Order1.ForeColor = System.Drawing.Color.Black;
            this.uC_Order1.Location = new System.Drawing.Point(0, 0);
            this.uC_Order1.Name = "uC_Order1";
            this.uC_Order1.Size = new System.Drawing.Size(781, 514);
            this.uC_Order1.TabIndex = 2;
            this.uC_Order1.Load += new System.EventHandler(this.uC_Order1_Load);
            // 
            // uC_AddItem1
            // 
            this.uC_AddItem1.BackColor = System.Drawing.Color.Yellow;
            this.uC_AddItem1.ForeColor = System.Drawing.Color.Black;
            this.uC_AddItem1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddItem1.Name = "uC_AddItem1";
            this.uC_AddItem1.Size = new System.Drawing.Size(781, 514);
            this.uC_AddItem1.TabIndex = 1;
            this.uC_AddItem1.Load += new System.EventHandler(this.uC_AddItem1_Load);
            // 
            // uC_welcome1
            // 
            this.uC_welcome1.BackColor = System.Drawing.Color.White;
            this.uC_welcome1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_welcome1.BackgroundImage")));
            this.uC_welcome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_welcome1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_welcome1.Location = new System.Drawing.Point(0, 0);
            this.uC_welcome1.Name = "uC_welcome1";
            this.uC_welcome1.Size = new System.Drawing.Size(781, 514);
            this.uC_welcome1.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Maroon;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(36, 330);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(117, 44);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1004, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnAdditem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lnlLogOut;
        private AllUserControl.UC_welcome uC_welcome1;
        private AllUserControl.UC_AddItem uC_AddItem1;
        private AllUserControl.UC_Order uC_Order1;
        private AllUserControl.UC_welcome uC_welcome2;
        private AllUserControl.UC_UpdateItems uC_UpdateItems1;
        private AllUserControl.UC_RemoveItems uC_RemoveItems1;
        private AllUserControl.UC_Report uC_Report1;
        private System.Windows.Forms.Button btnReport;
    }
}