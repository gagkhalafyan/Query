﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Tasks
{
    internal class Students
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public Students(int id,string name)
        {
            Id = id;
            Name = name;
        }
    }
}
