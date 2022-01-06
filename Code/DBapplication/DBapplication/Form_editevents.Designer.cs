namespace DBapplication
{
	partial class Form_editevents
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
			this.label1 = new System.Windows.Forms.Label();
			this.text_addeventcost = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.text_addeventdescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.date_eventstartdate = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.date_eventenddate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_addevent = new System.Windows.Forms.Button();
			this.btn_removevent = new System.Windows.Forms.Button();
			//this.hotel_ProjectDataSet1 = new DBapplication.Hotel_ProjectDataSet();
			this.combo_eventnum = new System.Windows.Forms.ComboBox();
			//((System.ComponentModel.ISupportInitialize)(this.hotel_ProjectDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Add Event";
			// 
			// text_addeventcost
			// 
			this.text_addeventcost.Location = new System.Drawing.Point(111, 161);
			this.text_addeventcost.Name = "text_addeventcost";
			this.text_addeventcost.Size = new System.Drawing.Size(100, 22);
			this.text_addeventcost.TabIndex = 4;
			this.text_addeventcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_addeventcost_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Event Cost";
			// 
			// text_addeventdescription
			// 
			this.text_addeventdescription.Location = new System.Drawing.Point(127, 229);
			this.text_addeventdescription.Multiline = true;
			this.text_addeventdescription.Name = "text_addeventdescription";
			this.text_addeventdescription.Size = new System.Drawing.Size(386, 75);
			this.text_addeventdescription.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 232);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Event Description";
			// 
			// date_eventstartdate
			// 
			this.date_eventstartdate.CustomFormat = "yyyy-MM-dd";
			this.date_eventstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.date_eventstartdate.Location = new System.Drawing.Point(111, 78);
			this.date_eventstartdate.Name = "date_eventstartdate";
			this.date_eventstartdate.Size = new System.Drawing.Size(125, 22);
			this.date_eventstartdate.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 83);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 16);
			this.label9.TabIndex = 18;
			this.label9.Text = "Start Date";
			// 
			// date_eventenddate
			// 
			this.date_eventenddate.CustomFormat = "yyyy-MM-dd";
			this.date_eventenddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.date_eventenddate.Location = new System.Drawing.Point(388, 77);
			this.date_eventenddate.Name = "date_eventenddate";
			this.date_eventenddate.Size = new System.Drawing.Size(125, 22);
			this.date_eventenddate.TabIndex = 21;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(284, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 16);
			this.label5.TabIndex = 20;
			this.label5.Text = "End Date";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(21, 405);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(180, 29);
			this.label6.TabIndex = 22;
			this.label6.Text = "Remove Event";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(23, 482);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 16);
			this.label7.TabIndex = 23;
			this.label7.Text = "Event number";
			// 
			// btn_addevent
			// 
			this.btn_addevent.Location = new System.Drawing.Point(307, 324);
			this.btn_addevent.Name = "btn_addevent";
			this.btn_addevent.Size = new System.Drawing.Size(91, 42);
			this.btn_addevent.TabIndex = 25;
			this.btn_addevent.Text = "Add ";
			this.btn_addevent.UseVisualStyleBackColor = true;
			this.btn_addevent.Click += new System.EventHandler(this.btn_addevent_Click);
			// 
			// btn_removevent
			// 
			this.btn_removevent.Location = new System.Drawing.Point(307, 468);
			this.btn_removevent.Name = "btn_removevent";
			this.btn_removevent.Size = new System.Drawing.Size(99, 45);
			this.btn_removevent.TabIndex = 26;
			this.btn_removevent.Text = "Remove";
			this.btn_removevent.UseVisualStyleBackColor = true;
			this.btn_removevent.Click += new System.EventHandler(this.btn_removevent_Click);
			// 
			// hotel_ProjectDataSet1
			// 
			//this.hotel_ProjectDataSet1.DataSetName = "Hotel_ProjectDataSet";
			//this.hotel_ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// combo_eventnum
			// 
			this.combo_eventnum.FormattingEnabled = true;
			this.combo_eventnum.Location = new System.Drawing.Point(127, 479);
			this.combo_eventnum.Name = "combo_eventnum";
			this.combo_eventnum.Size = new System.Drawing.Size(108, 24);
			this.combo_eventnum.TabIndex = 27;
			this.combo_eventnum.DropDown += new System.EventHandler(this.comboBox1_DropDown);
			// 
			// Form_editevents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 545);
			this.Controls.Add(this.combo_eventnum);
			this.Controls.Add(this.btn_removevent);
			this.Controls.Add(this.btn_addevent);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.date_eventenddate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.date_eventstartdate);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.text_addeventdescription);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.text_addeventcost);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "Form_editevents";
			this.Text = "Add/Remove Events";
			//((System.ComponentModel.ISupportInitialize)(this.hotel_ProjectDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox text_addeventcost;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox text_addeventdescription;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.DateTimePicker date_eventstartdate;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.DateTimePicker date_eventenddate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btn_addevent;
		private System.Windows.Forms.Button btn_removevent;
		//private Hotel_ProjectDataSet hotel_ProjectDataSet1;
		private System.Windows.Forms.ComboBox combo_eventnum;
	}
}