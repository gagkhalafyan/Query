using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Tasks
{
    internal class Enrollments
    {
        public int StudentId {  get; set; }
        public int CourseId {  get; set; }
        public Enrollments(int  studentId, int courseId)
        {
            StudentId = studentId;
            CourseId = courseId;
        }
    }
}
