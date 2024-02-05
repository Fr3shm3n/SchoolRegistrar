using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistrar
{
    internal interface ICourseActions
    {
        public void AddStudent(Student student);
        public void RemoveStudent(Student student);
    }
}
