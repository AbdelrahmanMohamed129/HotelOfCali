namespace DBapplication
{
	partial class Form_findevents
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.bla = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_findevent = new System.Windows.Forms.Button();
			this.combo_findevent = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(422, 35);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(473, 370);
			this.dataGridView1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(247, 185);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 45);
			this.button1.TabIndex = 1;
			this.button1.Text = "Select All Events";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// bla
			// 
			this.bla.AutoSize = true;
			this.bla.Location = new System.Drawing.Point(26, 110);
			this.bla.Name = "bla";
			this.bla.Size = new System.Drawing.Size(72, 16);
			this.bla.TabIndex = 2;
			this.bla.Text = "Event Num";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(173, 36);
			this.label2.TabIndex = 4;
			this.label2.Text = "Find Events";
			// 
			// btn_findevent
			// 
			this.btn_findevent.Location = new System.Drawing.Point(247, 99);
			this.btn_findevent.Name = "btn_findevent";
			this.btn_findevent.Size = new System.Drawing.Size(125, 39);
			this.btn_findevent.TabIndex = 5;
			this.btn_findevent.Text = "Find Event";
			this.btn_findevent.UseVisualStyleBackColor = true;
			this.btn_findevent.Click += new System.EventHandler(this.btn_findevent_Click);
			// 
			// combo_findevent
			// 
			this.combo_findevent.FormattingEnabled = true;
			this.combo_findevent.Location = new System.Drawing.Point(104, 107);
			this.combo_findevent.Name = "combo_findevent";
			this.combo_findevent.Size = new System.Drawing.Size(121, 24);
			this.combo_findevent.TabIndex = 6;
			this.combo_findevent.DropDown += new System.EventHandler(this.combo_findevent_DropDown);
			// 
			// Form_findevents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(909, 476);
			this.Controls.Add(this.combo_findevent);
			this.Controls.Add(this.btn_findevent);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bla);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form_findevents";
			this.Text = "Form_findevents";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label bla;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_findevent;
		private System.Windows.Forms.ComboBox combo_findevent;
	}
}