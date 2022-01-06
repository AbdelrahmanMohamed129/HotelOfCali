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
    public partial class Form_HouseKeeping : Form
    {
        Controller controllerObj = new Controller();
        string hou_username;
        public Form_HouseKeeping(string user)
        {
            InitializeComponent();
            DataTable temp = controllerObj.SelectEmployeeName(user);
            hou_username = user;
            label_username.Text = temp.Rows[0][0].ToString();
        }

		private void btn_checkrooms_Click(object sender, EventArgs e)
		{
            Form_checkrooms Form_account = new Form_checkrooms(hou_username);
            Form_account.Show();
        }

		private void btn_markrooms_Click(object sender, EventArgs e)
		{
            Form_housekeepingmarkrooms Form_account = new Form_housekeepingmarkrooms(hou_username);
            Form_account.Show();
        }
	}
}
