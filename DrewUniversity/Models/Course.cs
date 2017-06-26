using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrewUniversity.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
