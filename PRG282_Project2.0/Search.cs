using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace PRG282_Project2._0
{
	public partial class Search : Form
	{
		public Search()
		{
			InitializeComponent();
		}

		DataHandler handler = new DataHandler();
		Student student = new Student();

		public DataTable searchStudent(int studentID)
		{
			List<Student> students = handler.read(); 
			var result = students.Where(s => s.StudentID == studentID).ToList();

			DataTable table = new DataTable();
			table.Columns.Add("StudentID", typeof(int));
			table.Columns.Add("Name", typeof(string));
			table.Columns.Add("Age", typeof(int));
			table.Columns.Add("CourseID", typeof(string));

			foreach (var student in result)
			{
				table.Rows.Add(student.StudentID, student.Name, student.Age, student.CourseID);
			}

			return table;
		}
		private void Search_Load(object sender, EventArgs e)
		{
			
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (int.TryParse(textBox1.Text, out int studentID))
			{
				DataTable resultTable = handler.searchStudent(studentID);

				if (resultTable != null && resultTable.Rows.Count > 0)
				{
					dataGridView1.DataSource = resultTable;
				}
				else
				{
					MessageBox.Show("Student not found.");
					dataGridView1.DataSource = null;
				}
			}
			else
			{
				MessageBox.Show("Please enter a valid numeric Student ID.");
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Search_Load_1(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
			AddStudents addStudentsForm = new AddStudents();
			addStudentsForm.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
			UpdateAndDelete update = new UpdateAndDelete();
			update.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
