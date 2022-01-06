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
	public partial class Form_editevents : Form
	{
		Controller controllerObj = new Controller();
		public Form_editevents()
		{
			InitializeComponent();
		}

		private void btn_addevent_Click(object sender, EventArgs e)
		{
			try
			{
				if (text_addeventcost.Text == "")
				{
					MessageBox.Show("Please Add Event Cost");
					return;
				}


				if (date_eventstartdate.Value > date_eventenddate.Value || date_eventstartdate.Value < DateTime.Today)
				{
					MessageBox.Show("Invalid dates");
					return;
				}

				int result = controllerObj.InsertEvent(text_addeventcost.Text, text_addeventdescription.Text, date_eventstartdate.Text.ToString(), date_eventenddate.Text.ToString());
				MessageBox.Show("Event Added Succesfully");

			}
			catch (Exception ex)
			{
				MessageBox.Show("Oops! something went wrong. Please Try Again");
			}
		}

		private void btn_removevent_Click(object sender, EventArgs e)
		{
			int result = controllerObj.DeleteEvent(combo_eventnum.Text);
			MessageBox.Show("Event Removed Succesfully");
		}

		private void text_addeventcost_KeyPress(object sender, KeyPressEventArgs e)
		{
			char cr = e.KeyChar;
			if (!char.IsDigit(cr) && cr != 8 && cr != 46)
			{
				e.Handled = true;
				MessageBox.Show("Incorrect input");
			}
		}

		private void comboBox1_DropDown(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.SelectAllEventsNumbers();
			combo_eventnum.DataSource = dt;
			combo_eventnum.DisplayMember = "EventNO";
		}
	}
}
