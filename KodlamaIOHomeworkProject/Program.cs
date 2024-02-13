
using KodlamaIOHomeworkProject.Business.Concrete;
using KodlamaIOHomeworkProject.DataAccess.Concrete;
using KodlamaIOHomeworkProject.Entities;

 
Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");
CourseManager courseManager = new CourseManager(new CourseDal());
Console.WriteLine("********************Başlangıçtaki Kurslar********************");

List<Course> courses = courseManager.GetAll();
courseManager.PrintAll(courses);
Console.WriteLine("");

Console.WriteLine("********************Kurs Eklemesi********************");
courseManager.Add(new Course()
{
	CourseID = 4,
	CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
	CategoryID = 4,
	CourseDescription = "1,5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
	CourseImage = "image4.jpg",
	InstructorID = 1
});
courseManager.PrintAll(courses);
Console.WriteLine("");


Console.WriteLine("********************Kurs Güncellemesi********************");
courseManager.Update(new Course()
{
	CourseID = 3,
	CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
	CategoryID = 2,
	InstructorID = 2,
	CourseImage = "image3.jpg",
	CourseDescription = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını sürekli buradan takip edebilirsiniz!."
});
courseManager.PrintAll(courses);
Console.WriteLine("");


Console.WriteLine("********************Kurs Silinmesi********************");
courseManager.Delete(3);
courseManager.PrintAll(courses);
Console.WriteLine("");

Console.WriteLine("********************ID'ye göre kurs getirme********************");
var getCourse = courseManager.GetById(4);
courseManager.PrintCourse(getCourse);
Console.WriteLine("");

Console.ReadLine();

/*

Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");
CategoryManager CategoryManager = new CategoryManager(new CategoryDal());

Console.WriteLine("********************Başlangıçtaki Kategorilar********************");

List<Category> categories = CategoryManager.GetAll();
CategoryManager.PrintAll(categories);
Console.WriteLine("");

Console.WriteLine("********************Kategori Eklemesi********************");
CategoryManager.Add(new Category()
{
	CategoryID = 5,
	CategoryName = "Swift"
});
CategoryManager.PrintAll(categories);
Console.WriteLine("");


Console.WriteLine("********************Kategori Güncellemesi********************");
CategoryManager.Update(new Category()
{
	CategoryID = 2,
	CategoryName = "Kotlin"
});
CategoryManager.PrintAll(categories);
Console.WriteLine("");


Console.WriteLine("********************Kategori Silinmesi********************");
CategoryManager.Delete(3);
CategoryManager.PrintAll(categories);
Console.WriteLine("");

Console.WriteLine("********************ID'ye göre Kategori getirme********************");
var getCategory = CategoryManager.GetById(2);
CategoryManager.PrintCategory(getCategory);
Console.WriteLine("");




Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");

InstructorManager instructorManager = new InstructorManager(new InstructorDal());
Console.WriteLine("********************Başlangıçtaki Eğitmenler********************");

List<Instructor> instructors = instructorManager.GetAll();
instructorManager.PrintAll(instructors);
Console.WriteLine("");

Console.WriteLine("********************Eğitmen Eklemesi********************");
instructorManager.Add(new Instructor()
{
	InstructorID = 3,
	InstructorName = "Doğu Berkan",
	InstructorSurname = "Köroğlu"
});
instructorManager.PrintAll(instructors);
Console.WriteLine("");


Console.WriteLine("********************Eğitmen Güncellemesi********************");
instructorManager.Update(new Instructor()
{
	InstructorID = 2,
	InstructorName = "Test",
	InstructorSurname = "Projesi"
});
instructorManager.PrintAll(instructors);
Console.WriteLine("");


Console.WriteLine("********************Eğitmen Silinmesi********************");
instructorManager.Delete(2);
instructorManager.PrintAll(instructors);
Console.WriteLine("");

Console.WriteLine("********************ID'ye göre Eğitmen getirme********************");
var getInstructor = instructorManager.GetById(3);
instructorManager.PrintInstructor(getInstructor);
Console.WriteLine("");
 */