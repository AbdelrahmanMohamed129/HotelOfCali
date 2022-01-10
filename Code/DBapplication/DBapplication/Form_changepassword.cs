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
	public partial class Form_changepassword : Form
	{
		Controller controllerObject = new Controller();
		string username;
		public Form_changepassword(string user)
		{
			InitializeComponent();
			username = user;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txt_confirmpassword.Text == txt_newpassword.Text)
			{
				if (txt_newpassword.Text != "")
				{
					int result = controllerObject.UpdatePassowrd(username, txt_newpassword.Text);
					if (result == 0)
					{
						MessageBox.Show("ERROR, Please try again");
						return;
					}
					MessageBox.Show("Password updated succefully");
				}
				else
				{
					MessageBox.Show("Password cannot be blank");
				}
			}
			else
			{
				MessageBox.Show("Please check your password again");
			}
		}
	}
}
