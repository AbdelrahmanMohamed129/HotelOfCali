namespace DBapplication
{
    partial class Edit_Dependents
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
            this.FNameDEPTxt = new System.Windows.Forms.TextBox();
            this.LNameDEPTxt = new System.Windows.Forms.TextBox();
            this.ESSNDEPCombo = new System.Windows.Forms.ComboBox();
            this.RelationDEPTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddDependentsBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ESSNDEPRemoveCombo = new System.Windows.Forms.ComboBox();
            this.RemoveDepBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FNameRemoveDEPcombo = new System.Windows.Forms.ComboBox();
            this.GenderRB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FNameDEPTxt
            // 
            this.FNameDEPTxt.Location = new System.Drawing.Point(77, 43);
            this.FNameDEPTxt.Name = "FNameDEPTxt";
            this.FNameDEPTxt.Size = new System.Drawing.Size(133, 22);
            this.FNameDEPTxt.TabIndex = 0;
            // 
            // LNameDEPTxt
            // 
            this.LNameDEPTxt.Location = new System.Drawing.Point(310, 43);
            this.LNameDEPTxt.Name = "LNameDEPTxt";
            this.LNameDEPTxt.Size = new System.Drawing.Size(133, 22);
            this.LNameDEPTxt.TabIndex = 1;
            // 
            // ESSNDEPCombo
            // 
            this.ESSNDEPCombo.FormattingEnabled = true;
            this.ESSNDEPCombo.Location = new System.Drawing.Point(554, 43);
            this.ESSNDEPCombo.Name = "ESSNDEPCombo";
            this.ESSNDEPCombo.Size = new System.Drawing.Size(121, 24);
            this.ESSNDEPCombo.TabIndex = 2;
            // 
            // RelationDEPTxt
            // 
            this.RelationDEPTxt.Location = new System.Drawing.Point(317, 134);
            this.RelationDEPTxt.Name = "RelationDEPTxt";
            this.RelationDEPTxt.Size = new System.Drawing.Size(121, 22);
            this.RelationDEPTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "FName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "LName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ESSN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Relationship";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender";
            // 
            // AddDependentsBtn
            // 
            this.AddDependentsBtn.Location = new System.Drawing.Point(557, 129);
            this.AddDependentsBtn.Name = "AddDependentsBtn";
            this.AddDependentsBtn.Size = new System.Drawing.Size(118, 29);
            this.AddDependentsBtn.TabIndex = 11;
            this.AddDependentsBtn.Text = "Add Dependents";
            this.AddDependentsBtn.UseVisualStyleBackColor = true;
            this.AddDependentsBtn.Click += new System.EventHandler(this.AddDependentsBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "ESSN";
            // 
            // ESSNDEPRemoveCombo
            // 
            this.ESSNDEPRemoveCombo.FormattingEnabled = true;
            this.ESSNDEPRemoveCombo.Location = new System.Drawing.Point(89, 281);
            this.ESSNDEPRemoveCombo.Name = "ESSNDEPRemoveCombo";
            this.ESSNDEPRemoveCombo.Size = new System.Drawing.Size(121, 24);
            this.ESSNDEPRemoveCombo.TabIndex = 12;
            // 
            // RemoveDepBtn
            // 
            this.RemoveDepBtn.Location = new System.Drawing.Point(501, 276);
            this.RemoveDepBtn.Name = "RemoveDepBtn";
            this.RemoveDepBtn.Size = new System.Drawing.Size(174, 29);
            this.RemoveDepBtn.TabIndex = 14;
            this.RemoveDepBtn.Text = "Remove Dependents";
            this.RemoveDepBtn.UseVisualStyleBackColor = true;
            this.RemoveDepBtn.Click += new System.EventHandler(this.RemoveDepBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "FName";
            // 
            // FNameRemoveDEPcombo
            // 
            this.FNameRemoveDEPcombo.FormattingEnabled = true;
            this.FNameRemoveDEPcombo.Location = new System.Drawing.Point(317, 281);
            this.FNameRemoveDEPcombo.Name = "FNameRemoveDEPcombo";
            this.FNameRemoveDEPcombo.Size = new System.Drawing.Size(121, 24);
            this.FNameRemoveDEPcombo.TabIndex = 15;
            // 
            // GenderRB
            // 
            this.GenderRB.FormattingEnabled = true;
            this.GenderRB.Items.AddRange(new object[] {
            "M",
            "F"});
            this.GenderRB.Location = new System.Drawing.Point(89, 134);
            this.GenderRB.Name = "GenderRB";
            this.GenderRB.Size = new System.Drawing.Size(90, 24);
            this.GenderRB.TabIndex = 17;
            // 
            // Edit_Dependents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 497);
            this.Controls.Add(this.GenderRB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FNameRemoveDEPcombo);
            this.Controls.Add(this.RemoveDepBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ESSNDEPRemoveCombo);
            this.Controls.Add(this.AddDependentsBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RelationDEPTxt);
            this.Controls.Add(this.ESSNDEPCombo);
            this.Controls.Add(this.LNameDEPTxt);
            this.Controls.Add(this.FNameDEPTxt);
            this.Name = "Edit_Dependents";
            this.Text = "Edit_Dependents";
            this.Load += new System.EventHandler(this.Edit_Dependents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FNameDEPTxt;
        private System.Windows.Forms.TextBox LNameDEPTxt;
        private System.Windows.Forms.ComboBox ESSNDEPCombo;
        private System.Windows.Forms.TextBox RelationDEPTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddDependentsBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ESSNDEPRemoveCombo;
        private System.Windows.Forms.Button RemoveDepBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox FNameRemoveDEPcombo;
        private System.Windows.Forms.ComboBox GenderRB;
    }
}