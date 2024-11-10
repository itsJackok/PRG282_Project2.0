namespace PRG282_Project2._0
{
	partial class UpdateAndDelete
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
			this.ShowStudents = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.StudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Student_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Student_Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Student_Course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Delete = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.Update = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.ShowAverages = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// ShowStudents
			// 
			this.ShowStudents.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ShowStudents.Location = new System.Drawing.Point(259, 457);
			this.ShowStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ShowStudents.Name = "ShowStudents";
			this.ShowStudents.Size = new System.Drawing.Size(144, 23);
			this.ShowStudents.TabIndex = 19;
			this.ShowStudents.Text = "Show Students";
			this.ShowStudents.UseVisualStyleBackColor = false;
			this.ShowStudents.Click += new System.EventHandler(this.ShowStudent_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(125, 145);
			this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 18;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(125, 106);
			this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 17;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(125, 66);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 16);
			this.label4.TabIndex = 15;
			this.label4.Text = "Course";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 16);
			this.label3.TabIndex = 14;
			this.label3.Text = "Age";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "StudentID";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(125, 32);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 11;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentID,
            this.Student_Name,
            this.Student_Surname,
            this.Student_Course});
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(259, 16);
			this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(479, 212);
			this.listView1.TabIndex = 10;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
			// 
			// StudentID
			// 
			this.StudentID.Text = "ID";
			this.StudentID.Width = 67;
			// 
			// Student_Name
			// 
			this.Student_Name.Text = "Name";
			this.Student_Name.Width = 124;
			// 
			// Student_Surname
			// 
			this.Student_Surname.Text = "Age";
			this.Student_Surname.Width = 71;
			// 
			// Student_Course
			// 
			this.Student_Course.Text = "Course";
			this.Student_Course.Width = 108;
			// 
			// Delete
			// 
			this.Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Delete.Location = new System.Drawing.Point(384, 570);
			this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(77, 25);
			this.Delete.TabIndex = 29;
			this.Delete.Text = "Delete";
			this.Delete.UseVisualStyleBackColor = false;
			this.Delete.Click += new System.EventHandler(this.Update_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Location = new System.Drawing.Point(520, 570);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(77, 25);
			this.button2.TabIndex = 30;
			this.button2.Text = "Back";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Update
			// 
			this.Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Update.Location = new System.Drawing.Point(259, 570);
			this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(77, 25);
			this.Update.TabIndex = 31;
			this.Update.Text = "Update";
			this.Update.UseVisualStyleBackColor = false;
			this.Update.Click += new System.EventHandler(this.Delete_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button5.Location = new System.Drawing.Point(661, 570);
			this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(77, 25);
			this.button5.TabIndex = 32;
			this.button5.Text = "Exit";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// ShowAverages
			// 
			this.ShowAverages.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ShowAverages.Location = new System.Drawing.Point(453, 457);
			this.ShowAverages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ShowAverages.Name = "ShowAverages";
			this.ShowAverages.Size = new System.Drawing.Size(144, 23);
			this.ShowAverages.TabIndex = 33;
			this.ShowAverages.Text = "show Averages";
			this.ShowAverages.UseVisualStyleBackColor = false;
			this.ShowAverages.Click += new System.EventHandler(this.ShowAverage_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(250, 16);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(488, 436);
			this.dataGridView1.TabIndex = 34;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// UpdateAndDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(777, 616);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.ShowAverages);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.ShowStudents);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listView1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "UpdateAndDelete";
			this.Text = "UpdateAndDelete";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ShowStudents;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader StudentID;
		private System.Windows.Forms.ColumnHeader Student_Name;
		private System.Windows.Forms.ColumnHeader Student_Surname;
		private System.Windows.Forms.ColumnHeader Student_Course;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button ShowAverages;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}