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
        }

        private void Edit_Employees_Load(object sender, EventArgs e)
        {

        }

        private void SignupEmpBtn_Click(object sender, EventArgs e)
        {
            controllerObject.InsertEmpAccount(UserNameEmpTxt.Text,PasswordEmpTxt.Text);

            controllerObject.InsertEmployee(FNameEmpTxt.Text, MinitEmpTxt.Text, LNameEmpTxt.Text, SSNEmpTxt.Text, RoleIDEmpCombo.Text, GenderEmpCombo.Text, bdateEmpDate.Text, AddressEmpTxt.Text, MobileEMpTxt.Text, SuperSSNCombo.Text, SalaryEmpTxt.Text, UserNameEmpTxt.Text);
        }
    }
}
