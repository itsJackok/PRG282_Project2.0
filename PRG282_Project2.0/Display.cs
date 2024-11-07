using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project2._0
{
	internal class Display
	{
		DataHandler handler = new DataHandler();
		List<Student> persons = new List<Student>();


		public void displayOriginal()
		{
			handler.read();
			foreach (var item in handler.container)
			{
				Console.WriteLine(item);
			}
		}

		public void DispalyFormatted()
		{
			handler.read();
			persons.Clear(); 

			foreach (var item in handler.container)
			{
				string[] doh = item.Split(',');

				if (doh.Length == 4)
				{
					int studentID = int.Parse(doh[0].Trim());
					string name = doh[1].Trim();
					int age = int.Parse(doh[2].Trim());
					string courseID = doh[3].Trim();

					persons.Add(new Student(studentID, name, age, courseID));
				}
				else
				{
					Console.WriteLine($"Skipping invalid line: {item}");
				}
			}

			foreach (var student in persons)
			{
				Console.WriteLine(student);
			}

		}

		public void input()
		{
			Student human = new Student();

			Console.Write("Name: ");
			human.Name = Console.ReadLine();
			Console.Write("Age: ");
			if (int.TryParse(Console.ReadLine(), out int age))
			{
				human.Age = age;
			}
			else
			{
				Console.WriteLine("Invalid input for Age. Please enter a numeric value.");
				return; 
			}
			Console.Write("Course: ");
			human.CourseID = Console.ReadLine();

			string line = $"{human.Name},{human.Age},{human.CourseID}";
			handler.container.Add(line);
			handler.save();
		}
	}
}
