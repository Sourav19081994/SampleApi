using System.ComponentModel.DataAnnotations;

namespace SampleApi.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? Description { get; set; }
    }
}