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
    public partial class AddDepend : Form
    {
        string userName;
        string Password;
        Controller controllerObj = new Controller();
        public AddDepend(string User_Name, string Pass)
        {
            InitializeComponent();
            userName = User_Name;
            Password = Pass;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(text_FName.Text.Length == 0 || text_MName.Text.Length == 0 ||  text_LName.Text.Length == 0 || (!radioButton1.Checked && !radioButton2.Checked) || comboBox2.Text.Length == 0)
            {
                MessageBox.Show("Pls complete your info!");
                return;
            }
            string gender = "M";
            if (radioButton2.Checked)
                gender = "F";
            string ssn = controllerObj.SelectUserSSN(userName, Password).Rows[0][0].ToString();
            int result = controllerObj.InsertCompanion(text_FName.Text, text_MName.Text, text_LName.Text, ssn, gender, dateTimePicker1.Text, comboBox2.Text);
            if (result == 1)
                MessageBox.Show("Row added");
            else
                MessageBox.Show("Insertion failed!");

        }

        private void text_FName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46) { e.Handled = true; MessageBox.Show("Enter Letters only!"); }
        }

        private void text_MName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46) { e.Handled = true; MessageBox.Show("Enter Letters only!"); }
        }

        private void text_LName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46) { e.Handled = true; MessageBox.Show("Enter Letters only!"); }
        }
    }
}
