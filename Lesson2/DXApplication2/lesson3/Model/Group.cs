using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class Group : Base
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public string Name { get; set; }
    }
}
