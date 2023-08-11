using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applied5.Models
{
    internal class StudentCourse
    {
        [PrimaryKey, AutoIncrement]
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public decimal Mark { get; set; }
    }
}

