namespace CRUDApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClosed = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lbErrorEmail = new System.Windows.Forms.Label();
            this.lbErrorLastName = new System.Windows.Forms.Label();
            this.lbErrorName = new System.Windows.Forms.Label();
            this.btnSaveOrUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgCustomers = new System.Windows.Forms.DataGridView();
            this.panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
            this.panelForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbEmail.Location = new System.Drawing.Point(16, 96);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbLastName.Location = new System.Drawing.Point(291, 45);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(73, 17);
            this.lbLastName.TabIndex = 11;
            this.lbLastName.Text = "Last Name";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(16, 45);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 17);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Name";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(77, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(264, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Silver;
            this.txtLastName.Location = new System.Drawing.Point(370, 40);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(191, 22);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.Enter += new System.EventHandler(this.txtLastName_Enter);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Silver;
            this.txtName.Location = new System.Drawing.Point(77, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Name";
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter_1);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave_1);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(416, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 13;
            this.txtId.Text = "Id";
            this.txtId.Visible = false;
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.panelNavBar.Controls.Add(this.btnMinimize);
            this.panelNavBar.Controls.Add(this.btnClosed);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(614, 25);
            this.panelNavBar.TabIndex = 15;
            this.panelNavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNavBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::CRUDApp.Properties.Resources.Minimize_Icon;
            this.btnMinimize.Location = new System.Drawing.Point(571, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(16, 16);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // btnClosed
            // 
            this.btnClosed.Image = global::CRUDApp.Properties.Resources.Close_Icon;
            this.btnClosed.Location = new System.Drawing.Point(595, 4);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(16, 16);
            this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClosed.TabIndex = 0;
            this.btnClosed.TabStop = false;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.panelForm.Controls.Add(this.lbErrorEmail);
            this.panelForm.Controls.Add(this.lbErrorLastName);
            this.panelForm.Controls.Add(this.lbErrorName);
            this.panelForm.Controls.Add(this.btnSaveOrUpdate);
            this.panelForm.Controls.Add(this.btnInsert);
            this.panelForm.Controls.Add(this.txtId);
            this.panelForm.Controls.Add(this.txtName);
            this.panelForm.Controls.Add(this.txtLastName);
            this.panelForm.Controls.Add(this.txtEmail);
            this.panelForm.Controls.Add(this.lbEmail);
            this.panelForm.Controls.Add(this.lbName);
            this.panelForm.Controls.Add(this.lbLastName);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Location = new System.Drawing.Point(0, 25);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(614, 194);
            this.panelForm.TabIndex = 16;
            // 
            // lbErrorEmail
            // 
            this.lbErrorEmail.AutoSize = true;
            this.lbErrorEmail.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lbErrorEmail.Location = new System.Drawing.Point(83, 121);
            this.lbErrorEmail.Name = "lbErrorEmail";
            this.lbErrorEmail.Size = new System.Drawing.Size(79, 13);
            this.lbErrorEmail.TabIndex = 16;
            this.lbErrorEmail.Text = "ValidatorEmail";
            this.lbErrorEmail.Visible = false;
            // 
            // lbErrorLastName
            // 
            this.lbErrorLastName.AutoSize = true;
            this.lbErrorLastName.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorLastName.ForeColor = System.Drawing.Color.Red;
            this.lbErrorLastName.Location = new System.Drawing.Point(376, 65);
            this.lbErrorLastName.Name = "lbErrorLastName";
            this.lbErrorLastName.Size = new System.Drawing.Size(101, 13);
            this.lbErrorLastName.TabIndex = 15;
            this.lbErrorLastName.Text = "ValidatorLastName";
            this.lbErrorLastName.Visible = false;
            // 
            // lbErrorName
            // 
            this.lbErrorName.AutoSize = true;
            this.lbErrorName.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorName.ForeColor = System.Drawing.Color.Red;
            this.lbErrorName.Location = new System.Drawing.Point(83, 65);
            this.lbErrorName.Name = "lbErrorName";
            this.lbErrorName.Size = new System.Drawing.Size(81, 13);
            this.lbErrorName.TabIndex = 14;
            this.lbErrorName.Text = "ValidatorName";
            this.lbErrorName.Visible = false;
            // 
            // btnSaveOrUpdate
            // 
            this.btnSaveOrUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveOrUpdate.FlatAppearance.BorderSize = 0;
            this.btnSaveOrUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrUpdate.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSaveOrUpdate.Location = new System.Drawing.Point(479, 150);
            this.btnSaveOrUpdate.Name = "btnSaveOrUpdate";
            this.btnSaveOrUpdate.Size = new System.Drawing.Size(123, 38);
            this.btnSaveOrUpdate.TabIndex = 3;
            this.btnSaveOrUpdate.Text = "Save";
            this.btnSaveOrUpdate.UseVisualStyleBackColor = false;
            this.btnSaveOrUpdate.Click += new System.EventHandler(this.btnSaveOrUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Firebrick;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(345, 150);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(123, 38);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Delete";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dtgCustomers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 231);
            this.panel1.TabIndex = 17;
            // 
            // dtgCustomers
            // 
            this.dtgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCustomers.Location = new System.Drawing.Point(0, 0);
            this.dtgCustomers.Name = "dtgCustomers";
            this.dtgCustomers.Size = new System.Drawing.Size(614, 231);
            this.dtgCustomers.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelNavBar);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelNavBar.ResumeLayout(false);
            this.panelNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClosed;
        private System.Windows.Forms.Button btnSaveOrUpdate;
        private System.Windows.Forms.DataGridView dtgCustomers;
        private System.Windows.Forms.Label lbErrorEmail;
        private System.Windows.Forms.Label lbErrorLastName;
        private System.Windows.Forms.Label lbErrorName;
    }
}

