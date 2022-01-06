namespace DBapplication
{
    partial class Organizer
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
			this.label_username = new System.Windows.Forms.Label();
			this.btn_editevents = new System.Windows.Forms.Button();
			this.btn_findevent = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_username
			// 
			this.label_username.AutoSize = true;
			this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_username.Location = new System.Drawing.Point(228, 95);
			this.label_username.Name = "label_username";
			this.label_username.Size = new System.Drawing.Size(78, 36);
			this.label_username.TabIndex = 0;
			this.label_username.Text = "User";
			// 
			// btn_editevents
			// 
			this.btn_editevents.Location = new System.Drawing.Point(194, 198);
			this.btn_editevents.Name = "btn_editevents";
			this.btn_editevents.Size = new System.Drawing.Size(163, 57);
			this.btn_editevents.TabIndex = 1;
			this.btn_editevents.Text = "Edit Event";
			this.btn_editevents.UseVisualStyleBackColor = true;
			this.btn_editevents.Click += new System.EventHandler(this.btn_editevents_Click);
			// 
			// btn_findevent
			// 
			this.btn_findevent.Location = new System.Drawing.Point(194, 325);
			this.btn_findevent.Name = "btn_findevent";
			this.btn_findevent.Size = new System.Drawing.Size(163, 57);
			this.btn_findevent.TabIndex = 2;
			this.btn_findevent.Text = "Find Events";
			this.btn_findevent.UseVisualStyleBackColor = true;
			this.btn_findevent.Click += new System.EventHandler(this.btn_findevent_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(198, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 39);
			this.label1.TabIndex = 3;
			this.label1.Text = "Welcome";
			// 
			// Organizer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 493);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_findevent);
			this.Controls.Add(this.btn_editevents);
			this.Controls.Add(this.label_username);
			this.Name = "Organizer";
			this.Text = "Organizer";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label_username;
		private System.Windows.Forms.Button btn_editevents;
		private System.Windows.Forms.Button btn_findevent;
		private System.Windows.Forms.Label label1;
	}
}