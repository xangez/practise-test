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

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
          return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
  }
