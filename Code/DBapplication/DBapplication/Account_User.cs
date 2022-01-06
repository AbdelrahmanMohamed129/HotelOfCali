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
    public partial class Form_useraccount : Form
    {
        String userName;
        String password;
        
        Controller controllerObj = new Controller();
        public Form_useraccount(string User_Name, string pass)
        {
            InitializeComponent();
            userName = User_Name;
            password = pass; 
            DataTable dt = controllerObj.SelectRoomType();
            comboBox_roomType.DataSource = dt;
            comboBox_roomType.DisplayMember = "RoomType";
             
            DataTable dt2 = controllerObj.SelectRoomView();
            comboBox_RoomView.DataSource = dt2;
            comboBox_RoomView.DisplayMember = "RoomView";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_roomType.Text.Length == 0 || comboBox_RoomView.Text.Length == 0 )
            {
                MessageBox.Show("Enter all of the information please!");
                return;
            }
            if (viewRoom_startdate.Value > viewRoom_enddate.Value || viewRoom_startdate.Value < DateTime.Today)
            {
                MessageBox.Show("Invalid dates");
                return;
            }

            if (txt_Price.Text.Length == 0)
            {
                DataTable dt = controllerObj.SelectAvailableRoomNumber(comboBox_roomType.Text, comboBox_RoomView.Text, viewRoom_startdate.Text, viewRoom_enddate.Text);
                dataGridView1.DataSource = dt;
                //int length = dataGridView1.Rows.Count;
                //for (int i = 0; i < length; i++)
                //{
                //    // MessageBox.Show(dt.Rows[i][0].ToString());
                //    DataGridViewRow row = (DataGridViewRow)dt.Rows[0].Clone();
                //    row.Cells[0].Value = "XYZ";
                //    row.Cells[1].Value = 50.2;
                //    yourDataGridView.Rows.Add(row);

                //    DataTable dt3 = controllerObj.SelectRoomPrice(dt.Rows[0][0].ToString());
                //    dataGridView1.Rows.= dt3.Rows[0][0].ToString();
                //}
                RoomNo_txt.Items.Clear();
                try
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string RoomNo = dt.Rows[i][0].ToString();
                        RoomNo_txt.Items.Add(RoomNo);
                    }
                }
                catch { }

                dataGridView1.Refresh();
                return;
            }
            DataTable dt2 = controllerObj.SelectAvailableRoomNumberPrice(comboBox_roomType.Text, comboBox_RoomView.Text, viewRoom_startdate.Text, viewRoom_enddate.Text, txt_Price.Text);
            RoomNo_txt.Items.Clear();

            // int check = controllerObject.ExistRoomToReserve(CheckRoomTypeCombo.Text, CheckRoomViewCombo.Text, CheckStartDate.Text, CheckEndDate.Text);

            // DataTable dt = controllerObject.SelectAvailableRoomNumber(CheckRoomTypeCombo.Text, CheckRoomViewCombo.Text, CheckStartDate.Text, CheckEndDate.Text);
            try
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    string RoomNo = dt2.Rows[i][0].ToString();
                    RoomNo_txt.Items.Add(RoomNo);
                }
            }

            catch
            {

            }
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
            return;
        }
           

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_useraccount_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                int yy1 = viewRoom_startdate.Value.Year, mm1 = viewRoom_startdate.Value.Month;

                if (mm1 <= 2)
                {
                    yy1 = yy1 - 1;
                    mm1 = mm1 + 13;
                }

                int NoDays1 = (146097 * yy1) / 400 + (153 * mm1 + 8) / 5 + viewRoom_startdate.Value.Day;

                int yy2 = viewRoom_enddate.Value.Year, mm2 = viewRoom_enddate.Value.Month;

                if (mm2 <= 2)
                {
                    yy2 = yy2 - 1;
                    mm2 = mm2 + 13;
                }

                int NoDays2 = (146097 * yy2) / 400 + (153 * mm2 + 8) / 5 + viewRoom_enddate.Value.Day;

                int difference = NoDays2 - NoDays1;

                DataTable dt = controllerObj.SelectUserSSN(userName, password);
                string ssn = dt.Rows[0][0].ToString();


                int check = controllerObj.InsertRerservation(viewRoom_startdate.Text, viewRoom_enddate.Text, ssn , RoomNo_txt.Text, difference);
                MessageBox.Show("Room reserved");
            }
            catch
            {
                MessageBox.Show("Room reservation failed");
            }
        }

        private void showReser_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectUserSSN(userName, password);
            string ssn = dt.Rows[0][0].ToString();
        

            DataTable data = controllerObj.SelectResDetails(ssn);
            dataGridView2.DataSource = data;
            dataGridView2.Refresh();



        }

        private void SubmitCleaningReq_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controllerObj.SelectUserSSN(userName, password);
                string ssn = dt.Rows[0][0].ToString();


                DataTable data = controllerObj.SelectResDetails(ssn);
                string RoomNo = data.Rows[0][0].ToString();
                controllerObj.UpdateRoomStatus(RoomNo);
            }
            catch
            {
                MessageBox.Show("No reservaation!");
            }

        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsDigit(cr) && cr != 8 && cr != 46) { e.Handled = true; MessageBox.Show("Numbers only please!"); }
        }
    }

        
    
}
