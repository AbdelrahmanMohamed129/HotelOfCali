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
    public partial class Form_RecepResEvent : Form
    {
        Controller controllerObj = new Controller();
        public Form_RecepResEvent()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllEventsNumbers();
            EventNOcombo.DataSource = dt;
            EventNOcombo.DisplayMember = "EventNO";

            dt = controllerObj.SelectUSSNForEvent();
            USSNcombo.DataSource = dt;
            USSNcombo.DisplayMember = "SSN";
        }

        private void AddEventBTN_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controllerObj.SelectUserNameFromSSNForUser(USSNcombo.Text);
                DataTable dt1 = controllerObj.SelectPassword(dt.Rows[0][0].ToString());

                string result1 = controllerObj.CheckUserToReserveEvent(dt.Rows[0][0].ToString(), EventNOcombo.Text).Rows[0][0].ToString();

                if (result1 == "1")
                {
                    int result2 = controllerObj.InsertAttendEvent(dt.Rows[0][0].ToString(), dt1.Rows[0][0].ToString(), EventNOcombo.Text);
                    int result3 = controllerObj.UpdateEventCostInBill(dt.Rows[0][0].ToString(), EventNOcombo.Text);
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
    }
}
