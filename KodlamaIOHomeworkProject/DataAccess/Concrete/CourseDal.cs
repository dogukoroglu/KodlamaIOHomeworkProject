using KodlamaIOHomeworkProject.DataAccess.Abstract;
using KodlamaIOHomeworkProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomeworkProject.DataAccess.Concrete
{
	public class CourseDal : ICourseDal
	{
		public List<Course> courses;
		public CourseDal()
		{
			courses = new List<Course>()
			{
				new Course() {
					CourseID=1,
					CourseName="Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)",
					CategoryID=1,
					InstructorID=1,
					CourseImage="image1.jpg",
					CourseDescription="Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız."
				},
				new Course()
				{
					CourseID=2,
					CourseName="(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA",
					CategoryID=3,
					InstructorID=1,
					CourseImage="image2.jpg",
					CourseDescription="Java Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız."
				},
				new Course()
				{
					CourseID=3,
					CourseName="(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
					CategoryID=2,
					InstructorID=1,
					CourseImage="image3.jpg",
					CourseDescription="Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız."
				},
			};

		}
		public void Add(Course course)
		{
			courses.Add(course);
		}

		public void Delete(int id)
		{
			var deletedCourse = GetById(id);
			courses.Remove(deletedCourse);
		}

		public List<Course> GetAll()
		{
			return courses;
		}

		public Course GetById(int id)
		{
			foreach (var course in courses)
			{
				if (course.CourseID == id)
				{
					return course;
				}
			}
			throw new Exception("Girdiğiniz Id ile eşleşen bir Kurs bulunmamaktadır.");
		}

		public void PrintAll(List<Course> courses)
		{
			foreach (var course in courses)
			{
				PrintCourse(course);
			}
		}

		public void PrintCourse(Course course)
		{
			Console.WriteLine("Kurs ID: " + " " + course.CourseID);
			Console.WriteLine("Kurs Adı: " + " " + course.CourseName);
			Console.WriteLine("Kurs Açıklaması: " + " " + course.CourseDescription);
			Console.WriteLine("Kurs Resim Linki: " + " " + course.CourseImage);
			Console.WriteLine("Kategori ID: " + " " + course.CategoryID);
			Console.WriteLine("Eğitmen ID: " + " " + course.InstructorID);
			Console.WriteLine();
		}

		public void Update(Course course)
		{
			var updatedCourse = GetById(course.CourseID);
			updatedCourse.CourseName = course.CourseName;
			updatedCourse.CourseDescription = course.CourseDescription;
			updatedCourse.CategoryID = course.CategoryID;
			updatedCourse.CategoryID = course.CategoryID;
			updatedCourse.CourseImage = course.CourseImage;
		}
	}
}
