using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace PRG282_Project2._0
{
	internal class DataHandler
	{ //Creating a path to set the textfile
		string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "students.txt");
		public List<string> container = new List<string>();

        //Reading onto the Student.txt using streamReader
        public List<Student> read()
		{
			List<Student> students = new List<Student>();

			if (File.Exists(path))
			{
				using (StreamReader reader = new StreamReader(path))
				{
					string line;

					while ((line = reader.ReadLine()) != null)
					{
						string[] data = line.Split(',');

						if (data.Length == 4)
						{
							int studentID = int.Parse(data[0]);
							string name = data[1];
							int age = int.Parse(data[2]);
							string courseID = data[3];

							students.Add(new Student(studentID, name, age, courseID));
						}
					}
				}
			}
			else
			{
				Console.WriteLine("The file does not exist."); //exception catcher
			}

			return students;  
		}

		//Writing onto the Student.txt using streamWriter
		public void write(List<Student> students)
		{
			try //exception catcher
			{
				using (StreamWriter writer = new StreamWriter(path))
				{
					foreach (var student in students)
					{
						writer.WriteLine($"{student.StudentID},{student.Name},{student.Age},{student.CourseID}");
					}
				}
				Console.WriteLine("File updated successfully.");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error writing to the file: {ex.Message}");
			}
		}

		//Inserting the information of the students by using the did above StreamWriter 
		public void insert(int studentID, string name, int age, string courseID)
		{
			try //exception catcher
			{
				using (StreamWriter writer = new StreamWriter(path, true)) 
				{
					
					writer.WriteLine($"{studentID},{name},{age},{courseID}");
				}
			}
			catch (Exception ex)
			{
				throw new IOException("Failed to write to the file.", ex);
			}

		}

		//This is the search function that can be located at the search button that searches on the datatable which is displayed on the listview
		public DataTable searchStudent(int studentID)
		{
			DataTable resultTable = new DataTable();
			resultTable.Columns.Add("StudentID", typeof(int));
			resultTable.Columns.Add("Name", typeof(string));
			resultTable.Columns.Add("Age", typeof(int));
			resultTable.Columns.Add("CourseID", typeof(string));

			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "students.txt");

			if (!File.Exists(filePath)) //exception catcher
			{
				throw new FileNotFoundException("The students file was not found.");
			}

			foreach (var line in File.ReadAllLines(filePath))
			{
				var fields = line.Split(',');

				if (fields.Length != 4) continue; //this is an exception handler for if its exciding the amount of info needed

				if (int.TryParse(fields[0], out int parsedID) && parsedID == studentID)
				{
					resultTable.Rows.Add(parsedID, fields[1], fields[2], fields[3]);
				}
			}

			return resultTable;
		}

		//This is a function that helps us save the data onto the student.txt
		public void save()
		{
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "students.txt");
			File.WriteAllLines(path, container);
		}
	}
}
