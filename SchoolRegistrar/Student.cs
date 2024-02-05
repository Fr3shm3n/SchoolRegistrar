using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistrar
{
    internal class Student : IStudentActions
    {
        private int id;
        private string name;
        private static SortedSet<Course> schedule;

        public Student()
        {
            schedule = new SortedSet<Course>(new CourseNameComparer());
        }

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
            schedule = new SortedSet<Course>(new CourseNameComparer());
        }

        public Student(int id,  string name, SortedSet<Course> _schedule)
        {
            this.id = id;
            this.name = name;
            schedule = _schedule;
        }

        public int Id { get; init; }
        public string Name { get; init; }

        public SortedSet<Course> Schedule { get; set; }

        public void AddCourse(Course c)
        {
            if (schedule.Count > 6)
            {
                Console.WriteLine("Action could no be performed. Student can only schedule 6 courses per semester.");
                return;
            }

            c.AddStudent(this);
            schedule.Add(c);
            Console.WriteLine("Course: {0} {1} has been added to {2}'s schedule", c.CourseNumber, c.CourseName, Name);
        }

        public void DropCourse(Course c)
        {
            if (schedule.Remove(c))
            {
                c.RemoveStudent(this);
                Console.WriteLine("Course: {0} {1} has been removed from {2} schedule", c.CourseNumber, c.CourseName, Name);
            }
            else
                Console.WriteLine("Action could not be performed, course: {0} {1}", c.CourseNumber, c.CourseName);
        }
    }
}
