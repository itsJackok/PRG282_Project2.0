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
	public partial class UpdateAndDelete : Form
	{
		public UpdateAndDelete()
		{
			InitializeComponent();
		}
		DataHandler handler = new DataHandler();
		Student student = new Student();

		//This is populating the listview from the data captured from the textboxes
		private void ShowStudent_Click(object sender, EventArgs e)
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
		//When a certain cell if clicked on the Listview it will popluate the textboxes
		private void listView1_MouseClick(object sender, MouseEventArgs e) 
		{
			if (listView1.SelectedItems.Count > 0) //exception tester
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

		//This is the back button back to the search form /search function
		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
			Search search = new Search();
			search.Show();
		}

		//This is the delete function that delets the student details from the listview runs with the click of the Delete button
		private void Delete_Click(object sender, EventArgs e) 
		{
			if (student != null) //Exception tester
			{
				List<Student> students = handler.read();

				var studentToRemove = students.FirstOrDefault(s => s.StudentID == student.StudentID);
				if (studentToRemove != null)
				{
					students.Remove(studentToRemove);
					handler.write(students);  
					MessageBox.Show("Student record deleted successfully.");

					ShowStudent_Click(sender, e);
				}
			}
			else
			{
				MessageBox.Show("No student selected.");
			}
		}
	
		//This is the update function where the info of the student is updated to the listviewwhile pressing the update
		private void Update_Click(object sender, EventArgs e) 
		{
			if (student != null) //exception tester
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

				if (studentToUpdate != null) //tested?
				{
					studentToUpdate.Name = student.Name;
					studentToUpdate.Age = student.Age;
					studentToUpdate.CourseID = student.CourseID;

					handler.write(students);

					MessageBox.Show("Student details updated successfully!");

					ShowStudent_Click(sender, e); 
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

	
		//Exit Button
		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		// This is showing the avearge form of all of the students in the listview
		private void ShowAverage_Click(object sender, EventArgs e)
		{
			this.Hide();
			Averages averages = new Averages();
			averages.Show();
		}

      
    }
}
