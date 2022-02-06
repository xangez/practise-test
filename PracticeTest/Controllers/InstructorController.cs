using Microsoft.AspNetCore.Mvc;
using PracticeTest.Models;
using System.Diagnostics;
using PracticeTest.Models;
using PracticeTest.Data;

namespace PracticeTest.Controllers;
  public class InstructorController : Controller
  {
    private readonly PracticeTestContext _context;

    public InstructorController(PracticeTestContext context) => _context = context;


      public IActionResult Index()
      {
          var intructors = _context.Instructors;

          return View(intructors);
      }

      public async Task<IActionResult> InstructorsCourses(int ID) 
      {
        List<CourseAssignment> courseAssignments = _context.CourseAssignments.Where(x => x.InstructorID == ID).ToList();
        List<Course> courses = new List<Course>();
        
        foreach (CourseAssignment courseAssignment in courseAssignments)
        {
          courses.Add(await _context.Courses.FindAsync(courseAssignment.CourseID));
        }

        InstructorsCourses instructorsCourses = new InstructorsCourses
        {
          Instructor = await _context.Instructors.FindAsync(ID),
          Courses = courses

        };
        return View(instructorsCourses);
      }

      public async Task<IActionResult> EditInstructor(int ID) 
      {
        Instructor instructor = await _context.Instructors.FindAsync(ID);

        return View(instructor);
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
          return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }

  }
