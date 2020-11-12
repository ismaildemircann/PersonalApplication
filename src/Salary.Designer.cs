namespace PersonalApplication
{
    partial class Salary
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
            this.btnMainWindow = new System.Windows.Forms.Button();
            this.grpBoxDegree = new System.Windows.Forms.GroupBox();
            this.grpBoxNotRelatedProf = new System.Windows.Forms.GroupBox();
            this.cmbBoxNotRelatedProf = new System.Windows.Forms.ComboBox();
            this.grpBoxRelatedProf = new System.Windows.Forms.GroupBox();
            this.cmbBoxRelatedProf = new System.Windows.Forms.ComboBox();
            this.grpBoxStatusFamily = new System.Windows.Forms.GroupBox();
            this.chckBoxOver18 = new System.Windows.Forms.CheckBox();
            this.chckBox7_17Child = new System.Windows.Forms.CheckBox();
            this.chckBox0_6Child = new System.Windows.Forms.CheckBox();
            this.chckBoxMarriedSpouseNoWork = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblExperienceYear = new System.Windows.Forms.Label();
            this.cmbBoxExperienceYear = new System.Windows.Forms.ComboBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.cmbboxProvince = new System.Windows.Forms.ComboBox();
            this.grpBoxForeignLanguage = new System.Windows.Forms.GroupBox();
            this.lblOtherLanguageNum = new System.Windows.Forms.Label();
            this.cmbBoxOtherLanguageNum = new System.Windows.Forms.ComboBox();
            this.chckBoxEnglishSchool = new System.Windows.Forms.CheckBox();
            this.chckBoxEnglish = new System.Windows.Forms.CheckBox();
            this.cmbBoxManagPos = new System.Windows.Forms.ComboBox();
            this.lblManagementPosition = new System.Windows.Forms.Label();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.grpBoxDegree.SuspendLayout();
            this.grpBoxNotRelatedProf.SuspendLayout();
            this.grpBoxRelatedProf.SuspendLayout();
            this.grpBoxStatusFamily.SuspendLayout();
            this.grpBoxForeignLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainWindow
            // 
            this.btnMainWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMainWindow.Location = new System.Drawing.Point(737, 464);
            this.btnMainWindow.Name = "btnMainWindow";
            this.btnMainWindow.Size = new System.Drawing.Size(171, 51);
            this.btnMainWindow.TabIndex = 14;
            this.btnMainWindow.Text = "Main Window";
            this.btnMainWindow.UseVisualStyleBackColor = true;
            this.btnMainWindow.Click += new System.EventHandler(this.btnMainWindow_Click);
            // 
            // grpBoxDegree
            // 
            this.grpBoxDegree.Controls.Add(this.grpBoxNotRelatedProf);
            this.grpBoxDegree.Controls.Add(this.grpBoxRelatedProf);
            this.grpBoxDegree.Location = new System.Drawing.Point(491, 257);
            this.grpBoxDegree.Name = "grpBoxDegree";
            this.grpBoxDegree.Size = new System.Drawing.Size(208, 185);
            this.grpBoxDegree.TabIndex = 17;
            this.grpBoxDegree.TabStop = false;
            this.grpBoxDegree.Text = "Degree";
            // 
            // grpBoxNotRelatedProf
            // 
            this.grpBoxNotRelatedProf.Controls.Add(this.cmbBoxNotRelatedProf);
            this.grpBoxNotRelatedProf.Location = new System.Drawing.Point(20, 101);
            this.grpBoxNotRelatedProf.Name = "grpBoxNotRelatedProf";
            this.grpBoxNotRelatedProf.Size = new System.Drawing.Size(183, 71);
            this.grpBoxNotRelatedProf.TabIndex = 1;
            this.grpBoxNotRelatedProf.TabStop = false;
            this.grpBoxNotRelatedProf.Text = "Not Related to the Profession";
            // 
            // cmbBoxNotRelatedProf
            // 
            this.cmbBoxNotRelatedProf.FormattingEnabled = true;
            this.cmbBoxNotRelatedProf.Items.AddRange(new object[] {
            "Master Degree",
            "Doctor\'s Degree",
            "Associate Professor",
            "None"});
            this.cmbBoxNotRelatedProf.Location = new System.Drawing.Point(6, 42);
            this.cmbBoxNotRelatedProf.Name = "cmbBoxNotRelatedProf";
            this.cmbBoxNotRelatedProf.Size = new System.Drawing.Size(171, 24);
            this.cmbBoxNotRelatedProf.TabIndex = 24;
            // 
            // grpBoxRelatedProf
            // 
            this.grpBoxRelatedProf.Controls.Add(this.cmbBoxRelatedProf);
            this.grpBoxRelatedProf.Location = new System.Drawing.Point(20, 21);
            this.grpBoxRelatedProf.Name = "grpBoxRelatedProf";
            this.grpBoxRelatedProf.Size = new System.Drawing.Size(183, 74);
            this.grpBoxRelatedProf.TabIndex = 0;
            this.grpBoxRelatedProf.TabStop = false;
            this.grpBoxRelatedProf.Text = "Related to the profession";
            // 
            // cmbBoxRelatedProf
            // 
            this.cmbBoxRelatedProf.FormattingEnabled = true;
            this.cmbBoxRelatedProf.Items.AddRange(new object[] {
            "Master Degree",
            "Doctor\'s Degree",
            "Associate Professor",
            "None"});
            this.cmbBoxRelatedProf.Location = new System.Drawing.Point(6, 40);
            this.cmbBoxRelatedProf.Name = "cmbBoxRelatedProf";
            this.cmbBoxRelatedProf.Size = new System.Drawing.Size(171, 24);
            this.cmbBoxRelatedProf.TabIndex = 24;
            // 
            // grpBoxStatusFamily
            // 
            this.grpBoxStatusFamily.Controls.Add(this.chckBoxOver18);
            this.grpBoxStatusFamily.Controls.Add(this.chckBox7_17Child);
            this.grpBoxStatusFamily.Controls.Add(this.chckBox0_6Child);
            this.grpBoxStatusFamily.Controls.Add(this.chckBoxMarriedSpouseNoWork);
            this.grpBoxStatusFamily.Location = new System.Drawing.Point(491, 23);
            this.grpBoxStatusFamily.Name = "grpBoxStatusFamily";
            this.grpBoxStatusFamily.Size = new System.Drawing.Size(396, 192);
            this.grpBoxStatusFamily.TabIndex = 20;
            this.grpBoxStatusFamily.TabStop = false;
            this.grpBoxStatusFamily.Text = "Status Family";
            // 
            // chckBoxOver18
            // 
            this.chckBoxOver18.AutoSize = true;
            this.chckBoxOver18.Location = new System.Drawing.Point(6, 116);
            this.chckBoxOver18.Name = "chckBoxOver18";
            this.chckBoxOver18.Size = new System.Drawing.Size(349, 55);
            this.chckBoxOver18.TabIndex = 3;
            this.chckBoxOver18.Text = "Child over 18\r\n(Provided that you are a university undergraduate \r\n/ associate de" +
    "gree student)";
            this.chckBoxOver18.UseVisualStyleBackColor = true;
            // 
            // chckBox7_17Child
            // 
            this.chckBox7_17Child.AutoSize = true;
            this.chckBox7_17Child.Location = new System.Drawing.Point(6, 87);
            this.chckBox7_17Child.Name = "chckBox7_17Child";
            this.chckBox7_17Child.Size = new System.Drawing.Size(147, 21);
            this.chckBox7_17Child.TabIndex = 2;
            this.chckBox7_17Child.Text = "7-17 year old child";
            this.chckBox7_17Child.UseVisualStyleBackColor = true;
            // 
            // chckBox0_6Child
            // 
            this.chckBox0_6Child.AutoSize = true;
            this.chckBox0_6Child.Location = new System.Drawing.Point(6, 58);
            this.chckBox0_6Child.Name = "chckBox0_6Child";
            this.chckBox0_6Child.Size = new System.Drawing.Size(139, 21);
            this.chckBox0_6Child.TabIndex = 1;
            this.chckBox0_6Child.Text = "0-6 year old child";
            this.chckBox0_6Child.UseVisualStyleBackColor = true;
            // 
            // chckBoxMarriedSpouseNoWork
            // 
            this.chckBoxMarriedSpouseNoWork.AutoSize = true;
            this.chckBoxMarriedSpouseNoWork.Location = new System.Drawing.Point(6, 29);
            this.chckBoxMarriedSpouseNoWork.Name = "chckBoxMarriedSpouseNoWork";
            this.chckBoxMarriedSpouseNoWork.Size = new System.Drawing.Size(232, 21);
            this.chckBoxMarriedSpouseNoWork.TabIndex = 0;
            this.chckBoxMarriedSpouseNoWork.Text = "Married and spouse not working";
            this.chckBoxMarriedSpouseNoWork.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculate.Location = new System.Drawing.Point(791, 378);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(117, 51);
            this.btnCalculate.TabIndex = 22;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResult.Location = new System.Drawing.Point(737, 338);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(171, 30);
            this.txtResult.TabIndex = 23;
            // 
            // lblExperienceYear
            // 
            this.lblExperienceYear.AutoSize = true;
            this.lblExperienceYear.Location = new System.Drawing.Point(30, 20);
            this.lblExperienceYear.Name = "lblExperienceYear";
            this.lblExperienceYear.Size = new System.Drawing.Size(112, 17);
            this.lblExperienceYear.TabIndex = 24;
            this.lblExperienceYear.Text = "Experience Year";
            // 
            // cmbBoxExperienceYear
            // 
            this.cmbBoxExperienceYear.FormattingEnabled = true;
            this.cmbBoxExperienceYear.Items.AddRange(new object[] {
            "0 - 2",
            "2 - 4",
            "5 - 9",
            "10 - 14",
            "15 - 20",
            "20 and over"});
            this.cmbBoxExperienceYear.Location = new System.Drawing.Point(33, 50);
            this.cmbBoxExperienceYear.Name = "cmbBoxExperienceYear";
            this.cmbBoxExperienceYear.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxExperienceYear.TabIndex = 25;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(30, 87);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(63, 17);
            this.lblProvince.TabIndex = 26;
            this.lblProvince.Text = "Province";
            // 
            // cmbboxProvince
            // 
            this.cmbboxProvince.FormattingEnabled = true;
            this.cmbboxProvince.Items.AddRange(new object[] {
            "TR10: İstanbul",
            "TR51: Ankara",
            "TR31: İzmir",
            "TR42: Kocaeli, Sakarya, Düzce, Bolu, Yalova",
            "TR21: Edirne, Kırklareli, Tekirdağ",
            "TR90: Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane",
            "TR41: Bursa, Eskişehir, Bilecik",
            "TR32: Aydın, Denizli, Muğla",
            "TR62: Adana, Mersin",
            "TR22: Balıkesir, Çanakkale",
            "TR61: Antalya, Isparta, Burdur",
            "Other Provinces"});
            this.cmbboxProvince.Location = new System.Drawing.Point(33, 117);
            this.cmbboxProvince.Name = "cmbboxProvince";
            this.cmbboxProvince.Size = new System.Drawing.Size(417, 24);
            this.cmbboxProvince.TabIndex = 27;
            // 
            // grpBoxForeignLanguage
            // 
            this.grpBoxForeignLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxForeignLanguage.Controls.Add(this.lblOtherLanguageNum);
            this.grpBoxForeignLanguage.Controls.Add(this.cmbBoxOtherLanguageNum);
            this.grpBoxForeignLanguage.Controls.Add(this.chckBoxEnglishSchool);
            this.grpBoxForeignLanguage.Controls.Add(this.chckBoxEnglish);
            this.grpBoxForeignLanguage.Location = new System.Drawing.Point(33, 257);
            this.grpBoxForeignLanguage.Name = "grpBoxForeignLanguage";
            this.grpBoxForeignLanguage.Size = new System.Drawing.Size(417, 185);
            this.grpBoxForeignLanguage.TabIndex = 18;
            this.grpBoxForeignLanguage.TabStop = false;
            this.grpBoxForeignLanguage.Text = "Documented Foreign Language Knowledge";
            // 
            // lblOtherLanguageNum
            // 
            this.lblOtherLanguageNum.AutoSize = true;
            this.lblOtherLanguageNum.Location = new System.Drawing.Point(6, 94);
            this.lblOtherLanguageNum.Name = "lblOtherLanguageNum";
            this.lblOtherLanguageNum.Size = new System.Drawing.Size(386, 17);
            this.lblOtherLanguageNum.TabIndex = 4;
            this.lblOtherLanguageNum.Text = "Numbers of documented other foreign kanguage knowledge";
            // 
            // cmbBoxOtherLanguageNum
            // 
            this.cmbBoxOtherLanguageNum.FormattingEnabled = true;
            this.cmbBoxOtherLanguageNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbBoxOtherLanguageNum.Location = new System.Drawing.Point(9, 121);
            this.cmbBoxOtherLanguageNum.Name = "cmbBoxOtherLanguageNum";
            this.cmbBoxOtherLanguageNum.Size = new System.Drawing.Size(117, 24);
            this.cmbBoxOtherLanguageNum.TabIndex = 2;
            // 
            // chckBoxEnglishSchool
            // 
            this.chckBoxEnglishSchool.AutoSize = true;
            this.chckBoxEnglishSchool.Location = new System.Drawing.Point(7, 63);
            this.chckBoxEnglishSchool.Name = "chckBoxEnglishSchool";
            this.chckBoxEnglishSchool.Size = new System.Drawing.Size(266, 21);
            this.chckBoxEnglishSchool.TabIndex = 1;
            this.chckBoxEnglishSchool.Text = "English Language School Graduation";
            this.chckBoxEnglishSchool.UseVisualStyleBackColor = true;
            // 
            // chckBoxEnglish
            // 
            this.chckBoxEnglish.AutoSize = true;
            this.chckBoxEnglish.Location = new System.Drawing.Point(7, 32);
            this.chckBoxEnglish.Name = "chckBoxEnglish";
            this.chckBoxEnglish.Size = new System.Drawing.Size(233, 21);
            this.chckBoxEnglish.TabIndex = 0;
            this.chckBoxEnglish.Text = "Documented English Knowledge";
            this.chckBoxEnglish.UseVisualStyleBackColor = true;
            // 
            // cmbBoxManagPos
            // 
            this.cmbBoxManagPos.FormattingEnabled = true;
            this.cmbBoxManagPos.Items.AddRange(new object[] {
            "Team Leader / Group Manager / Technical Manager / Software Architect",
            "Project Manager",
            "Director / Projects Manager",
            "CTO / General Manager",
            "IT Manager (If there is a maximum of 5 IT personnel in the department)",
            "IT Manager (If there are more than 5 IT personnel in the IT department)",
            "Other"});
            this.cmbBoxManagPos.Location = new System.Drawing.Point(33, 184);
            this.cmbBoxManagPos.Name = "cmbBoxManagPos";
            this.cmbBoxManagPos.Size = new System.Drawing.Size(417, 24);
            this.cmbBoxManagPos.TabIndex = 28;
            // 
            // lblManagementPosition
            // 
            this.lblManagementPosition.AutoSize = true;
            this.lblManagementPosition.Location = new System.Drawing.Point(30, 154);
            this.lblManagementPosition.Name = "lblManagementPosition";
            this.lblManagementPosition.Size = new System.Drawing.Size(144, 17);
            this.lblManagementPosition.TabIndex = 29;
            this.lblManagementPosition.Text = "Management Position";
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.AutoSize = true;
            this.lblTotalSalary.Location = new System.Drawing.Point(824, 318);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(84, 17);
            this.lblTotalSalary.TabIndex = 30;
            this.lblTotalSalary.Text = "Total Salary";
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 543);
            this.Controls.Add(this.lblTotalSalary);
            this.Controls.Add(this.lblManagementPosition);
            this.Controls.Add(this.cmbBoxManagPos);
            this.Controls.Add(this.cmbboxProvince);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.cmbBoxExperienceYear);
            this.Controls.Add(this.lblExperienceYear);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpBoxStatusFamily);
            this.Controls.Add(this.grpBoxForeignLanguage);
            this.Controls.Add(this.grpBoxDegree);
            this.Controls.Add(this.btnMainWindow);
            this.Name = "Salary";
            this.Text = "Salary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Salary_FormClosing);
            this.Load += new System.EventHandler(this.Salary_Load);
            this.grpBoxDegree.ResumeLayout(false);
            this.grpBoxNotRelatedProf.ResumeLayout(false);
            this.grpBoxRelatedProf.ResumeLayout(false);
            this.grpBoxStatusFamily.ResumeLayout(false);
            this.grpBoxStatusFamily.PerformLayout();
            this.grpBoxForeignLanguage.ResumeLayout(false);
            this.grpBoxForeignLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainWindow;
        private System.Windows.Forms.GroupBox grpBoxDegree;
        private System.Windows.Forms.GroupBox grpBoxStatusFamily;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox grpBoxNotRelatedProf;
        private System.Windows.Forms.GroupBox grpBoxRelatedProf;
        private System.Windows.Forms.ComboBox cmbBoxRelatedProf;
        private System.Windows.Forms.ComboBox cmbBoxNotRelatedProf;
        private System.Windows.Forms.Label lblExperienceYear;
        private System.Windows.Forms.ComboBox cmbBoxExperienceYear;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.ComboBox cmbboxProvince;
        private System.Windows.Forms.GroupBox grpBoxForeignLanguage;
        private System.Windows.Forms.Label lblOtherLanguageNum;
        private System.Windows.Forms.ComboBox cmbBoxOtherLanguageNum;
        private System.Windows.Forms.CheckBox chckBoxEnglishSchool;
        private System.Windows.Forms.CheckBox chckBoxEnglish;
        private System.Windows.Forms.CheckBox chckBoxOver18;
        private System.Windows.Forms.CheckBox chckBox7_17Child;
        private System.Windows.Forms.CheckBox chckBox0_6Child;
        private System.Windows.Forms.CheckBox chckBoxMarriedSpouseNoWork;
        private System.Windows.Forms.ComboBox cmbBoxManagPos;
        private System.Windows.Forms.Label lblManagementPosition;
        private System.Windows.Forms.Label lblTotalSalary;
    }
}