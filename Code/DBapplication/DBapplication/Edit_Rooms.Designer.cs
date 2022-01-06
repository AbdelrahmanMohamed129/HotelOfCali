namespace DBapplication
{
    partial class Edit_Rooms
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
            this.RoomTypeCombo = new System.Windows.Forms.ComboBox();
            this.HouKeepingESSNcombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InsertRoomBtn = new System.Windows.Forms.Button();
            this.RoomNoDeleteCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteRoomBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomTypeCombo
            // 
            this.RoomTypeCombo.FormattingEnabled = true;
            this.RoomTypeCombo.Location = new System.Drawing.Point(105, 39);
            this.RoomTypeCombo.Name = "RoomTypeCombo";
            this.RoomTypeCombo.Size = new System.Drawing.Size(121, 24);
            this.RoomTypeCombo.TabIndex = 0;
            // 
            // HouKeepingESSNcombo
            // 
            this.HouKeepingESSNcombo.FormattingEnabled = true;
            this.HouKeepingESSNcombo.Location = new System.Drawing.Point(327, 39);
            this.HouKeepingESSNcombo.Name = "HouKeepingESSNcombo";
            this.HouKeepingESSNcombo.Size = new System.Drawing.Size(121, 24);
            this.HouKeepingESSNcombo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "RoomType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ESSN";
            // 
            // InsertRoomBtn
            // 
            this.InsertRoomBtn.Location = new System.Drawing.Point(495, 34);
            this.InsertRoomBtn.Name = "InsertRoomBtn";
            this.InsertRoomBtn.Size = new System.Drawing.Size(109, 32);
            this.InsertRoomBtn.TabIndex = 4;
            this.InsertRoomBtn.Text = "Insert Room";
            this.InsertRoomBtn.UseVisualStyleBackColor = true;
            this.InsertRoomBtn.Click += new System.EventHandler(this.InsertRoomBtn_Click);
            // 
            // RoomNoDeleteCombo
            // 
            this.RoomNoDeleteCombo.FormattingEnabled = true;
            this.RoomNoDeleteCombo.Location = new System.Drawing.Point(128, 42);
            this.RoomNoDeleteCombo.Name = "RoomNoDeleteCombo";
            this.RoomNoDeleteCombo.Size = new System.Drawing.Size(121, 24);
            this.RoomNoDeleteCombo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room number";
            // 
            // DeleteRoomBtn
            // 
            this.DeleteRoomBtn.Location = new System.Drawing.Point(320, 37);
            this.DeleteRoomBtn.Name = "DeleteRoomBtn";
            this.DeleteRoomBtn.Size = new System.Drawing.Size(109, 32);
            this.DeleteRoomBtn.TabIndex = 7;
            this.DeleteRoomBtn.Text = "Delete Room";
            this.DeleteRoomBtn.UseVisualStyleBackColor = true;
            this.DeleteRoomBtn.Click += new System.EventHandler(this.DeleteRoomBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DeleteRoomBtn);
            this.groupBox1.Controls.Add(this.RoomNoDeleteCombo);
            this.groupBox1.Location = new System.Drawing.Point(15, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 92);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Room";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RoomTypeCombo);
            this.groupBox2.Controls.Add(this.HouKeepingESSNcombo);
            this.groupBox2.Controls.Add(this.InsertRoomBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 92);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert Room";
            // 
            // Edit_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Edit_Rooms";
            this.Text = " Edit_Room";
            this.Load += new System.EventHandler(this.Edit_Rooms_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox RoomTypeCombo;
        private System.Windows.Forms.ComboBox HouKeepingESSNcombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InsertRoomBtn;
        private System.Windows.Forms.ComboBox RoomNoDeleteCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteRoomBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}