namespace DBapplication
{
	partial class Form_changepassword
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
			this.txt_newpassword = new System.Windows.Forms.TextBox();
			this.txt_confirmpassword = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 62);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "New Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 130);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Confirm Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(41, 242);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(318, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Psst don\'t tell anyone your new password";
			// 
			// txt_newpassword
			// 
			this.txt_newpassword.Location = new System.Drawing.Point(192, 62);
			this.txt_newpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_newpassword.Name = "txt_newpassword";
			this.txt_newpassword.Size = new System.Drawing.Size(188, 26);
			this.txt_newpassword.TabIndex = 3;
			// 
			// txt_confirmpassword
			// 
			this.txt_confirmpassword.Location = new System.Drawing.Point(192, 130);
			this.txt_confirmpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_confirmpassword.Name = "txt_confirmpassword";
			this.txt_confirmpassword.Size = new System.Drawing.Size(188, 26);
			this.txt_confirmpassword.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(233, 182);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 34);
			this.button1.TabIndex = 5;
			this.button1.Text = "confirm";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form_changepassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 341);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt_confirmpassword);
			this.Controls.Add(this.txt_newpassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form_changepassword";
			this.Text = "Change Password";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_newpassword;
		private System.Windows.Forms.TextBox txt_confirmpassword;
		private System.Windows.Forms.Button button1;
	}
}