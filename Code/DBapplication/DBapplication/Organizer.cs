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
    public partial class Organizer : Form
    {
        Controller controllerObj = new Controller();
        string org_username;
        public Organizer(string user)
        {
            InitializeComponent();
            DataTable temp = controllerObj.SelectEmployeeName(user);
            org_username = user;
            label_username.Text = temp.Rows[0][0].ToString();
        }

		private void btn_editevents_Click(object sender, EventArgs e)
		{
            Form_editevents Form_account = new Form_editevents();
            Form_account.Show();
        }

		private void btn_findevent_Click(object sender, EventArgs e)
		{
            Form_findevents Form_account = new Form_findevents();
            Form_account.Show();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            form myform = new form();
            myform.Show();
            this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
            Form_changepassword newform = new Form_changepassword(org_username);
            newform.Show();
        }
	}
}
