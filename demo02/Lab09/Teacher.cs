using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.Lab09 {
    internal class Teacher {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Course CurrentlyTeachingCourse { get; set; } //Has A

        public Teacher(string name, decimal salary, Course currentlyTeachingCourse) {
            Name = name;
            Salary = salary;
            CurrentlyTeachingCourse = currentlyTeachingCourse;
        }
    }
}
