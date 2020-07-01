using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalApplication
{
    public partial class Salary : Form
    {
        SalaryBuilder salaryOfUser;
        SalaryDirector salaryDirector = new SalaryDirector();

        public Salary()
        {
            InitializeComponent();
        }

        private void btnMainWindow_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void Salary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.reallyWant2Exit(e);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                ExperinceYear(cmbBoxExperienceYear.SelectedItem.ToString());
                Province(cmbboxProvince.SelectedItem.ToString());
                ManagementPosition(cmbBoxManagPos.SelectedItem.ToString());
                DocumanteDocumentedForeignLanguageKnowledge();
                StatusFamily();
                Degree(cmbBoxRelatedProf.SelectedItem.ToString(), cmbBoxNotRelatedProf.SelectedItem.ToString());
                txtResult.Text = salaryDirector.Calculate(salaryOfUser).ToString();
                LoginForm.UserList[MainWindow.index].Salary = Double.Parse(txtResult.Text);
                Util.SaveCsv(LoginForm.UserList, LoginForm.UserFilePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill in the places you left blank.");
            }
        }

        private void ExperinceYear(string year)
        {
            if (year == "0 - 2")
                salaryOfUser.Salary.ExperienceYear = 0;
            else if (year == "2 - 4")
                salaryOfUser.Salary.ExperienceYear = 0.60;
            else if (year == "5 - 9")
                salaryOfUser.Salary.ExperienceYear = 1.00;
            else if (year == "10 - 14")
                salaryOfUser.Salary.ExperienceYear = 1.20;
            else if (year == "15 - 20")
                salaryOfUser.Salary.ExperienceYear = 1.35;
            else if (year == "20 and over")
                salaryOfUser.Salary.ExperienceYear = 1.50;
            else
                salaryOfUser.Salary.ExperienceYear = 0;
        }

        private void Province(string province)
        {
            if (province == "TR10: İstanbul")
                salaryOfUser.Salary.Province = 0.15;
            else if (province == "TR51: Ankara")
                salaryOfUser.Salary.Province = 0.10;
            else if (province == "TR31: İzmir")
                salaryOfUser.Salary.Province = 0.10;
            else if (province == "TR42: Kocaeli, Sakarya, Düzce, Bolu, Yalova")
                salaryOfUser.Salary.Province = 0.05;
            else if (province == "TR21: Edirne, Kırklareli, Tekirdağ")
                salaryOfUser.Salary.Province = 0.05;
            else if (province == "TR90: Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane")
                salaryOfUser.Salary.Province = 0.03;
            else if (province == "TR41: Bursa, Eskişehir, Bilecik")
                salaryOfUser.Salary.Province = 0.03;
            else if (province == "TR32: Aydın, Denizli, Muğla")
                salaryOfUser.Salary.Province = 0.03;
            else if (province == "TR62: Adana, Mersin")
                salaryOfUser.Salary.Province = 0.03;
            else if (province == "TR22: Balıkesir, Çanakkale")
                salaryOfUser.Salary.Province = 0.03;
            else if (province == "TR61: Antalya, Isparta, Burdur")
                salaryOfUser.Salary.Province = 0.03;
            else if (province == "Other Provinces")
                salaryOfUser.Salary.Province = 0;
            else
                salaryOfUser.Salary.Province = 0;
        }

        private void ManagementPosition(string position)
        {
            if (position == "Team Leader / Group Manager / Technical Manager / Software Architect")
                salaryOfUser.Salary.ManagementPosition = 0.50;
            else if (position == "Project Manager")
                salaryOfUser.Salary.ManagementPosition = 0.75;
            else if (position == "Director / Projects Manager")
                salaryOfUser.Salary.ManagementPosition = 0.85;
            else if (position == "CTO / General Manager")
                salaryOfUser.Salary.ManagementPosition = 1.00;
            else if (position == "IT Manager (If there is a maximum of 5 IT personnel in the department)")
                salaryOfUser.Salary.ManagementPosition = 0.40;
            else if (position == "IT Manager (If there are more than 5 IT personnel in the IT department)")
                salaryOfUser.Salary.ManagementPosition = 0.60;
            else if (position == "Other")
                salaryOfUser.Salary.ManagementPosition = 0;
            else
                salaryOfUser.Salary.ManagementPosition = 0;
        }

        private void DocumanteDocumentedForeignLanguageKnowledge()
        {
            salaryOfUser.Salary.ForeignLanguage = 0;
            if (chckBoxEnglish.Checked)
                salaryOfUser.Salary.ForeignLanguage += 0.20;
            if (chckBoxEnglishSchool.Checked)
                salaryOfUser.Salary.ForeignLanguage += 0.20;
            if (cmbBoxOtherLanguageNum.SelectedItem != null)
            {
                double coefficient = Double.Parse(cmbBoxOtherLanguageNum.SelectedItem.ToString());
                salaryOfUser.Salary.ForeignLanguage += coefficient * (0.05);
            }
        }

        private void StatusFamily()
        {
            int counter = 0;
            salaryOfUser.Salary.StatusFamily = 0;
            if (chckBoxOver18.Checked)
            {
                salaryOfUser.Salary.StatusFamily += 0.40;
                counter++;
                if (counter == 2)
                    return;
            }
            if (chckBox7_17Child.Checked)
            {
                salaryOfUser.Salary.StatusFamily += 0.30;
                counter++;
                if (counter == 2)
                    return;
            }

            if (chckBox0_6Child.Checked)
            {
                salaryOfUser.Salary.StatusFamily += 0.20;
                counter++;
                if (counter == 2)
                    return;
            }
            if (chckBoxMarriedSpouseNoWork.Checked)
                salaryOfUser.Salary.StatusFamily += 0.20;
        }

        private void Degree(string relatedProf, string notRelatedProf)
        {
            if (relatedProf == "Master Degree")
                salaryOfUser.Salary.Degree = 0.10;
            else if (relatedProf == "Doctor\'s Degree")
                salaryOfUser.Salary.Degree = 0.30;
            else if (relatedProf == "Associate Professor")
                salaryOfUser.Salary.Degree = 0.35;
            else if (relatedProf == "None")
                salaryOfUser.Salary.Degree = 0;
            else
                salaryOfUser.Salary.Degree = 0;
            if (notRelatedProf == "Master Degree")
                salaryOfUser.Salary.Degree = 0.05;
            else if (notRelatedProf == "Doctor\'s Degree")
                salaryOfUser.Salary.Degree = 0.15;
            else if (notRelatedProf == "Associate Professor")
                salaryOfUser.Salary.Degree = 0.15;
            else if (notRelatedProf == "None")
                salaryOfUser.Salary.Degree = 0;
            else
                salaryOfUser.Salary.Degree = 0;
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            if (LoginForm.UserList[MainWindow.index].Admin_Control == "*" || LoginForm.UserList[MainWindow.index].Admin_Control == "+")
            {
                salaryOfUser = new UserSalary();
            }
            else
            {
                salaryOfUser = new PartTimeUserSalary();
            }
        }
    }
}