using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project2._0
{
	internal class Student
	{
		int studentID, age ;
		string name, courseID;

		public Student()
		{

		}

		public Student(int studentID, string name, int age, string courseID)
		{
			this.studentID = studentID;
			this.name = name;
			this.age = age;
			this.courseID = courseID;
		}

		public int StudentID { get => studentID; set => studentID = value;}
		public string Name { get => name; set => name = value;}
		public int Age { get => age; set => age = value;}
		public string CourseID { get => courseID; set => courseID = value;}


	}
}
