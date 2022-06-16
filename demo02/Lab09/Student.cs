using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.Lab09 {
    internal class Student {
        public int Id { get; set; }
        public string Name { get; set; }
        public Course CurrentlyFollowingCourse { get; set; }

        public Student(int id, string name, Course currentlyFollowingCourse) {
            Id = id;
            Name = name;
            CurrentlyFollowingCourse = currentlyFollowingCourse;
        }
    }
}
