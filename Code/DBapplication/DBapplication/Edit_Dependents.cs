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
    public partial class Edit_Dependents : Form
    {
        Controller controllerObject = new Controller();
        public Edit_Dependents()
        {
            InitializeComponent();
        }

        private void Edit_Dependents_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObject.SelectEmployeSSN();
            ESSNDEPCombo.DataSource = dt;
            ESSNDEPCombo.DisplayMember = "SSN";

            dt = controllerObject.SelectEmployeDEPSSN();
            ESSNDEPRemoveCombo.DataSource = dt;
            ESSNDEPRemoveCombo.DisplayMember = "ESSN";

            dt = controllerObject.SelectDependentFName();
            FNameRemoveDEPcombo.DataSource = dt;
            FNameRemoveDEPcombo.DisplayMember = "FName";


        }

        private void AddDependentsBtn_Click(object sender, EventArgs e)
        {
            int check = controllerObject.InsertDependents(FNameDEPTxt.Text, LNameDEPTxt.Text, ESSNDEPCombo.Text, GenderRB.Text, RelationDEPTxt.Text);
            if (check == 1)
            {
                MessageBox.Show("Dependent inserted successfully");
            }
            else MessageBox.Show("Dependent insertement failed");
        }

        private void RemoveDepBtn_Click(object sender, EventArgs e)
        {

            int check = controllerObject.DeleteDependents(FNameRemoveDEPcombo.Text,ESSNDEPRemoveCombo.Text);
            if (check == 1)
            {
                MessageBox.Show("Dependent deleted successfully");
            }
            else MessageBox.Show("This Dependent is not related to this Employee");
        }
    }
}
