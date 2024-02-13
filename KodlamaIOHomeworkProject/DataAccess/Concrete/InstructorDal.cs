using KodlamaIOHomeworkProject.DataAccess.Abstract;
using KodlamaIOHomeworkProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomeworkProject.DataAccess.Concrete
{
	public class InstructorDal : IInstructorDal
	{
		public List<Instructor> instructors;
		public InstructorDal()
		{
			instructors = new List<Instructor>()
			{
			new Instructor() { InstructorID = 1, InstructorName = "Engin", InstructorSurname = "Demiroğ" },
			new Instructor() { InstructorID = 2, InstructorName = "Halit Enes", InstructorSurname = "Kalaycı" }
			};
		}

		public void Add(Instructor instructor)
		{
			instructors.Add(instructor);
		}

		public void Delete(int id)
		{
			var deletedInstructor = GetById(id);
			instructors.Remove(deletedInstructor);
		}

		public List<Instructor> GetAll()
		{
			return instructors.ToList();
		}

		public Instructor GetById(int id)
		{
			foreach (var instructor in instructors)
			{
				if (instructor.InstructorID == id)
				{
					return instructor;
				}
			}
			throw new Exception("Girdiğiniz Id ile eşleşen bir Eğitmen bulunmamaktadır.");
		}

		public void PrintAll(List<Instructor> instructors)
		{
			foreach (var instructor in instructors)
			{
				PrintInstructor(instructor);
			}
		}

		public void PrintInstructor(Instructor instructor)
		{
			Console.WriteLine("Eğitmen ID'si: " + " " + instructor.InstructorID);
			Console.WriteLine("Eğitmen İsmi: " + " " + instructor.InstructorName);
			Console.WriteLine("Eğitmen Soyismi: " + " " + instructor.InstructorSurname);
			Console.WriteLine("");
		}

		public void Update(Instructor instructor)
		{
			var updatedInstructor = GetById(instructor.InstructorID);
			updatedInstructor.InstructorName = instructor.InstructorName;
			updatedInstructor.InstructorSurname = instructor.InstructorSurname;
		}
	}
}
