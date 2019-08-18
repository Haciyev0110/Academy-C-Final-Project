namespace WindowsFormsApp1
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmMenuTime = new System.Windows.Forms.NumericUpDown();
            this.cmbMenuCategory = new System.Windows.Forms.ComboBox();
            this.nmMenuPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgMenu = new System.Windows.Forms.DataGridView();
            this.btnAddWaiter = new System.Windows.Forms.Button();
            this.btnSaveMenu = new System.Windows.Forms.Button();
            this.btnRemoveMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmMenuTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMenuPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtMenuName
            // 
            this.txtMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuName.Location = new System.Drawing.Point(36, 60);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(198, 29);
            this.txtMenuName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(32, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(32, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prepation time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(32, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price (AZN )";
            // 
            // nmMenuTime
            // 
            this.nmMenuTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmMenuTime.Location = new System.Drawing.Point(36, 225);
            this.nmMenuTime.Name = "nmMenuTime";
            this.nmMenuTime.Size = new System.Drawing.Size(198, 29);
            this.nmMenuTime.TabIndex = 7;
            // 
            // cmbMenuCategory
            // 
            this.cmbMenuCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMenuCategory.FormattingEnabled = true;
            this.cmbMenuCategory.Location = new System.Drawing.Point(36, 312);
            this.cmbMenuCategory.Name = "cmbMenuCategory";
            this.cmbMenuCategory.Size = new System.Drawing.Size(198, 32);
            this.cmbMenuCategory.TabIndex = 8;
            // 
            // nmMenuPrice
            // 
            this.nmMenuPrice.DecimalPlaces = 2;
            this.nmMenuPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmMenuPrice.Location = new System.Drawing.Point(36, 143);
            this.nmMenuPrice.Name = "nmMenuPrice";
            this.nmMenuPrice.Size = new System.Drawing.Size(198, 29);
            this.nmMenuPrice.TabIndex = 9;
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.BackColor = System.Drawing.Color.Green;
            this.btnAddMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddMenu.Location = new System.Drawing.Point(36, 372);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(198, 68);
            this.btnAddMenu.TabIndex = 10;
            this.btnAddMenu.Text = "Add to menu";
            this.btnAddMenu.UseVisualStyleBackColor = false;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(375, 505);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(198, 29);
            this.txtFirstname.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(372, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Firstname";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(596, 505);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(198, 29);
            this.txtLastname.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(592, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lastname";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(375, 604);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(196, 29);
            this.txtUsername.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(371, 576);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(596, 604);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(196, 29);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(592, 576);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Password";
            // 
            // dtgMenu
            // 
            this.dtgMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMenu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMenu.Location = new System.Drawing.Point(376, 60);
            this.dtgMenu.Name = "dtgMenu";
            this.dtgMenu.Size = new System.Drawing.Size(604, 380);
            this.dtgMenu.TabIndex = 20;
            this.dtgMenu.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgMenu_RowHeaderMouseDoubleClick);
            // 
            // btnAddWaiter
            // 
            this.btnAddWaiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWaiter.Location = new System.Drawing.Point(812, 576);
            this.btnAddWaiter.Name = "btnAddWaiter";
            this.btnAddWaiter.Size = new System.Drawing.Size(168, 57);
            this.btnAddWaiter.TabIndex = 21;
            this.btnAddWaiter.Text = "Add Waiter";
            this.btnAddWaiter.UseVisualStyleBackColor = true;
            this.btnAddWaiter.Click += new System.EventHandler(this.btnAddWaiter_Click);
            // 
            // btnSaveMenu
            // 
            this.btnSaveMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSaveMenu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveMenu.Enabled = false;
            this.btnSaveMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveMenu.Location = new System.Drawing.Point(36, 466);
            this.btnSaveMenu.Name = "btnSaveMenu";
            this.btnSaveMenu.Size = new System.Drawing.Size(198, 68);
            this.btnSaveMenu.TabIndex = 22;
            this.btnSaveMenu.Text = "Save";
            this.btnSaveMenu.UseVisualStyleBackColor = false;
            this.btnSaveMenu.Click += new System.EventHandler(this.btnSaveMenu_Click);
            // 
            // btnRemoveMenu
            // 
            this.btnRemoveMenu.BackColor = System.Drawing.Color.Red;
            this.btnRemoveMenu.Enabled = false;
            this.btnRemoveMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveMenu.Location = new System.Drawing.Point(36, 565);
            this.btnRemoveMenu.Name = "btnRemoveMenu";
            this.btnRemoveMenu.Size = new System.Drawing.Size(198, 68);
            this.btnRemoveMenu.TabIndex = 23;
            this.btnRemoveMenu.Text = "Remove";
            this.btnRemoveMenu.UseVisualStyleBackColor = false;
            this.btnRemoveMenu.Click += new System.EventHandler(this.btnRemoveMenu_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(812, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 56);
            this.button1.TabIndex = 24;
            this.button1.Text = "Show Waiters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(287, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 25;
            this.lblID.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(840, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 27);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.Text = "Logout -->";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SaddleBrown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(675, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 27);
            this.button2.TabIndex = 27;
            this.button2.Text = "Show orders";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1011, 659);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoveMenu);
            this.Controls.Add(this.btnSaveMenu);
            this.Controls.Add(this.btnAddWaiter);
            this.Controls.Add(this.dtgMenu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.nmMenuPrice);
            this.Controls.Add(this.cmbMenuCategory);
            this.Controls.Add(this.nmMenuTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmMenuTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMenuPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmMenuTime;
        private System.Windows.Forms.ComboBox cmbMenuCategory;
        private System.Windows.Forms.NumericUpDown nmMenuPrice;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgMenu;
        private System.Windows.Forms.Button btnAddWaiter;
        private System.Windows.Forms.Button btnSaveMenu;
        private System.Windows.Forms.Button btnRemoveMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button2;
    }
}