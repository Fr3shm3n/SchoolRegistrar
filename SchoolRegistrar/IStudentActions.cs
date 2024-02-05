using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistrar
{
    internal interface IStudentActions
    {
        public void AddCourse(Course c);
        public void DropCourse(Course c);

    }
}
