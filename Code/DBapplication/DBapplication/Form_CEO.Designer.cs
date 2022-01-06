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
            this.SuspendLayout();
            // 
            // RecepView
            // 
            this.RecepView.Location = new System.Drawing.Point(76, 142);
            this.RecepView.Name = "RecepView";
            this.RecepView.Size = new System.Drawing.Size(116, 34);
            this.RecepView.TabIndex = 0;
            this.RecepView.Text = "Receptionist view";
            this.RecepView.UseVisualStyleBackColor = true;
            // 
            // MgrView
            // 
            this.MgrView.Location = new System.Drawing.Point(76, 93);
            this.MgrView.Name = "MgrView";
            this.MgrView.Size = new System.Drawing.Size(116, 34);
            this.MgrView.TabIndex = 1;
            this.MgrView.Text = "Manager view";
            this.MgrView.UseVisualStyleBackColor = true;
            this.MgrView.Click += new System.EventHandler(this.MgrView_Click);
            // 
            // OrgView
            // 
            this.OrgView.Location = new System.Drawing.Point(76, 192);
            this.OrgView.Name = "OrgView";
            this.OrgView.Size = new System.Drawing.Size(116, 34);
            this.OrgView.TabIndex = 2;
            this.OrgView.Text = "Organiser view";
            this.OrgView.UseVisualStyleBackColor = true;
            // 
            // HouView
            // 
            this.HouView.Location = new System.Drawing.Point(76, 247);
            this.HouView.Name = "HouView";
            this.HouView.Size = new System.Drawing.Size(116, 34);
            this.HouView.TabIndex = 3;
            this.HouView.Text = "Housekeeping view";
            this.HouView.UseVisualStyleBackColor = true;
            // 
            // Form_CEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HouView);
            this.Controls.Add(this.OrgView);
            this.Controls.Add(this.MgrView);
            this.Controls.Add(this.RecepView);
            this.Name = "Form_CEO";
            this.Text = "Form_CEO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RecepView;
        private System.Windows.Forms.Button MgrView;
        private System.Windows.Forms.Button OrgView;
        private System.Windows.Forms.Button HouView;
    }
}