﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
   class Student : Base
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public string Name { get; set; }
        public Group Group { get; set; }
        public string MobileNumber { get; set; }
    }
}
