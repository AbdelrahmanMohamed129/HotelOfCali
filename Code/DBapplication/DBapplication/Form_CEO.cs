using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Form_CEO : Form
    {
        Controller controllerObject = new Controller();
        string User_Name;
        public Form_CEO(string UN)
        {
            InitializeComponent();
            User_Name = UN;

            DataTable dt = controllerObject.SelectSSNForEditMGR();
            DelMGRCombo.DataSource = dt;
            DelMGRCombo.DisplayMember = "SSN";
        }

        private void MgrView_Click(object sender, EventArgs e)
        {
            Form_manager MgrForm = new Form_manager(User_Name);
            MgrForm.Show();
        }

        private void RecepView_Click(object sender, EventArgs e)
        {
            Form_Receptionist RecForm = new Form_Receptionist(User_Name);
            RecForm.Show();
        }

        private void OrgView_Click(object sender, EventArgs e)
        {
            Organizer OrgForm = new Organizer(User_Name);
            OrgForm.Show();
        }

        private void HouView_Click(object sender, EventArgs e)
        {
            Form_HouseKeeping HouForm = new Form_HouseKeeping(User_Name);
            HouForm.Show();
        }

        private void SSNMGR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsDigit(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void MobileMGR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsDigit(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void SalaryMGR_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalaryMGR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsDigit(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void FNameMGR_TextChanged(object sender, EventArgs e)
        {

        }

        private void FNameMGR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void MinitMGR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void LNameMGR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void AddMGR_Click(object sender, EventArgs e)
        {
            bool ok = (AddressMGR.Text.Length > 0) && (BdateMGR.Text.Length > 0) && (FNameMGR.Text.Length > 0) && (GenderMGR.Text.Length > 0) && (LNameMGR.Text.Length > 0) && (MinitMGR.Text.Length > 0) && (MobileMGR.Text.Length > 0) && (PasswordMGR.Text.Length > 0) && (SalaryMGR.Text.Length > 0) && (SSNMGR.Text.Length > 0) && (UsernameMGR.Text.Length > 0);

            if (ok)
            {

                int existencecheck = controllerObject.CheckIfEmpExists(SSNMGR.Text);
                int existencecheck1 = controllerObject.CheckLoginPrimary(UsernameMGR.Text);
                if (existencecheck != 0 && existencecheck1 != 0)
                {
                    MessageBox.Show("Failed to create account. Account already exists");
                    return;
                }

                string username = UsernameMGR.Text;
                if (username[0] == 'E' && username[1] == 'M' && username[2] == 'P' && username[3] == '_')
                {

                    int check1 = controllerObject.InsertEmpAccount(UsernameMGR.Text, PasswordMGR.Text);
                    if (check1 != 1)
                    {
                        MessageBox.Show("Adding manager failed due to error in username or password!");
                        return;
                    }

                    int check2 = controllerObject.InsertEmployee(FNameMGR.Text, MinitMGR.Text, LNameMGR.Text, SSNMGR.Text, "MGR", GenderMGR.Text, BdateMGR.Text, AddressMGR.Text, MobileMGR.Text, "12345", SalaryMGR.Text, UsernameMGR.Text);
                    if (check2 == 1)
                    {
                        MessageBox.Show("Manager added successfully!");
                    }
                    else
                        MessageBox.Show("Adding manager failed due to error in the employee info!");
                }
                else
                {
                    MessageBox.Show("Error! The username should start with 'EMP_' ");
                }
            }
            else
                MessageBox.Show("Error! All data should be filled.");
        }

        private void FireMGR_Click(object sender, EventArgs e)
        {
            bool ok = (DelMGRCombo.Text.Length) > 0;
            try
            {

                if (ok)
                {
                    DataTable dt = controllerObject.SelectUserNameFromSSN(DelMGRCombo.Text);

                    controllerObject.DeleteEmployee(DelMGRCombo.Text);

                    controllerObject.DeleteEmployeeLoging(dt.Rows[0][0].ToString());
                    MessageBox.Show("Manager FIRED!!!");

                }
                else
                {
                    MessageBox.Show("Error! Please choose SSN of an employee");
                }
            }
            catch
            {
                MessageBox.Show("!!An error occured try again!!");
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
            form myform = new form();
            myform.Show();
            this.Hide();
        }

		private void button2_Click(object sender, EventArgs e)
		{
            Form_changepassword newform = new Form_changepassword(User_Name);
            newform.Show();
        }

        private void ADDCEO_Click(object sender, EventArgs e)
        {
            bool ok = (CEOAddresstxt.Text.Length > 0) && (CEOBirthdate.Text.Length > 0) && (CEOFName.Text.Length > 0) && (CEOgenderCombo.Text.Length > 0) && (CEOLNametxt.Text.Length > 0) && (CEOMiddleName.Text.Length > 0) && (CEOMobile.Text.Length > 0) && (CEOPassWordtxt.Text.Length > 0) && (CEOSalarytxt.Text.Length > 0) && (CEOSSNcombo.Text.Length > 0) && (CEOUserNametxt.Text.Length > 0);

            if (ok)
            {

                int existencecheck = controllerObject.CheckIfEmpExists(CEOSSNcombo.Text);
                int existencecheck1 = controllerObject.CheckLoginPrimary(CEOUserNametxt.Text);
                if (existencecheck != 0 && existencecheck1 != 0)
                {
                    MessageBox.Show("Failed to create account. Account already exists");
                    return;
                }

                string username = CEOUserNametxt.Text;
                if (username[0] == 'E' && username[1] == 'M' && username[2] == 'P' && username[3] == '_')
                {

                    int check1 = controllerObject.InsertEmpAccount(CEOUserNametxt.Text, CEOPassWordtxt.Text);
                    if (check1 != 1)
                    {
                        MessageBox.Show("Adding CEO failed due to error in username or password!");
                        return;
                    }

                    int check2 = controllerObject.InsertEmployee(CEOFName.Text, CEOMiddleName.Text, CEOLNametxt.Text, CEOSSNcombo.Text, "MGR", CEOgenderCombo.Text, CEOBirthdate.Text, CEOAddresstxt.Text, CEOMobile.Text, "NULL", CEOSalarytxt.Text, CEOUserNametxt.Text);
                    if (check2 == 1)
                    {
                        MessageBox.Show("CEO added successfully!");
                    }
                    else
                        MessageBox.Show("Adding CEO failed due to error in the employee info!");
                }
                else
                {
                    MessageBox.Show("Error! The username should start with 'EMP_' ");
                }
            }
            else
                MessageBox.Show("Error! All data should be filled.");
        }

        private void CEOSSNcombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsDigit(cr) && cr != 8 && cr != 46) 
            { 
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void CEOMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsDigit(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void CEOSalarytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsDigit(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void CEOFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void CEOMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void CEOLNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }
    }
}
