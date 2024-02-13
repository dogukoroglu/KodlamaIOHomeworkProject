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
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;
		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void Add(Category category)
		{   //Business Rules
			_categoryDal.Add(category);
		}

		public void Delete(int id)
		{   //Business Rules
			_categoryDal.Delete(id);
		}

		public List<Category> GetAll()
		{   //Business Rules
			return _categoryDal.GetAll();
		}

		public Category GetById(int id)
		{   //Business Rules
			return _categoryDal.GetById(id);
		}

		public void PrintAll(List<Category> categories)
		{
			_categoryDal.PrintAll(categories);
		}

		public void PrintCategory(Category category)
		{
			_categoryDal.PrintCategory(category);
		}

		public void Update(Category category)
		{   //Business Rules
			_categoryDal.Update(category);
		}
	}
}
