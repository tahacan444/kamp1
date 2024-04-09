using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamp1.Entities;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Created { get; set; }
    = DateTime.Now;
    public DateTime Updated { get; set; }
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string CourseDescription { get; set; }

    public double Price { get; set; }
    


}
    