namespace PRG282_Project2._0
{
	partial class UpdateAnsDelete
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
			this.button1 = new System.Windows.Forms.Button();
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
			this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(258, 245);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 23);
			this.button1.TabIndex = 19;
			this.button1.Text = "Show Students";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(125, 145);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 18;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(125, 106);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 17;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(125, 67);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 16);
			this.label4.TabIndex = 15;
			this.label4.Text = "Course";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 16);
			this.label3.TabIndex = 14;
			this.label3.Text = "Age";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "StudentID";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(125, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 11;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentID,
            this.Name,
            this.Surname,
            this.Course});
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(258, 16);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(478, 212);
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
			// Name
			// 
			this.Name.Text = "Name";
			this.Name.Width = 124;
			// 
			// Surname
			// 
			this.Surname.Text = "Age";
			this.Surname.Width = 71;
			// 
			// Course
			// 
			this.Course.Text = "Course";
			this.Course.Width = 108;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(391, 398);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(78, 24);
			this.button4.TabIndex = 29;
			this.button4.Text = "Delete";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(525, 398);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(78, 24);
			this.button2.TabIndex = 30;
			this.button2.Text = "Back";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.TextChanged += new System.EventHandler(this.Back);
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(258, 398);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(78, 24);
			this.button3.TabIndex = 31;
			this.button3.Text = "Update";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(658, 398);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(78, 24);
			this.button5.TabIndex = 32;
			this.button5.Text = "Exit";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(425, 245);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(144, 23);
			this.button6.TabIndex = 33;
			this.button6.Text = "show Averages";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// UpdateAnsDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(777, 450);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listView1);
			
			this.Text = "UpdateAnsDelete";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
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
		private System.Windows.Forms.ColumnHeader Name;
		private System.Windows.Forms.ColumnHeader Surname;
		private System.Windows.Forms.ColumnHeader Course;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
	}
}