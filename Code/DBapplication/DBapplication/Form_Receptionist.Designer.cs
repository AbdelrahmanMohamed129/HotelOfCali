namespace DBapplication
{
    partial class Form_Receptionist
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
            this.label6 = new System.Windows.Forms.Label();
            this.CheckRoomNO = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckUSSN = new System.Windows.Forms.ComboBox();
            this.ReserveBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckEndDate = new System.Windows.Forms.DateTimePicker();
            this.CheckStartDate = new System.Windows.Forms.DateTimePicker();
            this.CheckRoomAvailableBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckRoomViewCombo = new System.Windows.Forms.ComboBox();
            this.CheckRoomTypeCombo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckBillGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.BillRoomNoCombo = new System.Windows.Forms.ComboBox();
            this.CheckBillBTN = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CheckOutBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CheckOutUSSNCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CheckOutRoomNOCombo = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CheckEventBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBillGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CheckRoomNO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CheckUSSN);
            this.groupBox1.Controls.Add(this.ReserveBTN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CheckEndDate);
            this.groupBox1.Controls.Add(this.CheckStartDate);
            this.groupBox1.Controls.Add(this.CheckRoomAvailableBTN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CheckRoomViewCombo);
            this.groupBox1.Controls.Add(this.CheckRoomTypeCombo);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check and book room";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Room Number";
            this.label6.VisibleChanged += new System.EventHandler(this.label6_VisibleChanged);
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CheckRoomNO
            // 
            this.CheckRoomNO.FormattingEnabled = true;
            this.CheckRoomNO.Location = new System.Drawing.Point(467, 70);
            this.CheckRoomNO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckRoomNO.Name = "CheckRoomNO";
            this.CheckRoomNO.Size = new System.Drawing.Size(99, 21);
            this.CheckRoomNO.TabIndex = 12;
            this.CheckRoomNO.SelectedIndexChanged += new System.EventHandler(this.CheckRoomNO_SelectedIndexChanged);
            this.CheckRoomNO.VisibleChanged += new System.EventHandler(this.label6_VisibleChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "User SSN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CheckUSSN
            // 
            this.CheckUSSN.FormattingEnabled = true;
            this.CheckUSSN.Location = new System.Drawing.Point(467, 26);
            this.CheckUSSN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckUSSN.Name = "CheckUSSN";
            this.CheckUSSN.Size = new System.Drawing.Size(99, 21);
            this.CheckUSSN.TabIndex = 10;
            this.CheckUSSN.SelectedIndexChanged += new System.EventHandler(this.CheckUSSN_SelectedIndexChanged);
            // 
            // ReserveBTN
            // 
            this.ReserveBTN.Location = new System.Drawing.Point(240, 124);
            this.ReserveBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReserveBTN.Name = "ReserveBTN";
            this.ReserveBTN.Size = new System.Drawing.Size(109, 38);
            this.ReserveBTN.TabIndex = 9;
            this.ReserveBTN.Text = "Reserve room";
            this.ReserveBTN.UseVisualStyleBackColor = true;
            this.ReserveBTN.Click += new System.EventHandler(this.ReserveBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Date";
            // 
            // CheckEndDate
            // 
            this.CheckEndDate.CustomFormat = "yyyy-MM-dd";
            this.CheckEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckEndDate.Location = new System.Drawing.Point(247, 71);
            this.CheckEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckEndDate.Name = "CheckEndDate";
            this.CheckEndDate.Size = new System.Drawing.Size(102, 20);
            this.CheckEndDate.TabIndex = 14;
            this.CheckEndDate.ValueChanged += new System.EventHandler(this.CheckEndDate_ValueChanged);
            // 
            // CheckStartDate
            // 
            this.CheckStartDate.CustomFormat = "yyyy-MM-dd";
            this.CheckStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckStartDate.Location = new System.Drawing.Point(69, 70);
            this.CheckStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckStartDate.Name = "CheckStartDate";
            this.CheckStartDate.Size = new System.Drawing.Size(109, 20);
            this.CheckStartDate.TabIndex = 5;
            // 
            // CheckRoomAvailableBTN
            // 
            this.CheckRoomAvailableBTN.Location = new System.Drawing.Point(89, 124);
            this.CheckRoomAvailableBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckRoomAvailableBTN.Name = "CheckRoomAvailableBTN";
            this.CheckRoomAvailableBTN.Size = new System.Drawing.Size(99, 38);
            this.CheckRoomAvailableBTN.TabIndex = 4;
            this.CheckRoomAvailableBTN.Text = "Check availablity";
            this.CheckRoomAvailableBTN.UseVisualStyleBackColor = true;
            this.CheckRoomAvailableBTN.Click += new System.EventHandler(this.CheckRoomAvailableBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room view";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room type";
            // 
            // CheckRoomViewCombo
            // 
            this.CheckRoomViewCombo.FormattingEnabled = true;
            this.CheckRoomViewCombo.Location = new System.Drawing.Point(247, 27);
            this.CheckRoomViewCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckRoomViewCombo.Name = "CheckRoomViewCombo";
            this.CheckRoomViewCombo.Size = new System.Drawing.Size(92, 21);
            this.CheckRoomViewCombo.TabIndex = 1;
            // 
            // CheckRoomTypeCombo
            // 
            this.CheckRoomTypeCombo.FormattingEnabled = true;
            this.CheckRoomTypeCombo.Location = new System.Drawing.Point(69, 26);
            this.CheckRoomTypeCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckRoomTypeCombo.Name = "CheckRoomTypeCombo";
            this.CheckRoomTypeCombo.Size = new System.Drawing.Size(109, 21);
            this.CheckRoomTypeCombo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckBillGrid);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BillRoomNoCombo);
            this.groupBox2.Controls.Add(this.CheckBillBTN);
            this.groupBox2.Location = new System.Drawing.Point(19, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(524, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check bill";
            // 
            // CheckBillGrid
            // 
            this.CheckBillGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CheckBillGrid.Location = new System.Drawing.Point(212, 15);
            this.CheckBillGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckBillGrid.Name = "CheckBillGrid";
            this.CheckBillGrid.Size = new System.Drawing.Size(297, 83);
            this.CheckBillGrid.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Room Number";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BillRoomNoCombo
            // 
            this.BillRoomNoCombo.FormattingEnabled = true;
            this.BillRoomNoCombo.Location = new System.Drawing.Point(95, 28);
            this.BillRoomNoCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BillRoomNoCombo.Name = "BillRoomNoCombo";
            this.BillRoomNoCombo.Size = new System.Drawing.Size(99, 21);
            this.BillRoomNoCombo.TabIndex = 15;
            this.BillRoomNoCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CheckBillBTN
            // 
            this.CheckBillBTN.Location = new System.Drawing.Point(49, 59);
            this.CheckBillBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckBillBTN.Name = "CheckBillBTN";
            this.CheckBillBTN.Size = new System.Drawing.Size(105, 45);
            this.CheckBillBTN.TabIndex = 14;
            this.CheckBillBTN.Text = "Check bill";
            this.CheckBillBTN.UseVisualStyleBackColor = true;
            this.CheckBillBTN.Click += new System.EventHandler(this.CheckBillBTN_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CheckOutBTN);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.CheckOutUSSNCombo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.CheckOutRoomNOCombo);
            this.groupBox3.Location = new System.Drawing.Point(19, 341);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(308, 91);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check out";
            // 
            // CheckOutBTN
            // 
            this.CheckOutBTN.Location = new System.Drawing.Point(212, 26);
            this.CheckOutBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckOutBTN.Name = "CheckOutBTN";
            this.CheckOutBTN.Size = new System.Drawing.Size(70, 46);
            this.CheckOutBTN.TabIndex = 3;
            this.CheckOutBTN.Text = "Check out";
            this.CheckOutBTN.UseVisualStyleBackColor = true;
            this.CheckOutBTN.Click += new System.EventHandler(this.CheckOutBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "User SSN";
            // 
            // CheckOutUSSNCombo
            // 
            this.CheckOutUSSNCombo.FormattingEnabled = true;
            this.CheckOutUSSNCombo.Location = new System.Drawing.Point(84, 51);
            this.CheckOutUSSNCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckOutUSSNCombo.Name = "CheckOutUSSNCombo";
            this.CheckOutUSSNCombo.Size = new System.Drawing.Size(99, 21);
            this.CheckOutUSSNCombo.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Room Number";
            // 
            // CheckOutRoomNOCombo
            // 
            this.CheckOutRoomNOCombo.FormattingEnabled = true;
            this.CheckOutRoomNOCombo.Location = new System.Drawing.Point(84, 23);
            this.CheckOutRoomNOCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckOutRoomNOCombo.Name = "CheckOutRoomNOCombo";
            this.CheckOutRoomNOCombo.Size = new System.Drawing.Size(99, 21);
            this.CheckOutRoomNOCombo.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CheckEventBTN);
            this.groupBox4.Location = new System.Drawing.Point(349, 342);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(194, 90);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Check event";
            // 
            // CheckEventBTN
            // 
            this.CheckEventBTN.Location = new System.Drawing.Point(51, 25);
            this.CheckEventBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckEventBTN.Name = "CheckEventBTN";
            this.CheckEventBTN.Size = new System.Drawing.Size(92, 46);
            this.CheckEventBTN.TabIndex = 0;
            this.CheckEventBTN.Text = "Check event";
            this.CheckEventBTN.UseVisualStyleBackColor = true;
            this.CheckEventBTN.Click += new System.EventHandler(this.CheckEventBTN_Click);
            // 
            // Form_Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 545);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Receptionist";
            this.Text = "Form_Receptionist";
            this.Load += new System.EventHandler(this.Form_Receptionist_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBillGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CheckRoomViewCombo;
        private System.Windows.Forms.ComboBox CheckRoomTypeCombo;
        private System.Windows.Forms.Button CheckRoomAvailableBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker CheckEndDate;
        private System.Windows.Forms.DateTimePicker CheckStartDate;
        private System.Windows.Forms.Button ReserveBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CheckUSSN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CheckRoomNO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox BillRoomNoCombo;
        private System.Windows.Forms.Button CheckBillBTN;
        private System.Windows.Forms.DataGridView CheckBillGrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CheckOutBTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CheckOutUSSNCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CheckOutRoomNOCombo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button CheckEventBTN;
    }
}