using KodlamaIOHomeworkProject.DataAccess.Abstract;
using KodlamaIOHomeworkProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomeworkProject.DataAccess.Concrete
{
	public class CategoryDal : ICategoryDal
	{
		public List<Category> categories;

		public CategoryDal()
		{
			categories = new List<Category>()
			{
				new Category() {CategoryID=1,CategoryName="C#"},
				new Category() {CategoryID=2,CategoryName="Python"},
				new Category() {CategoryID=3,CategoryName="Java"},
				new Category() {CategoryID=4,CategoryName="JavaScript"}
			};
		}

		public void Add(Category category)
		{
			categories.Add(category);
		}

		public void Delete(int id)
		{
			var deletedCategory = GetById(id);
			categories.Remove(deletedCategory);
		}

		public List<Category> GetAll()
		{
			return categories.ToList();
		}

		public Category GetById(int id)
		{
			foreach (var category in categories)
			{
				if (category.CategoryID == id)
				{
					return category;
				}
			}
			throw new Exception("Girdiğiniz Id ile eşleşen bir Kategori bulunmamaktadır.");
		}

		public void PrintAll(List<Category> Categorys)
		{
			foreach (var category in Categorys)
			{
				PrintCategory(category);
			}
		}

		public void PrintCategory(Category category)
		{
			Console.WriteLine("Kategori ID: " + " " + category.CategoryID);
			Console.WriteLine("Kategori Adı: " + " " + category.CategoryName);
			Console.WriteLine("");
		}

		public void Update(Category category)
		{
			var updatedCategory = GetById(category.CategoryID);
			updatedCategory.CategoryName = category.CategoryName;
		}
	}
}
