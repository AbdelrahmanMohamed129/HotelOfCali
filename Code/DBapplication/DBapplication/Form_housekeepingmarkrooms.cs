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
	public partial class Form_housekeepingmarkrooms : Form
	{
		Controller controllerObj = new Controller();
		string hou_username;
		public Form_housekeepingmarkrooms(string user)
		{
			InitializeComponent();
			hou_username = user;
		}

		private void comboBox1_DropDown(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.SelectRoomsRequestClean(hou_username);
			comboBox1.DataSource = dt;
			comboBox1.DisplayMember = "RoomNO";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				int result = controllerObj.UpdateRoomCleanStatus(comboBox1.Text);
				MessageBox.Show("Room Cleaned. Thank you!");

			}
			else
			{
				MessageBox.Show("Please Check the confirmation button");
			}
		}
	}
}
