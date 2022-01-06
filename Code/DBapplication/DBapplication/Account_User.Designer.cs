
namespace DBapplication
{
    partial class Form_useraccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewRoom_enddate = new System.Windows.Forms.DateTimePicker();
            this.viewRoom_startdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.reserveBtn = new System.Windows.Forms.Button();
            this.RoomNo_txt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.comboBox_RoomView = new System.Windows.Forms.ComboBox();
            this.comboBox_roomType = new System.Windows.Forms.ComboBox();
            this.roomAvailable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.showReser = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SubmitCleaningReq = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewRoom_enddate);
            this.groupBox1.Controls.Add(this.viewRoom_startdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.reserveBtn);
            this.groupBox1.Controls.Add(this.RoomNo_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.comboBox_RoomView);
            this.groupBox1.Controls.Add(this.comboBox_roomType);
            this.groupBox1.Controls.Add(this.roomAvailable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(991, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Rooms";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // viewRoom_enddate
            // 
            this.viewRoom_enddate.CustomFormat = "yyyy-MM-dd";
            this.viewRoom_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.viewRoom_enddate.Location = new System.Drawing.Point(352, 127);
            this.viewRoom_enddate.Name = "viewRoom_enddate";
            this.viewRoom_enddate.Size = new System.Drawing.Size(109, 22);
            this.viewRoom_enddate.TabIndex = 14;
            // 
            // viewRoom_startdate
            // 
            this.viewRoom_startdate.CustomFormat = "yyyy-MM-dd";
            this.viewRoom_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.viewRoom_startdate.Location = new System.Drawing.Point(113, 122);
            this.viewRoom_startdate.Name = "viewRoom_startdate";
            this.viewRoom_startdate.Size = new System.Drawing.Size(109, 22);
            this.viewRoom_startdate.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "End date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Start date";
            // 
            // reserveBtn
            // 
            this.reserveBtn.Location = new System.Drawing.Point(797, 195);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Size = new System.Drawing.Size(117, 29);
            this.reserveBtn.TabIndex = 4;
            this.reserveBtn.Text = "Reserve";
            this.reserveBtn.UseVisualStyleBackColor = true;
            this.reserveBtn.Click += new System.EventHandler(this.reserveBtn_Click);
            // 
            // RoomNo_txt
            // 
            this.RoomNo_txt.FormattingEnabled = true;
            this.RoomNo_txt.Location = new System.Drawing.Point(113, 181);
            this.RoomNo_txt.Name = "RoomNo_txt";
            this.RoomNo_txt.Size = new System.Drawing.Size(132, 24);
            this.RoomNo_txt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = " Available  Rooms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Room no";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(562, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(352, 88);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(562, 33);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(159, 22);
            this.txt_Price.TabIndex = 6;
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            // 
            // comboBox_RoomView
            // 
            this.comboBox_RoomView.FormattingEnabled = true;
            this.comboBox_RoomView.Location = new System.Drawing.Point(113, 75);
            this.comboBox_RoomView.Name = "comboBox_RoomView";
            this.comboBox_RoomView.Size = new System.Drawing.Size(196, 24);
            this.comboBox_RoomView.TabIndex = 5;
            // 
            // comboBox_roomType
            // 
            this.comboBox_roomType.FormattingEnabled = true;
            this.comboBox_roomType.Location = new System.Drawing.Point(113, 31);
            this.comboBox_roomType.Name = "comboBox_roomType";
            this.comboBox_roomType.Size = new System.Drawing.Size(196, 24);
            this.comboBox_roomType.TabIndex = 1;
            // 
            // roomAvailable
            // 
            this.roomAvailable.Location = new System.Drawing.Point(797, 18);
            this.roomAvailable.Name = "roomAvailable";
            this.roomAvailable.Size = new System.Drawing.Size(117, 29);
            this.roomAvailable.TabIndex = 3;
            this.roomAvailable.Text = "Available?";
            this.roomAvailable.UseVisualStyleBackColor = true;
            this.roomAvailable.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maximum Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room view";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.showReser);
            this.groupBox2.Location = new System.Drawing.Point(17, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "show my reservation";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(273, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(374, 87);
            this.dataGridView2.TabIndex = 15;
            // 
            // showReser
            // 
            this.showReser.Location = new System.Drawing.Point(36, 25);
            this.showReser.Name = "showReser";
            this.showReser.Size = new System.Drawing.Size(118, 38);
            this.showReser.TabIndex = 0;
            this.showReser.Text = "Show";
            this.showReser.UseVisualStyleBackColor = true;
            this.showReser.Click += new System.EventHandler(this.showReser_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SubmitCleaningReq);
            this.groupBox3.Location = new System.Drawing.Point(19, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 74);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Request room service";
            // 
            // SubmitCleaningReq
            // 
            this.SubmitCleaningReq.Location = new System.Drawing.Point(60, 30);
            this.SubmitCleaningReq.Name = "SubmitCleaningReq";
            this.SubmitCleaningReq.Size = new System.Drawing.Size(106, 27);
            this.SubmitCleaningReq.TabIndex = 4;
            this.SubmitCleaningReq.Text = "Request";
            this.SubmitCleaningReq.UseVisualStyleBackColor = true;
            this.SubmitCleaningReq.Click += new System.EventHandler(this.SubmitCleaningReq_Click);
            // 
            // Form_useraccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_useraccount";
            this.Text = "User_Account";
            this.Load += new System.EventHandler(this.Form_useraccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.ComboBox comboBox_RoomView;
        private System.Windows.Forms.ComboBox comboBox_roomType;
        private System.Windows.Forms.Button reserveBtn;
        private System.Windows.Forms.Button roomAvailable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RoomNo_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker viewRoom_enddate;
        private System.Windows.Forms.DateTimePicker viewRoom_startdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button showReser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SubmitCleaningReq;
    }
}