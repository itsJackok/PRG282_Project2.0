using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project2._0
{
	public partial class Averages : Form
	{
		public Averages()
		{
			InitializeComponent();
		}
		DataHandler handler = new DataHandler();

		
		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
			UpdateAnsDelete update = new UpdateAnsDelete();
			update.Show();
		}

		private void button1_Click(object sender, EventArgs e) // total number of students search button to populate the average
		{
			List<Student> students = handler.read();

			int totalStudents = students.Count;
			textBox6.Text = totalStudents.ToString();
		}

		private void button2_Click(object sender, EventArgs e) //average search button to populate the average
		{
			List<Student> students = handler.read();

			double averageAge = students.Count > 0 ? students.Average(s => s.Age) : 0;
			textBox5.Text = averageAge.ToString("0.00");
		}

		private void textBox6_TextChanged(object sender, EventArgs e) 
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e) 
		{

		}
		private void SaveSummaryToFile(int totalStudents, double averageAge)
		{
			string summaryText = $"Summary Report\n\n" +
								 $"Total Students: {totalStudents}\n" +
								 $"Average Age: {averageAge:0.00}\n";

			try
			{
				
				File.WriteAllText("summary.txt", summaryText);
				MessageBox.Show("Summary saved successfully to summary.txt");
			}
			catch (IOException ex)
			{
				MessageBox.Show($"Error writing summary to file: {ex.Message}");
			}
		}
	}
}
