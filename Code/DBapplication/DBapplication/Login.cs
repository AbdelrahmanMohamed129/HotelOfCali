using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class form : System.Windows.Forms.Form
    {
        Controller controllerObj;
        public form()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            /*int result = controllerObj.Insert();
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new Supplier failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }*/
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
           /* int result = controllerObj.Delete();
            if (result == 0)
            {
                MessageBox.Show("No rows are deleted");
            }
            else
            {
                MessageBox.Show("The row is deleted successfully!");
            }*/
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int result = controllerObj.Update();
            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            controllerObj.TerminateConnection();
            this.Close();
        }

        
        private void selectAllButton_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Select();
            //suppliersDataGrid.DataSource = dt;
            //suppliersDataGrid.Refresh();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
           // countTextBox.Text = controllerObj.Count().ToString();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            Show_Form Form_signup = new Show_Form();
            Form_signup.Show();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {

            string username = text_username.Text;
            try
            {
                int result = controllerObj.ExistAccount(text_username.Text, text_password.Text);
                MessageBox.Show("Login successfully");

                if (username[0] == 'E' && username[1] == 'M' && username[2] == 'P')
                {
                    //manager form
                    //query to get role_id
                    DataTable role_id = controllerObj.SelectRoleid(text_username.Text);
    
                    if (role_id.Rows[0][0].ToString() == "MGR")
                    {
                        Form_manager Form_account = new Form_manager();
                        Form_account.Show();
                    }
                    else if (role_id.Rows[0][0].ToString() == "RecEMP")
                    {
                        Form_Receptionist form_account = new Form_Receptionist();
                        form_account.Show();
                    }
                    else if (role_id.Rows[0][0].ToString() == "HouEMP")
                    {
                        Form_HouseKeeping form_account = new Form_HouseKeeping(text_username.Text);
                        form_account.Show();
                    }
                    else if (role_id.Rows[0][0].ToString() == "OrgEMP")
                    {
                        Organizer form_account = new Organizer(username);
                        form_account.Show();
                    }
                    else if(role_id.Rows[0][0].ToString() == "CEO")
                    {
                        Form_CEO form_account = new Form_CEO();
                        form_account.Show();
                    }


                    this.Visible = false;
                }
                else 
                {
                    //user(guest) form
                    Form_useraccount Form_account = new Form_useraccount(text_username.Text, text_password.Text);
                    Form_account.Show();
                }


            }
            catch
            {
                MessageBox.Show("Failed to login. Please check your email or password");
            }
            
        }


		private void checkBox1_CheckStateChanged(object sender, EventArgs e)
		{
            if (checkBox1.Checked)
            {
                text_password.PasswordChar = '\0';
            }
            else
            { 
                text_password.PasswordChar = '●';
            }
        }




		/*                 *******************     Switch Form      ****************** 
                    
        private void switchButton_Click(object sender, EventArgs e)
        {
            Form1 curr = new Form1();
            curr.Show();
        }
        */

		/*   ****************************** Only characters can be inserted into textbox ***************
         * char cr = e.KeyChar;
         * if(!char.IsLetter(cr) && cr != 8 && cr !=46) {e.Handled = true;}
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         *
         */


		/*                *****************     Check Validations      ****************
                     
        private void insertButton_Click(object sender, EventArgs e)
        {
            int check;
            bool ok = int.TryParse(dno.Text, out check);
            
            ok = ok && (Combo.Text.length > 0);

            if(ok)
            {
                int age = Int16.Parse(age.Text);
                ok = ok && (age > 0);
            }

            if (ok == false) MessageBox.Show("The insertion of a new Department failed. DNumber should be integer.");
            else
            {
                int result = controllerObj.InsertDepartment(dname.Text, dno.Text,
                    mgrssn.Text, stdate2.Value);
                if (result == 0)
                {
                    MessageBox.Show("The insertion of a new Department failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }
            }
        }
        */




		/*                *****************     ComboBox intialization      ****************
                         
        public Form2()
        {
            InitializeComponent();
            DataTable dt = controllerObject.SelectCustomerName();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.Items.Add("Female");
        }
        */
	}
}
