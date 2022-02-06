using System.ComponentModel.DataAnnotations;

namespace PracticeTest.Models;

public class InstructorsCourses
{
  public Instructor Instructor {get; set;}
  public List<Course> Courses {get; set;}
}