using Applied5.Models;
using System.ComponentModel.DataAnnotations;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Applied5.Models
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        [ManyToMany(typeof(StudentCourse))]
        public List<Course> Courses { get; set; }
    }
}