using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.Lab09 {
    internal class Course {
        public int Id { get; set; }
        private string name; 
        public string Name { get { return name; } set { name = value; } }

        public Course(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}
