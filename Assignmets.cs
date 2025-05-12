using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Tasks
{
    internal class Assignmets
    {
        public int StudendId {  get; set; }
        public string AssName { get; set; }
        public int Score { get; set; }
        public Assignmets(int id, string assName, int score)
        {
            StudendId = id;
            AssName = assName;
            Score = score;
        }
    }
}
