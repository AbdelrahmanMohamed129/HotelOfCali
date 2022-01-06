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
	public partial class Form_checkrooms : Form
	{
		Controller controllerObj = new Controller();
		public Form_checkrooms(string user)
		{
			InitializeComponent();
			DataTable dt = controllerObj.SelectRoomsToBeCleaned(user);
			dataGridView1.DataSource = dt;
			dataGridView1.Refresh();
		}
	}
}
