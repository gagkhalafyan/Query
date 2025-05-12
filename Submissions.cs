using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Tasks
{
    internal class Submissions
    {
        public int StudentId {  get; set; }
        public string AssignmentName { get; set; }
        public Submissions(int  studentId, string assignmentName)
        {
            StudentId = studentId;
            AssignmentName = assignmentName;
        }
    }
}
