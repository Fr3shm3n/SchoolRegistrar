using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistrar
{
    internal class StudentIdComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
