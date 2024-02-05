using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistrar
{
    internal class CourseNameComparer : IComparer<Course>
    {
        public int Compare(Course x, Course y)
        {
            return x.CourseName.CompareTo(y.CourseName);
        }
    }
}
