namespace WindowsFormsApp1
{
    partial class Waiters
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
            this.dtgShowWaiters = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblWaiterId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShowWaiters)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgShowWaiters
            // 
            this.dtgShowWaiters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgShowWaiters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgShowWaiters.Location = new System.Drawing.Point(0, 0);
            this.dtgShowWaiters.Name = "dtgShowWaiters";
            this.dtgShowWaiters.Size = new System.Drawing.Size(458, 326);
            this.dtgShowWaiters.TabIndex = 0;
            this.dtgShowWaiters.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgShowWaiters_RowHeaderMouseDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(464, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 326);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblWaiterId
            // 
            this.lblWaiterId.AutoSize = true;
            this.lblWaiterId.Location = new System.Drawing.Point(390, 9);
            this.lblWaiterId.Name = "lblWaiterId";
            this.lblWaiterId.Size = new System.Drawing.Size(35, 13);
            this.lblWaiterId.TabIndex = 2;
            this.lblWaiterId.Text = "label1";
            this.lblWaiterId.Visible = false;
            // 
            // Waiters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 327);
            this.Controls.Add(this.lblWaiterId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtgShowWaiters);
            this.Name = "Waiters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waiters";
            this.Load += new System.EventHandler(this.Waiters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgShowWaiters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgShowWaiters;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblWaiterId;
    }
}