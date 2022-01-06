
namespace DBapplication
{
    partial class Show_Form
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.text_ssn = new System.Windows.Forms.TextBox();
			this.text_password = new System.Windows.Forms.TextBox();
			this.text_username = new System.Windows.Forms.TextBox();
			this.text_minit = new System.Windows.Forms.TextBox();
			this.bla = new System.Windows.Forms.Label();
			this.text_lname = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.text_fname = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.radiobtn_male = new System.Windows.Forms.RadioButton();
			this.radiobtn_female = new System.Windows.Forms.RadioButton();
			this.label9 = new System.Windows.Forms.Label();
			this.bdate = new System.Windows.Forms.DateTimePicker();
			this.text_address = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.text_mobile = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btn_signup = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(326, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Signup";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Username";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(284, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "First Name";
			// 
			// text_ssn
			// 
			this.text_ssn.Location = new System.Drawing.Point(109, 212);
			this.text_ssn.Name = "text_ssn";
			this.text_ssn.Size = new System.Drawing.Size(125, 22);
			this.text_ssn.TabIndex = 4;
			this.text_ssn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_ssn_KeyPress);
			// 
			// text_password
			// 
			this.text_password.Location = new System.Drawing.Point(377, 101);
			this.text_password.Name = "text_password";
			this.text_password.Size = new System.Drawing.Size(125, 22);
			this.text_password.TabIndex = 5;
			// 
			// text_username
			// 
			this.text_username.Location = new System.Drawing.Point(109, 104);
			this.text_username.Name = "text_username";
			this.text_username.Size = new System.Drawing.Size(125, 22);
			this.text_username.TabIndex = 6;
			// 
			// text_minit
			// 
			this.text_minit.Location = new System.Drawing.Point(377, 160);
			this.text_minit.MaxLength = 1;
			this.text_minit.Name = "text_minit";
			this.text_minit.Size = new System.Drawing.Size(125, 22);
			this.text_minit.TabIndex = 8;
			this.text_minit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_minit_KeyPress);
			// 
			// bla
			// 
			this.bla.AutoSize = true;
			this.bla.Location = new System.Drawing.Point(284, 160);
			this.bla.Name = "bla";
			this.bla.Size = new System.Drawing.Size(88, 16);
			this.bla.TabIndex = 7;
			this.bla.Text = "Middle Name";
			// 
			// text_lname
			// 
			this.text_lname.Location = new System.Drawing.Point(635, 160);
			this.text_lname.Name = "text_lname";
			this.text_lname.Size = new System.Drawing.Size(125, 22);
			this.text_lname.TabIndex = 10;
			this.text_lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_lname_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(558, 163);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 16);
			this.label6.TabIndex = 9;
			this.label6.Text = "Last Name";
			// 
			// text_fname
			// 
			this.text_fname.Location = new System.Drawing.Point(109, 157);
			this.text_fname.Name = "text_fname";
			this.text_fname.Size = new System.Drawing.Size(125, 22);
			this.text_fname.TabIndex = 12;
			this.text_fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_fname_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(32, 221);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 16);
			this.label7.TabIndex = 11;
			this.label7.Text = "SSN";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(32, 279);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 16);
			this.label8.TabIndex = 13;
			this.label8.Text = "Gender";
			// 
			// radiobtn_male
			// 
			this.radiobtn_male.AutoSize = true;
			this.radiobtn_male.Checked = true;
			this.radiobtn_male.Location = new System.Drawing.Point(109, 277);
			this.radiobtn_male.Name = "radiobtn_male";
			this.radiobtn_male.Size = new System.Drawing.Size(58, 20);
			this.radiobtn_male.TabIndex = 14;
			this.radiobtn_male.TabStop = true;
			this.radiobtn_male.Text = "Male";
			this.radiobtn_male.UseVisualStyleBackColor = true;
			// 
			// radiobtn_female
			// 
			this.radiobtn_female.AutoSize = true;
			this.radiobtn_female.Location = new System.Drawing.Point(199, 277);
			this.radiobtn_female.Name = "radiobtn_female";
			this.radiobtn_female.Size = new System.Drawing.Size(74, 20);
			this.radiobtn_female.TabIndex = 15;
			this.radiobtn_female.Text = "Female";
			this.radiobtn_female.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(312, 277);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 16);
			this.label9.TabIndex = 16;
			this.label9.Text = "Birthdate";
			// 
			// bdate
			// 
			this.bdate.CustomFormat = "yyyy-MM-dd";
			this.bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.bdate.Location = new System.Drawing.Point(378, 274);
			this.bdate.Name = "bdate";
			this.bdate.Size = new System.Drawing.Size(125, 22);
			this.bdate.TabIndex = 17;
			// 
			// text_address
			// 
			this.text_address.Location = new System.Drawing.Point(377, 215);
			this.text_address.Name = "text_address";
			this.text_address.Size = new System.Drawing.Size(125, 22);
			this.text_address.TabIndex = 19;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(300, 218);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 16);
			this.label10.TabIndex = 18;
			this.label10.Text = "Address";
			// 
			// text_mobile
			// 
			this.text_mobile.Location = new System.Drawing.Point(635, 215);
			this.text_mobile.Name = "text_mobile";
			this.text_mobile.Size = new System.Drawing.Size(125, 22);
			this.text_mobile.TabIndex = 21;
			this.text_mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_mobile_KeyPress);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(558, 218);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 16);
			this.label11.TabIndex = 20;
			this.label11.Text = "Mobile";
			// 
			// btn_signup
			// 
			this.btn_signup.Location = new System.Drawing.Point(332, 345);
			this.btn_signup.Name = "btn_signup";
			this.btn_signup.Size = new System.Drawing.Size(132, 41);
			this.btn_signup.TabIndex = 22;
			this.btn_signup.Text = "Signup";
			this.btn_signup.UseVisualStyleBackColor = true;
			this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
			// 
			// Show_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_signup);
			this.Controls.Add(this.text_mobile);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.text_address);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.bdate);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.radiobtn_female);
			this.Controls.Add(this.radiobtn_male);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.text_fname);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.text_lname);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.text_minit);
			this.Controls.Add(this.bla);
			this.Controls.Add(this.text_username);
			this.Controls.Add(this.text_password);
			this.Controls.Add(this.text_ssn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Show_Form";
			this.Text = "Singup";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox text_ssn;
		private System.Windows.Forms.TextBox text_password;
		private System.Windows.Forms.TextBox text_username;
		private System.Windows.Forms.TextBox text_minit;
		private System.Windows.Forms.Label bla;
		private System.Windows.Forms.TextBox text_lname;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox text_fname;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RadioButton radiobtn_male;
		private System.Windows.Forms.RadioButton radiobtn_female;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.DateTimePicker bdate;
		private System.Windows.Forms.TextBox text_address;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox text_mobile;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btn_signup;
	}
}