using Microsoft.AspNetCore.Mvc;
using PracticeTest.Models;
using System.Diagnostics;
using PracticeTest.Models;
using PracticeTest.Data;

namespace PracticeTest.Controllers;
  public class CourseController : Controller
  {
    private readonly PracticeTestContext _context;

    public CourseController(PracticeTestContext context) => _context = context;


      public IActionResult Index()
      {
          var courses = _context.Courses;

          return View(courses);
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
          return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
  }
