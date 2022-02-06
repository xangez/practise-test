using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PracticeTest.Models;

public class Course
{
    public int CourseID { get; set; }


    [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must have min length of 3 and max Length of 50")]
    public string Title { get; set; }

    [Range(0,5)]
    public int Credits { get; set; }

    public int DepartmentID { get; set; }

}
