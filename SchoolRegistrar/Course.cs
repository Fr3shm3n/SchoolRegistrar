using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistrar
{
    enum Department
    {
        ENG,
        MATH,
        HIST,
        ART,
        SCI,
        PE
    }

    internal class Course : ICourseActions
    {
        const int Max = 30;
        private int courseNumber;
        private string courseName;
        private Department department;
        private DateTime courseTime;
        private static Dictionary<int, Student> courseRoster = new Dictionary<int, Student>(Max);

        public Course(int courseNumber, string courseName, Department department)
        {
            this.courseNumber = courseNumber;
            this.courseName = courseName;
            this.department = department;
        }

        public int CourseNumber { get; init; }
        public string CourseName { get; init; }
        public Department Department { get; init; }

        public Dictionary<int, Student> CourseRoster { get; set; }

        public void AddStudent(Student student)
        {
            /*if(this.CourseRoster.Count >= 30)
            {
                Console.WriteLine("Action could not be performed. Maximum number of students reached for this course.");
                return;
            }*/

            if (!CourseRoster.ContainsKey(student.Id)) {
                CourseRoster.Add(student.Id, student);
                Console.WriteLine("Student: {0}, {1} was successfully added to the {2} class.", student.Id, student.Name, CourseName);
            }
            else
                Console.WriteLine("Operation could not be completed {0} already registered", student.Id);
        }

        public void RemoveStudent(Student student)
        {
            if(courseRoster.ContainsKey(student.Id))
            {
                courseRoster.Remove(student.Id);
                Console.WriteLine("Student was successfully removed from {0} course roster.", CourseName);
            } else
            {
                Console.WriteLine("Action could not be performed. Student was not found with ID {0}", student.Id);
            }
        }
    }
}
