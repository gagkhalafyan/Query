using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Tasks
{
    internal class Courses
    {
        public int Id {  get; set; }
        public string CourseName { get; set; }
        public int Difficulty {  get; set; }
        public Courses(int  id, string courseName, int difficulty)
        {
            Id = id;
            CourseName = courseName;
            Difficulty = difficulty;
        }
    }
}
