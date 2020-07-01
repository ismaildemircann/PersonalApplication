namespace PersonalApplication
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnUser_Management = new System.Windows.Forms.Button();
            this.lbluser_management = new System.Windows.Forms.Label();
            this.btnPhonebook = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnPersonalInformation = new System.Windows.Forms.Button();
            this.btnSalaryCalculator = new System.Windows.Forms.Button();
            this.btnReminder = new System.Windows.Forms.Button();
            this.ReminderTimer = new System.Windows.Forms.Timer(this.components);
            this.ShakeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExport.Location = new System.Drawing.Point(322, 170);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(153, 56);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.Location = new System.Drawing.Point(15, 390);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(150, 46);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUser_Management
            // 
            this.btnUser_Management.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUser_Management.Location = new System.Drawing.Point(609, 14);
            this.btnUser_Management.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnUser_Management.Name = "btnUser_Management";
            this.btnUser_Management.Size = new System.Drawing.Size(176, 70);
            this.btnUser_Management.TabIndex = 5;
            this.btnUser_Management.Text = "User Management";
            this.btnUser_Management.UseVisualStyleBackColor = true;
            this.btnUser_Management.Click += new System.EventHandler(this.btnUser_Management_Click);
            // 
            // lbluser_management
            // 
            this.lbluser_management.AutoSize = true;
            this.lbluser_management.Location = new System.Drawing.Point(598, 99);
            this.lbluser_management.Name = "lbluser_management";
            this.lbluser_management.Size = new System.Drawing.Size(0, 17);
            this.lbluser_management.TabIndex = 6;
            // 
            // btnPhonebook
            // 
            this.btnPhonebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPhonebook.Location = new System.Drawing.Point(15, 14);
            this.btnPhonebook.Name = "btnPhonebook";
            this.btnPhonebook.Size = new System.Drawing.Size(153, 56);
            this.btnPhonebook.TabIndex = 7;
            this.btnPhonebook.Text = "Phonebook";
            this.btnPhonebook.UseVisualStyleBackColor = true;
            this.btnPhonebook.Click += new System.EventHandler(this.btnPhonebook_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotes.Location = new System.Drawing.Point(15, 83);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(154, 48);
            this.btnNotes.TabIndex = 8;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnPersonalInformation
            // 
            this.btnPersonalInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonalInformation.Location = new System.Drawing.Point(609, 162);
            this.btnPersonalInformation.Name = "btnPersonalInformation";
            this.btnPersonalInformation.Size = new System.Drawing.Size(176, 72);
            this.btnPersonalInformation.TabIndex = 9;
            this.btnPersonalInformation.Text = "Personal Information";
            this.btnPersonalInformation.UseVisualStyleBackColor = true;
            this.btnPersonalInformation.Click += new System.EventHandler(this.btnPersonalInformation_Click);
            // 
            // btnSalaryCalculator
            // 
            this.btnSalaryCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalaryCalculator.Location = new System.Drawing.Point(15, 146);
            this.btnSalaryCalculator.Name = "btnSalaryCalculator";
            this.btnSalaryCalculator.Size = new System.Drawing.Size(154, 64);
            this.btnSalaryCalculator.TabIndex = 10;
            this.btnSalaryCalculator.Text = "Salary Calculator";
            this.btnSalaryCalculator.UseVisualStyleBackColor = true;
            this.btnSalaryCalculator.Click += new System.EventHandler(this.btnSalaryCalculator_Click);
            // 
            // btnReminder
            // 
            this.btnReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReminder.Location = new System.Drawing.Point(16, 225);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(153, 56);
            this.btnReminder.TabIndex = 11;
            this.btnReminder.Text = "Reminder";
            this.btnReminder.UseVisualStyleBackColor = true;
            this.btnReminder.Click += new System.EventHandler(this.btnReminder_Click);
            // 
            // ReminderTimer
            // 
            this.ReminderTimer.Enabled = true;
            this.ReminderTimer.Interval = 1000;
            this.ReminderTimer.Tick += new System.EventHandler(this.ReminderTimer_Tick);
            // 
            // ShakeTimer
            // 
            this.ShakeTimer.Enabled = true;
            this.ShakeTimer.Interval = 1000;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReminder);
            this.Controls.Add(this.btnSalaryCalculator);
            this.Controls.Add(this.btnPersonalInformation);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnPhonebook);
            this.Controls.Add(this.lbluser_management);
            this.Controls.Add(this.btnUser_Management);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnLogOut);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnUser_Management;
        private System.Windows.Forms.Label lbluser_management;
        private System.Windows.Forms.Button btnPhonebook;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnPersonalInformation;
        private System.Windows.Forms.Button btnSalaryCalculator;
        private System.Windows.Forms.Button btnReminder;
        private System.Windows.Forms.Timer ReminderTimer;
        private System.Windows.Forms.Timer ShakeTimer;
    }
}