using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project2._0
{
	public partial class AddStudents : Form
    {    
            public AddStudents()
		{
			InitializeComponent();
		}
		DataHandler handler = new DataHandler();
		Student student = new Student();
		DataTable myTable = new DataTable();
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (int.TryParse(textBox1.Text, out int studentID))
				{ 
					student.StudentID = studentID;
				}
				else
				{
					MessageBox.Show("Please enter a valid numeric Student ID.");
					return;
				}

				if (string.IsNullOrWhiteSpace(textBox2.Text) ||
					string.IsNullOrWhiteSpace(textBox3.Text) ||
					string.IsNullOrWhiteSpace(textBox4.Text))
				{
					MessageBox.Show("Please fill in all fields.");
					return;
				}

				
				student.Name = textBox2.Text;

				if (int.TryParse(textBox3.Text, out int age))
				{
					student.Age = age;
				}
				else
				{
					MessageBox.Show("Please enter a valid numeric Age.");
					return;
				}

				student.CourseID = textBox4.Text;

				handler.insert(student.StudentID, student.Name, student.Age, student.CourseID);
				MessageBox.Show("Student added successfully!");
				textBox1.Clear();
				textBox2.Clear();
				textBox3.Clear();
				textBox4.Clear();
			}
			catch (FormatException ex)
			{
				MessageBox.Show($"Invalid input format: {ex.Message}");
			}
			catch (IOException ex)
			{
				MessageBox.Show($"File operation error: {ex.Message}");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An unexpected error occurred: {ex.Message}");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Search search = new Search();
			search.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	
	}
}
