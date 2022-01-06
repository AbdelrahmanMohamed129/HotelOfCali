
namespace DBapplication
{
    partial class Form_RecepResEvent
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
            this.EventNOcombo = new System.Windows.Forms.ComboBox();
            this.AddEventBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.USSNcombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EventNOcombo
            // 
            this.EventNOcombo.FormattingEnabled = true;
            this.EventNOcombo.Location = new System.Drawing.Point(92, 84);
            this.EventNOcombo.Margin = new System.Windows.Forms.Padding(2);
            this.EventNOcombo.Name = "EventNOcombo";
            this.EventNOcombo.Size = new System.Drawing.Size(92, 21);
            this.EventNOcombo.TabIndex = 8;
            // 
            // AddEventBTN
            // 
            this.AddEventBTN.Location = new System.Drawing.Point(238, 97);
            this.AddEventBTN.Margin = new System.Windows.Forms.Padding(2);
            this.AddEventBTN.Name = "AddEventBTN";
            this.AddEventBTN.Size = new System.Drawing.Size(76, 39);
            this.AddEventBTN.TabIndex = 7;
            this.AddEventBTN.Text = "Submit";
            this.AddEventBTN.UseVisualStyleBackColor = true;
            this.AddEventBTN.Click += new System.EventHandler(this.AddEventBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reserve Event Ticket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Event num";
            // 
            // USSNcombo
            // 
            this.USSNcombo.FormattingEnabled = true;
            this.USSNcombo.Location = new System.Drawing.Point(92, 120);
            this.USSNcombo.Margin = new System.Windows.Forms.Padding(2);
            this.USSNcombo.Name = "USSNcombo";
            this.USSNcombo.Size = new System.Drawing.Size(92, 21);
            this.USSNcombo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "User SSN";
            // 
            // Form_RecepResEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 215);
            this.Controls.Add(this.USSNcombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EventNOcombo);
            this.Controls.Add(this.AddEventBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_RecepResEvent";
            this.Text = "Form_RecepResEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox EventNOcombo;
        private System.Windows.Forms.Button AddEventBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox USSNcombo;
        private System.Windows.Forms.Label label3;
    }
}