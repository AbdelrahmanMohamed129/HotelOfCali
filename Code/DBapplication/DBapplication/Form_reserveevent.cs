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
	public partial class Form_reserveevent : Form
	{

		Controller controllerObj = new Controller();
		string username;
		string password;
		public Form_reserveevent(string user, string pass)
		{
			InitializeComponent();
			username = user;
			password = pass;
		}

		private void comboBox1_DropDown(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.SelectAllEventsNumbers();
			comboBox1.DataSource = dt;
			comboBox1.DisplayMember = "EventNO";
		}

		private void btn_submit_Click(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				try
				{
					string result1 = controllerObj.CheckUserToReserveEvent(username, comboBox1.Text).Rows[0][0].ToString();

					if (result1 == "1")
					{
						int result2 = controllerObj.InsertAttendEvent(username, password, comboBox1.Text);
						int result3 = controllerObj.UpdateEventCostInBill(username, comboBox1.Text);
						MessageBox.Show("Event Reserved Succesfully");
					}
					else
					{
						MessageBox.Show("Error. Cannot reserve event, please contact customer support for further help");
					}			

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error. Cannot reserve event, please contact customer support for further help");
				}
			}
			else 
			{
				MessageBox.Show("Please check the terms and conditions");
			}

		}
	}
}
