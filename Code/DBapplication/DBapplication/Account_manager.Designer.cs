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
            this.SuspendLayout();
            // 
            // AddRemoveRoomsBtn
            // 
            this.AddRemoveRoomsBtn.Location = new System.Drawing.Point(286, 47);
            this.AddRemoveRoomsBtn.Name = "AddRemoveRoomsBtn";
            this.AddRemoveRoomsBtn.Size = new System.Drawing.Size(165, 31);
            this.AddRemoveRoomsBtn.TabIndex = 0;
            this.AddRemoveRoomsBtn.Text = "Add/Remove Rooms";
            this.AddRemoveRoomsBtn.UseVisualStyleBackColor = true;
            this.AddRemoveRoomsBtn.Click += new System.EventHandler(this.AddRemoveRoomsBtn_Click);
            // 
            // EditEmployeesBtn
            // 
            this.EditEmployeesBtn.Location = new System.Drawing.Point(286, 109);
            this.EditEmployeesBtn.Name = "EditEmployeesBtn";
            this.EditEmployeesBtn.Size = new System.Drawing.Size(165, 31);
            this.EditEmployeesBtn.TabIndex = 1;
            this.EditEmployeesBtn.Text = "Edit Employees";
            this.EditEmployeesBtn.UseVisualStyleBackColor = true;
            this.EditEmployeesBtn.Click += new System.EventHandler(this.EditEmployeesBtn_Click);
            // 
            // EditDependentsBtn
            // 
            this.EditDependentsBtn.Location = new System.Drawing.Point(286, 178);
            this.EditDependentsBtn.Name = "EditDependentsBtn";
            this.EditDependentsBtn.Size = new System.Drawing.Size(165, 31);
            this.EditDependentsBtn.TabIndex = 2;
            this.EditDependentsBtn.Text = "Edit Dependents";
            this.EditDependentsBtn.UseVisualStyleBackColor = true;
            this.EditDependentsBtn.Click += new System.EventHandler(this.EditDependentsBtn_Click);
            // 
            // Form_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditDependentsBtn);
            this.Controls.Add(this.EditEmployeesBtn);
            this.Controls.Add(this.AddRemoveRoomsBtn);
            this.Name = "Form_manager";
            this.Text = "Manager";
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button AddRemoveRoomsBtn;
        private System.Windows.Forms.Button EditEmployeesBtn;
        private System.Windows.Forms.Button EditDependentsBtn;
    }
}