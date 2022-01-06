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
    public partial class Edit_Rooms : Form
    {
        Controller controllerObject = new Controller();
        public Edit_Rooms()
        {
            InitializeComponent();
            DataTable dt = controllerObject.SelectRoomTypeID();
            RoomTypeCombo.DataSource = dt;
            RoomTypeCombo.DisplayMember = "RoomTypeID";

            dt = controllerObject.SelecthouskeepingSSN();
            HouKeepingESSNcombo.DataSource = dt;
            HouKeepingESSNcombo.DisplayMember = "SSN";

            dt = controllerObject.SelectRoomNO();
            RoomNoDeleteCombo.DataSource = dt;
            RoomNoDeleteCombo.DisplayMember = "RoomNO";
        }

        private void InsertRoomBtn_Click(object sender, EventArgs e)
        {
            int check = controllerObject.InsertRoom(RoomTypeCombo.Text, HouKeepingESSNcombo.Text);
            if (check == 1)
            {
                MessageBox.Show("Room inserted successfully");
            }
            else MessageBox.Show("Error happened while inserting a room");
        }

        private void Edit_Rooms_Load(object sender, EventArgs e)
        {
            InsertRoomBtn.Focus();
        }

        private void DeleteRoomBtn_Click(object sender, EventArgs e)
        {
            int check = controllerObject.DeleteRoom(RoomNoDeleteCombo.Text);
            if (check == 1)
            {
                MessageBox.Show("Room deleted successfully");
            }
            else MessageBox.Show("Failed to delete room");
        }
    }
}
