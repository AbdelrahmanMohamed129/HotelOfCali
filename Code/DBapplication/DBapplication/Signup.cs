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
	public partial class Show_Form : Form
	{
		Controller controllerObject = new Controller();
		public Show_Form()
		{
			InitializeComponent();
		}

		private void btn_signup_Click(object sender, EventArgs e)
		{
			string gender = "M";
			if (radiobtn_female.Checked)
			{
				gender = "F";
			}

			if (text_fname.Text == "" || text_minit.Text == "" || text_lname.Text == "" || text_username.Text == "" || text_password.Text == "" || text_ssn.Text == "" || text_mobile.Text == "" || text_address.Text == "")
			{
				MessageBox.Show("Please fill all the information required");
				return;
			}

			try
			{
				int result = controllerObject.InsertAccount(text_fname.Text, text_minit.Text, text_lname.Text, text_username.Text, text_password.Text, gender, bdate.Text.ToString(), text_ssn.Text, text_mobile.Text, text_address.Text);

				if (result == 0)
				{
					MessageBox.Show("Failed to create account. Please check your information");
				}
				else
				{
					MessageBox.Show("Account added successfully");
				}
			}
			catch 
			{
				MessageBox.Show("Failed to create account. Please check your information");
			}
	
		}


		private void text_ssn_KeyPress(object sender, KeyPressEventArgs e)
		{
			char cr = e.KeyChar;
			if (!char.IsDigit(cr) && cr != 8 && cr != 46)
			{
				e.Handled = true;
				MessageBox.Show("Incorrect input");
			}
		}

		private void text_mobile_KeyPress(object sender, KeyPressEventArgs e)
		{
			char cr = e.KeyChar;
			if (!char.IsDigit(cr) && cr != 8 && cr != 46)
			{
				e.Handled = true;
				MessageBox.Show("Incorrect input");
			}
		}

		private void text_minit_KeyPress(object sender, KeyPressEventArgs e)
		{
			char cr = e.KeyChar;
			if (!char.IsLetter(cr) && cr != 8 && cr != 46)
			{
				e.Handled = true;
				MessageBox.Show("Incorrect input");
			}
		}

		private void text_lname_KeyPress(object sender, KeyPressEventArgs e)
		{
			char cr = e.KeyChar;
			if (!char.IsLetter(cr) && cr != 8 && cr != 46)
			{
				e.Handled = true;
				MessageBox.Show("Incorrect input");
			}
		}

		private void text_fname_KeyPress(object sender, KeyPressEventArgs e)
		{
			char cr = e.KeyChar;
			if (!char.IsLetter(cr) && cr != 8 && cr != 46)
			{
				e.Handled = true;
				MessageBox.Show("Incorrect input");
			}

		}
	}
}
