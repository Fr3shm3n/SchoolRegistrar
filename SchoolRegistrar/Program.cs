// See https://aka.ms/new-console-template for more information

namespace SchoolRegistrar
{
    public class Program
    {
        public static void Main()
        {
            /*SortedSet<Course> schoolSchedule = new SortedSet<Course>(new CourseNameComparer());
            schoolSchedule.Add(new Course ( 245, "Economics I", Department.MATH ));
            schoolSchedule.Add(new Course { CourseNumber = 383, CourseName = "Psychology I", Department = Department.SCI });
            Console.WriteLine(schoolSchedule.Count);*/

            Course science = new Course ( 1220, "Biology II", Department.SCI );
            //Course math = new Course { CourseNumber = 1310, CourseName = "Algebra I", Department = Department.MATH };
            //Course history = new Course { CourseNumber = 1430, CourseName = "American History", Department = Department.HIST };

            Student student1 = new Student ( 110, "Julius Caesar" );
            Student student2 = new Student ( 125, "Mark Twain" );
            Student student3 = new Student ( 137, "Nikola Tesla" );

            Console.WriteLine("Student: {0} {1}", student2.Id, student2.Name);
            Console.WriteLine("Course: {0} {1} {2}", science.CourseNumber, science.CourseName, science.Department);
            student1.Schedule = new SortedSet<Course>();
            
            student1.Schedule.Add(science);
            student1.AddCourse(science);
            student2.AddCourse(science);
            student3.AddCourse(science);
            student1.AddCourse(science);
            student1.AddCourse(science);

            Console.Write("{0}, {1}\tSchedule\n", student1.Id, student1.Name);
            foreach(Course c in student1.Schedule)
            {
                Console.WriteLine("\nCourse Number:\t{0}\nCourse Name:\t{1}\nDepartment:\t{2}", c.CourseNumber, c.CourseName, c.Department);
            }
        }
    }
}