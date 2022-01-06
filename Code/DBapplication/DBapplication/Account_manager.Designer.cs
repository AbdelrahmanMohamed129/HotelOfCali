namespace DBapplication
{
	partial class Form_manager
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
			this.AddRemoveRoomsBtn = new System.Windows.Forms.Button();
			this.EditEmployeesBtn = new System.Windows.Forms.Button();
			this.EditDependentsBtn = new System.Windows.Forms.Button();
			this.RecepVIEW = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AddRemoveRoomsBtn
			// 
			this.AddRemoveRoomsBtn.Location = new System.Drawing.Point(123, 54);
			this.AddRemoveRoomsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddRemoveRoomsBtn.Name = "AddRemoveRoomsBtn";
			this.AddRemoveRoomsBtn.Size = new System.Drawing.Size(165, 31);
			this.AddRemoveRoomsBtn.TabIndex = 0;
			this.AddRemoveRoomsBtn.Text = "Add/Remove Rooms";
			this.AddRemoveRoomsBtn.UseVisualStyleBackColor = true;
			this.AddRemoveRoomsBtn.Click += new System.EventHandler(this.AddRemoveRoomsBtn_Click);
			// 
			// EditEmployeesBtn
			// 
			this.EditEmployeesBtn.Location = new System.Drawing.Point(123, 117);
			this.EditEmployeesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.EditEmployeesBtn.Name = "EditEmployeesBtn";
			this.EditEmployeesBtn.Size = new System.Drawing.Size(165, 31);
			this.EditEmployeesBtn.TabIndex = 1;
			this.EditEmployeesBtn.Text = "Edit Employees";
			this.EditEmployeesBtn.UseVisualStyleBackColor = true;
			this.EditEmployeesBtn.Click += new System.EventHandler(this.EditEmployeesBtn_Click);
			// 
			// EditDependentsBtn
			// 
			this.EditDependentsBtn.Location = new System.Drawing.Point(123, 186);
			this.EditDependentsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.EditDependentsBtn.Name = "EditDependentsBtn";
			this.EditDependentsBtn.Size = new System.Drawing.Size(165, 31);
			this.EditDependentsBtn.TabIndex = 2;
			this.EditDependentsBtn.Text = "Edit Dependents";
			this.EditDependentsBtn.UseVisualStyleBackColor = true;
			this.EditDependentsBtn.Click += new System.EventHandler(this.EditDependentsBtn_Click);
			// 
			// RecepVIEW
			// 
			this.RecepVIEW.Location = new System.Drawing.Point(123, 247);
			this.RecepVIEW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RecepVIEW.Name = "RecepVIEW";
			this.RecepVIEW.Size = new System.Drawing.Size(165, 31);
			this.RecepVIEW.TabIndex = 3;
			this.RecepVIEW.Text = "Receptionist view";
			this.RecepVIEW.UseVisualStyleBackColor = true;
			this.RecepVIEW.Click += new System.EventHandler(this.RecepVIEW_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(123, 306);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(165, 31);
			this.button1.TabIndex = 4;
			this.button1.Text = "Logout";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form_manager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 382);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.RecepVIEW);
			this.Controls.Add(this.EditDependentsBtn);
			this.Controls.Add(this.EditEmployeesBtn);
			this.Controls.Add(this.AddRemoveRoomsBtn);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form_manager";
			this.Text = "Manager";
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button AddRemoveRoomsBtn;
        private System.Windows.Forms.Button EditEmployeesBtn;
        private System.Windows.Forms.Button EditDependentsBtn;
        private System.Windows.Forms.Button RecepVIEW;
		private System.Windows.Forms.Button button1;
	}
}