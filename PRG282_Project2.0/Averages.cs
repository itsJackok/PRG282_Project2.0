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
        private const string requiredPassword = "SM2024";
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
        private void btnValidatePassword_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == requiredPassword)
            {
                MessageBox.Show("Password validated successfully!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Call SaveSummaryToFile with current student data after successful validation
                if (int.TryParse(textBox6.Text, out int totalStudents) && double.TryParse(textBox5.Text, out double averageAge))
                {
                    SaveSummaryToFile(totalStudents, averageAge);
                }
                else
                {
                    MessageBox.Show("Please calculate the total students and average age first.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Optionally clear the password textbox for retry
                PasswordTextBox.Clear();
                PasswordTextBox.Focus();
            }
        }
        private void SaveSummaryToFile(int totalStudents, double averageAge)
        {
            string summaryText = $"Summary Report\n\n" +
                                 $"Total Students: {totalStudents}\n" +
                                 $"Average Age: {averageAge:0.00}\n";

            try
            {
                
                string filePath = "summary.txt";
                string directory = Path.GetDirectoryName(filePath);

                if (!Directory.Exists(directory))
                {
                    MessageBox.Show("Directory does not exist. Please check the path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                File.WriteAllText(filePath, summaryText);
                MessageBox.Show("Summary saved successfully to summary.txt", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Checks if users have permission to access the file
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied. You do not have permission to write to this file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Checks if the directory path is valid and actually exists
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("The directory path is invalid. Please check the path and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Checks if the file path is too long
            catch (PathTooLongException)
            {
                MessageBox.Show("The file path is too long. Please use a shorter path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Checks IO Exception erros
            catch (IOException ex)
            {
                MessageBox.Show($"An I/O error occurred while saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Checks for unknown/unexpected errors
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected/unkown error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
