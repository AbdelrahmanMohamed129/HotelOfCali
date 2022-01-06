namespace DBapplication
{
    partial class Form_HouseKeeping
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
			this.label_username = new System.Windows.Forms.Label();
			this.btn_markrooms = new System.Windows.Forms.Button();
			this.btn_checkrooms = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(210, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 39);
			this.label1.TabIndex = 5;
			this.label1.Text = "Welcome";
			// 
			// label_username
			// 
			this.label_username.AutoSize = true;
			this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_username.Location = new System.Drawing.Point(240, 101);
			this.label_username.Name = "label_username";
			this.label_username.Size = new System.Drawing.Size(78, 36);
			this.label_username.TabIndex = 4;
			this.label_username.Text = "User";
			// 
			// btn_markrooms
			// 
			this.btn_markrooms.Location = new System.Drawing.Point(206, 339);
			this.btn_markrooms.Name = "btn_markrooms";
			this.btn_markrooms.Size = new System.Drawing.Size(163, 57);
			this.btn_markrooms.TabIndex = 7;
			this.btn_markrooms.Text = "Mark Rooms";
			this.btn_markrooms.UseVisualStyleBackColor = true;
			this.btn_markrooms.Click += new System.EventHandler(this.btn_markrooms_Click);
			// 
			// btn_checkrooms
			// 
			this.btn_checkrooms.Location = new System.Drawing.Point(206, 212);
			this.btn_checkrooms.Name = "btn_checkrooms";
			this.btn_checkrooms.Size = new System.Drawing.Size(163, 57);
			this.btn_checkrooms.TabIndex = 6;
			this.btn_checkrooms.Text = "Check Rooms";
			this.btn_checkrooms.UseVisualStyleBackColor = true;
			this.btn_checkrooms.Click += new System.EventHandler(this.btn_checkrooms_Click);
			// 
			// Form_HouseKeeping
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 533);
			this.Controls.Add(this.btn_markrooms);
			this.Controls.Add(this.btn_checkrooms);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label_username);
			this.Name = "Form_HouseKeeping";
			this.Text = "Form_HouseKeeping";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label_username;
		private System.Windows.Forms.Button btn_markrooms;
		private System.Windows.Forms.Button btn_checkrooms;
	}
}