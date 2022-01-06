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
    public partial class Edit_Employees : Form
    {
        Controller controllerObject = new Controller();
        public Edit_Employees()
        {
            InitializeComponent();
            DataTable dt = controllerObject.SelectEmployeSSN();
            SuperSSNCombo.DataSource = dt;
            SuperSSNCombo.DisplayMember = "SSN";

            dt = controllerObject.SelectRoleID();
            RoleIDEmpCombo.DataSource = dt;
            RoleIDEmpCombo.DisplayMember = "RoleID";
            
            
            dt = controllerObject.SelectRoleID();
            EditRoleEMPCombo.DataSource = dt;
            EditRoleEMPCombo.DisplayMember = "RoleID";
            
            dt = controllerObject.SelectSSNForEditEmp();
            EditEmpCombo.DataSource = dt;
            EditEmpCombo.DisplayMember = "SSN";
        }

        private void SignupEmpBtn_Click(object sender, EventArgs e)
        {

            bool ok = (FNameEmpTxt.Text.Length > 0) && (MinitEmpTxt.Text.Length > 0) && (MinitEmpTxt.Text.Length > 0) && (LNameEmpTxt.Text.Length > 0) && (SSNEmpTxt.Text.Length > 0) && (RoleIDEmpCombo.Text.Length > 0) && (GenderEmpCombo.Text.Length > 0) && (bdateEmpDate.Text.Length > 0) && (AddressEmpTxt.Text.Length > 0) && (MobileEMpTxt.Text.Length > 0) && (SuperSSNCombo.Text.Length > 0) && (SalaryEmpTxt.Text.Length > 0) && (UserNameEmpTxt.Text.Length > 0);

            if (ok)
            {
                string username = UserNameEmpTxt.Text;
                if (username[0] == 'E' && username[1] == 'M' && username[2] == 'P' && username[3] == '_')
                {

                    int check1 = controllerObject.InsertEmpAccount(UserNameEmpTxt.Text, PasswordEmpTxt.Text);
                    if (check1 != 1)
                    {
                        MessageBox.Show("Adding employee failed due to error in username or password!");
                        return;
                    }

                    int check2 = controllerObject.InsertEmployee(FNameEmpTxt.Text, MinitEmpTxt.Text, LNameEmpTxt.Text, SSNEmpTxt.Text, RoleIDEmpCombo.Text, GenderEmpCombo.Text, bdateEmpDate.Text, AddressEmpTxt.Text, MobileEMpTxt.Text, SuperSSNCombo.Text, SalaryEmpTxt.Text, UserNameEmpTxt.Text);
                    if (check2 == 1)
                    {
                        MessageBox.Show("Employee added successfully!");
                    }
                    else
                        MessageBox.Show("Adding employee failed due to error in the employee info!");
                }
                else
                {
                    MessageBox.Show("Error! The username should start with 'EMP_' ");
                }
            }
            else
                MessageBox.Show("Error! All data should be filled.");
        }

        private void SalaryEmpTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsDigit(cr) && cr != 8 && cr != 46)
            { 
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void SSNEmpTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsDigit(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void MobileEMpTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsDigit(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void FNameEmpTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void MinitEmpTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void LNameEmpTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Error! wrong input.");
            }
        }

        private void FireEMPBTN_Click(object sender, EventArgs e)
        {
            bool ok = (EditEmpCombo.Text.Length) > 0;
            try
            {

                if (ok)
                {
                    DataTable dt = controllerObject.SelectUserNameFromSSN(EditEmpCombo.Text);

                    controllerObject.DeleteEmployee(EditEmpCombo.Text);

                    controllerObject.DeleteEmployeeLoging(dt.Rows[0][0].ToString());
                    MessageBox.Show("Employee FIRED!!!");

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

        private void EditSalaryBTN_Click(object sender, EventArgs e)
        {
            bool ok = (EditEmpCombo.Text.Length) > 0;
            try
            {

                if (ok)
                {
                    controllerObject.UpdateEMPSalary(EditEmpCombo.Text , EditSalaryTXT.Text);
                    MessageBox.Show("Employee salary Updated!!!");

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

        private void EditRoleBTN_Click(object sender, EventArgs e)
        {
            bool ok = (EditEmpCombo.Text.Length) > 0;
            try
            {

                if (ok)
                {
                    controllerObject.UpdateEMPRole(EditEmpCombo.Text, EditRoleEMPCombo.Text);
                    MessageBox.Show("Employee role Updated!!!");

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
    }
}
