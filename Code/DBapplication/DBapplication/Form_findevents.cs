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
	public partial class Form_findevents : Form
	{
		Controller controllerObj = new Controller();
		public Form_findevents()
		{
			InitializeComponent();
		}

		private void btn_findevent_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			dt = controllerObj.SelectEvent(combo_findevent.Text);
			dataGridView1.DataSource = dt;
			dataGridView1.Refresh();
		}

		private void combo_findevent_DropDown(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.SelectAllEventsNumbers();
			combo_findevent.DataSource = dt;
			combo_findevent.DisplayMember = "EventNO";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			dt = controllerObj.SelectAllEvents();
			dataGridView1.DataSource = dt;
			dataGridView1.Refresh();
		}
	}
}
