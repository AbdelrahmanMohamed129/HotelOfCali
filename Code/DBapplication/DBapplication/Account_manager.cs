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
	public partial class Form_manager : Form
	{
		public Form_manager()
		{
			InitializeComponent();
		}

        private void AddRemoveRoomsBtn_Click(object sender, EventArgs e)
        {
			Edit_Rooms ER = new Edit_Rooms();
			ER.Show();
        }

        private void EditEmployeesBtn_Click(object sender, EventArgs e)
        {
			Edit_Employees EDEmp = new Edit_Employees();
			EDEmp.Show();
        }

        private void EditDependentsBtn_Click(object sender, EventArgs e)
        {
            Edit_Dependents EDep = new Edit_Dependents();
            EDep.Show();
        }
    }
}
