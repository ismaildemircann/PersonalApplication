namespace PersonalApplication
{
    partial class UserManagement
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
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.rdbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rdbtnParttime_User = new System.Windows.Forms.RadioButton();
            this.rdbtnUser = new System.Windows.Forms.RadioButton();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblNamed = new System.Windows.Forms.Label();
            this.datagriedUserManagement = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnMainWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagriedUserManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowUsers.Location = new System.Drawing.Point(438, 69);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(168, 56);
            this.btnShowUsers.TabIndex = 1;
            this.btnShowUsers.Text = "Show Users";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // rdbtnAdmin
            // 
            this.rdbtnAdmin.AutoSize = true;
            this.rdbtnAdmin.Location = new System.Drawing.Point(438, 164);
            this.rdbtnAdmin.Name = "rdbtnAdmin";
            this.rdbtnAdmin.Size = new System.Drawing.Size(68, 21);
            this.rdbtnAdmin.TabIndex = 3;
            this.rdbtnAdmin.TabStop = true;
            this.rdbtnAdmin.Text = "Admin";
            this.rdbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // rdbtnParttime_User
            // 
            this.rdbtnParttime_User.AutoSize = true;
            this.rdbtnParttime_User.Location = new System.Drawing.Point(438, 191);
            this.rdbtnParttime_User.Name = "rdbtnParttime_User";
            this.rdbtnParttime_User.Size = new System.Drawing.Size(120, 21);
            this.rdbtnParttime_User.TabIndex = 4;
            this.rdbtnParttime_User.TabStop = true;
            this.rdbtnParttime_User.Text = "Part-time User";
            this.rdbtnParttime_User.UseVisualStyleBackColor = true;
            // 
            // rdbtnUser
            // 
            this.rdbtnUser.AutoSize = true;
            this.rdbtnUser.Location = new System.Drawing.Point(438, 218);
            this.rdbtnUser.Name = "rdbtnUser";
            this.rdbtnUser.Size = new System.Drawing.Size(59, 21);
            this.rdbtnUser.TabIndex = 5;
            this.rdbtnUser.TabStop = true;
            this.rdbtnUser.Text = "User";
            this.rdbtnUser.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChange.Location = new System.Drawing.Point(438, 272);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(168, 56);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblNamed
            // 
            this.lblNamed.AutoSize = true;
            this.lblNamed.Location = new System.Drawing.Point(312, 392);
            this.lblNamed.Name = "lblNamed";
            this.lblNamed.Size = new System.Drawing.Size(0, 17);
            this.lblNamed.TabIndex = 7;
            // 
            // datagriedUserManagement
            // 
            this.datagriedUserManagement.AllowUserToAddRows = false;
            this.datagriedUserManagement.AllowUserToDeleteRows = false;
            this.datagriedUserManagement.AllowUserToResizeColumns = false;
            this.datagriedUserManagement.AllowUserToResizeRows = false;
            this.datagriedUserManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagriedUserManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagriedUserManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.AdminControl});
            this.datagriedUserManagement.Location = new System.Drawing.Point(657, 69);
            this.datagriedUserManagement.MultiSelect = false;
            this.datagriedUserManagement.Name = "datagriedUserManagement";
            this.datagriedUserManagement.ReadOnly = true;
            this.datagriedUserManagement.RowHeadersWidth = 51;
            this.datagriedUserManagement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagriedUserManagement.RowTemplate.Height = 24;
            this.datagriedUserManagement.Size = new System.Drawing.Size(443, 393);
            this.datagriedUserManagement.TabIndex = 8;
            this.datagriedUserManagement.TabStop = false;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Username";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // AdminControl
            // 
            this.AdminControl.HeaderText = "UserType";
            this.AdminControl.MinimumWidth = 6;
            this.AdminControl.Name = "AdminControl";
            this.AdminControl.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Select the user you want to change.";
            // 
            // btnMainWindow
            // 
            this.btnMainWindow.Location = new System.Drawing.Point(61, 392);
            this.btnMainWindow.Name = "btnMainWindow";
            this.btnMainWindow.Size = new System.Drawing.Size(156, 55);
            this.btnMainWindow.TabIndex = 10;
            this.btnMainWindow.Text = "Main Window";
            this.btnMainWindow.UseVisualStyleBackColor = true;
            this.btnMainWindow.Click += new System.EventHandler(this.btnMainWindow_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 491);
            this.Controls.Add(this.btnMainWindow);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.datagriedUserManagement);
            this.Controls.Add(this.lblNamed);
            this.Controls.Add(this.rdbtnAdmin);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.rdbtnUser);
            this.Controls.Add(this.rdbtnParttime_User);
            this.Controls.Add(this.btnShowUsers);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserManagement_FormClosing);
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagriedUserManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.RadioButton rdbtnAdmin;
        private System.Windows.Forms.RadioButton rdbtnParttime_User;
        private System.Windows.Forms.RadioButton rdbtnUser;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblNamed;
        private System.Windows.Forms.DataGridView datagriedUserManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminControl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnMainWindow;
    }
}