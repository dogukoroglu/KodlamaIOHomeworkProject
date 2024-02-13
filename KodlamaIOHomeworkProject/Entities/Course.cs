using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomeworkProject.Entities
{
	public class Course
	{
		public int CourseID { get; set; }
		public string CourseName { get; set; }
		public string CourseImage { get; set; }
		public string CourseDescription { get; set; }
		public int CategoryID { get; set; }
		public int InstructorID { get; set; }
	}
}
