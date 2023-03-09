namespace AbtinFastFood.AllUserControl
{
    partial class UC_AddItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddItem = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblItemNa = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtIN = new System.Windows.Forms.TextBox();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.txtPr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAddItem
            // 
            this.lblAddItem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItem.Location = new System.Drawing.Point(279, 42);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(195, 23);
            this.lblAddItem.TabIndex = 0;
            this.lblAddItem.Text = "Add New Item";
            this.lblAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(258, 138);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(80, 23);
            this.lblCat.TabIndex = 0;
            this.lblCat.Text = "Category";
            // 
            // lblItemNa
            // 
            this.lblItemNa.AutoSize = true;
            this.lblItemNa.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNa.Location = new System.Drawing.Point(258, 212);
            this.lblItemNa.Name = "lblItemNa";
            this.lblItemNa.Size = new System.Drawing.Size(98, 23);
            this.lblItemNa.TabIndex = 0;
            this.lblItemNa.Text = "Item Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(258, 275);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 23);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(326, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtIN
            // 
            this.txtIN.ForeColor = System.Drawing.Color.Black;
            this.txtIN.Location = new System.Drawing.Point(262, 238);
            this.txtIN.Name = "txtIN";
            this.txtIN.Size = new System.Drawing.Size(237, 20);
            this.txtIN.TabIndex = 2;
            this.txtIN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboCat
            // 
            this.cboCat.ForeColor = System.Drawing.Color.Black;
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Items.AddRange(new object[] {
            "Pizza",
            "Burger",
            "Sandwich",
            "Pasta",
            "Appetizer",
            "Drink"});
            this.cboCat.Location = new System.Drawing.Point(262, 164);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(237, 21);
            this.cboCat.TabIndex = 3;
            this.cboCat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPr
            // 
            this.txtPr.ForeColor = System.Drawing.Color.Black;
            this.txtPr.Location = new System.Drawing.Point(262, 301);
            this.txtPr.Name = "txtPr";
            this.txtPr.Size = new System.Drawing.Size(237, 20);
            this.txtPr.TabIndex = 2;
            this.txtPr.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UC_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.cboCat);
            this.Controls.Add(this.txtPr);
            this.Controls.Add(this.txtIN);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItemNa);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblAddItem);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UC_AddItem";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblItemNa;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtIN;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.TextBox txtPr;
    }
}
