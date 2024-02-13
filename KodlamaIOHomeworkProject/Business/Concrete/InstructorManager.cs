using KodlamaIOHomeworkProject.Business.Abstract;
using KodlamaIOHomeworkProject.DataAccess.Abstract;
using KodlamaIOHomeworkProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomeworkProject.Business.Concrete
{
	public class InstructorManager : IInstructorService
	{
		IInstructorDal _instructorDal;
		public InstructorManager(IInstructorDal instructorDal)
		{
			_instructorDal = instructorDal;
		}

		public void Add(Instructor instructor)
		{
			_instructorDal.Add(instructor);
		}

		public void Delete(int id)
		{   //Business Rules
			_instructorDal.Delete(id);
		}

		public List<Instructor> GetAll()
		{   //Business Rules
			return _instructorDal.GetAll();
		}

		public Instructor GetById(int id)
		{   //Business Rules
			return _instructorDal.GetById(id);
		}

		public void PrintAll(List<Instructor> instructors)
		{
			_instructorDal.PrintAll(instructors);
		}

		public void PrintInstructor(Instructor instructor)
		{
			_instructorDal.PrintInstructor(instructor);
		}

		public void Update(Instructor instructor)
		{   //Business Rules
			_instructorDal.Update(instructor);
		}
	}
}
