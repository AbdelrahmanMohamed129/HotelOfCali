namespace DBapplication
{
    partial class Form_CEO
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
            this.RecepView = new System.Windows.Forms.Button();
            this.MgrView = new System.Windows.Forms.Button();
            this.OrgView = new System.Windows.Forms.Button();
            this.HouView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SalaryMGR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenderMGR = new System.Windows.Forms.ComboBox();
            this.AddMGR = new System.Windows.Forms.Button();
            this.MobileMGR = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AddressMGR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BdateMGR = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FNameMGR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LNameMGR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MinitMGR = new System.Windows.Forms.TextBox();
            this.bla = new System.Windows.Forms.Label();
            this.UsernameMGR = new System.Windows.Forms.TextBox();
            this.PasswordMGR = new System.Windows.Forms.TextBox();
            this.SSNMGR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FireMGR = new System.Windows.Forms.Button();
            this.DelMGRCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecepView
            // 
            this.RecepView.Location = new System.Drawing.Point(48, 219);
            this.RecepView.Name = "RecepView";
            this.RecepView.Size = new System.Drawing.Size(116, 34);
            this.RecepView.TabIndex = 0;
            this.RecepView.Text = "Receptionist view";
            this.RecepView.UseVisualStyleBackColor = true;
            this.RecepView.Click += new System.EventHandler(this.RecepView_Click);
            // 
            // MgrView
            // 
            this.MgrView.Location = new System.Drawing.Point(48, 170);
            this.MgrView.Name = "MgrView";
            this.MgrView.Size = new System.Drawing.Size(116, 34);
            this.MgrView.TabIndex = 1;
            this.MgrView.Text = "Manager view";
            this.MgrView.UseVisualStyleBackColor = true;
            this.MgrView.Click += new System.EventHandler(this.MgrView_Click);
            // 
            // OrgView
            // 
            this.OrgView.Location = new System.Drawing.Point(48, 269);
            this.OrgView.Name = "OrgView";
            this.OrgView.Size = new System.Drawing.Size(116, 34);
            this.OrgView.TabIndex = 2;
            this.OrgView.Text = "Organiser view";
            this.OrgView.UseVisualStyleBackColor = true;
            this.OrgView.Click += new System.EventHandler(this.OrgView_Click);
            // 
            // HouView
            // 
            this.HouView.Location = new System.Drawing.Point(48, 324);
            this.HouView.Name = "HouView";
            this.HouView.Size = new System.Drawing.Size(116, 34);
            this.HouView.TabIndex = 3;
            this.HouView.Text = "Housekeeping view";
            this.HouView.UseVisualStyleBackColor = true;
            this.HouView.Click += new System.EventHandler(this.HouView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(65, 96);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(80, 29);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "BOSS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SalaryMGR);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.GenderMGR);
            this.groupBox1.Controls.Add(this.AddMGR);
            this.groupBox1.Controls.Add(this.MobileMGR);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.AddressMGR);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BdateMGR);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.FNameMGR);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LNameMGR);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MinitMGR);
            this.groupBox1.Controls.Add(this.bla);
            this.groupBox1.Controls.Add(this.UsernameMGR);
            this.groupBox1.Controls.Add(this.PasswordMGR);
            this.groupBox1.Controls.Add(this.SSNMGR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(350, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 204);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a manager";
            // 
            // SalaryMGR
            // 
            this.SalaryMGR.Location = new System.Drawing.Point(280, 128);
            this.SalaryMGR.Margin = new System.Windows.Forms.Padding(2);
            this.SalaryMGR.Name = "SalaryMGR";
            this.SalaryMGR.Size = new System.Drawing.Size(95, 20);
            this.SalaryMGR.TabIndex = 98;
            this.SalaryMGR.TextChanged += new System.EventHandler(this.SalaryMGR_TextChanged);
            this.SalaryMGR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalaryMGR_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Salary";
            // 
            // GenderMGR
            // 
            this.GenderMGR.FormattingEnabled = true;
            this.GenderMGR.Items.AddRange(new object[] {
            "M",
            "F"});
            this.GenderMGR.Location = new System.Drawing.Point(81, 129);
            this.GenderMGR.Margin = new System.Windows.Forms.Padding(2);
            this.GenderMGR.Name = "GenderMGR";
            this.GenderMGR.Size = new System.Drawing.Size(95, 21);
            this.GenderMGR.TabIndex = 96;
            // 
            // AddMGR
            // 
            this.AddMGR.Location = new System.Drawing.Point(279, 159);
            this.AddMGR.Margin = new System.Windows.Forms.Padding(2);
            this.AddMGR.Name = "AddMGR";
            this.AddMGR.Size = new System.Drawing.Size(99, 33);
            this.AddMGR.TabIndex = 93;
            this.AddMGR.Text = "Add manager";
            this.AddMGR.UseVisualStyleBackColor = true;
            this.AddMGR.Click += new System.EventHandler(this.AddMGR_Click);
            // 
            // MobileMGR
            // 
            this.MobileMGR.Location = new System.Drawing.Point(486, 93);
            this.MobileMGR.Margin = new System.Windows.Forms.Padding(2);
            this.MobileMGR.Name = "MobileMGR";
            this.MobileMGR.Size = new System.Drawing.Size(95, 20);
            this.MobileMGR.TabIndex = 92;
            this.MobileMGR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MobileMGR_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(428, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 91;
            this.label11.Text = "Mobile";
            // 
            // AddressMGR
            // 
            this.AddressMGR.Location = new System.Drawing.Point(283, 91);
            this.AddressMGR.Margin = new System.Windows.Forms.Padding(2);
            this.AddressMGR.Name = "AddressMGR";
            this.AddressMGR.Size = new System.Drawing.Size(95, 20);
            this.AddressMGR.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 89;
            this.label10.Text = "Address";
            // 
            // BdateMGR
            // 
            this.BdateMGR.CustomFormat = "yyyy-MM-dd";
            this.BdateMGR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BdateMGR.Location = new System.Drawing.Point(483, 129);
            this.BdateMGR.Margin = new System.Windows.Forms.Padding(2);
            this.BdateMGR.Name = "BdateMGR";
            this.BdateMGR.Size = new System.Drawing.Size(95, 20);
            this.BdateMGR.TabIndex = 88;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Birthdate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "Gender";
            // 
            // FNameMGR
            // 
            this.FNameMGR.Location = new System.Drawing.Point(81, 56);
            this.FNameMGR.Margin = new System.Windows.Forms.Padding(2);
            this.FNameMGR.Name = "FNameMGR";
            this.FNameMGR.Size = new System.Drawing.Size(95, 20);
            this.FNameMGR.TabIndex = 85;
            this.FNameMGR.TextChanged += new System.EventHandler(this.FNameMGR_TextChanged);
            this.FNameMGR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FNameMGR_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "SSN";
            // 
            // LNameMGR
            // 
            this.LNameMGR.Location = new System.Drawing.Point(486, 61);
            this.LNameMGR.Margin = new System.Windows.Forms.Padding(2);
            this.LNameMGR.Name = "LNameMGR";
            this.LNameMGR.Size = new System.Drawing.Size(95, 20);
            this.LNameMGR.TabIndex = 83;
            this.LNameMGR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LNameMGR_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Last Name";
            // 
            // MinitMGR
            // 
            this.MinitMGR.Location = new System.Drawing.Point(283, 59);
            this.MinitMGR.Margin = new System.Windows.Forms.Padding(2);
            this.MinitMGR.MaxLength = 1;
            this.MinitMGR.Name = "MinitMGR";
            this.MinitMGR.Size = new System.Drawing.Size(95, 20);
            this.MinitMGR.TabIndex = 81;
            this.MinitMGR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinitMGR_KeyPress);
            // 
            // bla
            // 
            this.bla.AutoSize = true;
            this.bla.Location = new System.Drawing.Point(213, 59);
            this.bla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bla.Name = "bla";
            this.bla.Size = new System.Drawing.Size(69, 13);
            this.bla.TabIndex = 80;
            this.bla.Text = "Middle Name";
            // 
            // UsernameMGR
            // 
            this.UsernameMGR.Location = new System.Drawing.Point(206, 24);
            this.UsernameMGR.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameMGR.Name = "UsernameMGR";
            this.UsernameMGR.Size = new System.Drawing.Size(95, 20);
            this.UsernameMGR.TabIndex = 79;
            // 
            // PasswordMGR
            // 
            this.PasswordMGR.Location = new System.Drawing.Point(408, 25);
            this.PasswordMGR.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordMGR.Name = "PasswordMGR";
            this.PasswordMGR.Size = new System.Drawing.Size(95, 20);
            this.PasswordMGR.TabIndex = 78;
            // 
            // SSNMGR
            // 
            this.SSNMGR.Location = new System.Drawing.Point(81, 89);
            this.SSNMGR.Margin = new System.Windows.Forms.Padding(2);
            this.SSNMGR.Name = "SSNMGR";
            this.SSNMGR.Size = new System.Drawing.Size(95, 20);
            this.SSNMGR.TabIndex = 77;
            this.SSNMGR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SSNMGR_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(149, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FireMGR);
            this.groupBox2.Controls.Add(this.DelMGRCombo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(556, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 124);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete manager";
            // 
            // FireMGR
            // 
            this.FireMGR.Location = new System.Drawing.Point(73, 71);
            this.FireMGR.Name = "FireMGR";
            this.FireMGR.Size = new System.Drawing.Size(84, 40);
            this.FireMGR.TabIndex = 80;
            this.FireMGR.Text = "Fire manager";
            this.FireMGR.UseVisualStyleBackColor = true;
            this.FireMGR.Click += new System.EventHandler(this.FireMGR_Click);
            // 
            // DelMGRCombo
            // 
            this.DelMGRCombo.FormattingEnabled = true;
            this.DelMGRCombo.Location = new System.Drawing.Point(80, 31);
            this.DelMGRCombo.Margin = new System.Windows.Forms.Padding(2);
            this.DelMGRCombo.Name = "DelMGRCombo";
            this.DelMGRCombo.Size = new System.Drawing.Size(111, 21);
            this.DelMGRCombo.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "SSN";
            // 
            // Form_CEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.HouView);
            this.Controls.Add(this.OrgView);
            this.Controls.Add(this.MgrView);
            this.Controls.Add(this.RecepView);
            this.Name = "Form_CEO";
            this.Text = "Form_CEO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RecepView;
        private System.Windows.Forms.Button MgrView;
        private System.Windows.Forms.Button OrgView;
        private System.Windows.Forms.Button HouView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SalaryMGR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GenderMGR;
        private System.Windows.Forms.Button AddMGR;
        private System.Windows.Forms.TextBox MobileMGR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AddressMGR;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DateTimePicker BdateMGR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FNameMGR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LNameMGR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MinitMGR;
        private System.Windows.Forms.Label bla;
        private System.Windows.Forms.TextBox UsernameMGR;
        private System.Windows.Forms.TextBox PasswordMGR;
        private System.Windows.Forms.TextBox SSNMGR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button FireMGR;
        private System.Windows.Forms.ComboBox DelMGRCombo;
        private System.Windows.Forms.Label label2;
    }
}