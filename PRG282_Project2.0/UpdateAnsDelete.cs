using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project2._0
{
	public partial class UpdateAnsDelete : Form
	{
		public UpdateAnsDelete()
		{
			InitializeComponent();
		}
		DataHandler handler = new DataHandler();
		Student student = new Student();

		private void button1_Click(object sender, EventArgs e)//populate the student list on 
		{
			listView1.Items.Clear(); 

			List<Student> students = handler.read();

			foreach (var student in students)
			{
				ListViewItem item = new ListViewItem(student.StudentID.ToString()); 
				item.SubItems.Add(student.Name);
				item.SubItems.Add(student.Age.ToString());
				item.SubItems.Add(student.CourseID);  
				listView1.Items.Add(item);  
			}
		}

		private void UpdateAnsDelete_Load(object sender, EventArgs e)
		{
			
		}

		private void listView1_MouseClick(object sender, MouseEventArgs e) //populate the student lisst on textboxes
		{
			if (listView1.SelectedItems.Count > 0)
			{
				string selectedStudentID = listView1.SelectedItems[0].SubItems[0].Text;

				if (int.TryParse(selectedStudentID, out int studentID))
				{
					List<Student> students = handler.read();
					student = students.FirstOrDefault(s => s.StudentID == studentID);

					if (student != null)
					{
						textBox1.Text = student.StudentID.ToString();
						textBox2.Text = student.Name;
						textBox3.Text = student.Age.ToString();
						textBox4.Text = student.CourseID;
					}
					else
					{
						MessageBox.Show("Student not found.");
					}
				}
				else
				{
					MessageBox.Show("Invalid Student ID.");
				}
			}
		}

		private void Back(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
			Search search = new Search();
			search.Show();
		}

		private void button4_Click(object sender, EventArgs e) //delete function
		{
			if (student != null)
			{
				List<Student> students = handler.read();

				var studentToRemove = students.FirstOrDefault(s => s.StudentID == student.StudentID);
				if (studentToRemove != null)
				{
					students.Remove(studentToRemove);
					handler.write(students);  
					MessageBox.Show("Student record deleted successfully.");

					button1_Click(sender, e);
				}
			}
			else
			{
				MessageBox.Show("No student selected.");
			}
		}
	

		private void button3_Click(object sender, EventArgs e) //The Update function
		{
			if (student != null)
			{
				student.Name = textBox2.Text;

				if (int.TryParse(textBox3.Text, out int age))
				{
					student.Age = age;
				}
				else
				{
					MessageBox.Show("Please enter a valid number for Age.");
					return;
				}

				student.CourseID = textBox4.Text;

				List<Student> students = handler.read();

				var studentToUpdate = students.FirstOrDefault(s => s.StudentID == student.StudentID);

				if (studentToUpdate != null)
				{
					studentToUpdate.Name = student.Name;
					studentToUpdate.Age = student.Age;
					studentToUpdate.CourseID = student.CourseID;

					handler.write(students);

					MessageBox.Show("Student details updated successfully!");

					button1_Click(sender, e); 
				}
				else
				{
					MessageBox.Show("Student not found for updating.");
				}
			}
			else
			{
				MessageBox.Show("No student selected.");
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			Averages averages = new Averages();
			averages.Show();
		}
	}
}
