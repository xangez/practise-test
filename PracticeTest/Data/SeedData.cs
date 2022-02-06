using PracticeTest.Data;
using PracticeTest.Models;
using Newtonsoft.Json;


namespace PracticeTest.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        var context = serviceProvider.GetRequiredService<PracticeTestContext>();


        // Look for courses.
        if (context.Students.Any())
        {
            return; // DB has already been seeded.
        }


        const string format = "yyyy-MM-dd";

        //Adding Students
        context.Students.AddRange(
          new Student
          {
            ID = 1,
            LastName = "Potter",
            FirstMidName = "Harry",
            EnrollmentDate = DateTime.ParseExact("2022-01-01", format, null)
          },
          new Student
          {
            ID = 2,
            LastName = "Granger",
            FirstMidName = "Hermione",
            EnrollmentDate = DateTime.ParseExact("2022-01-02", format, null)
          },
          new Student
          {
            ID = 3,
            LastName = "Malfoy",
            FirstMidName = "Draco",
            EnrollmentDate = DateTime.ParseExact("2022-01-03", format, null)
          },
          new Student
          {
            ID = 4,
            LastName = "Weasley",
            FirstMidName = "Ron",
            EnrollmentDate = DateTime.ParseExact("2022-01-03", format, null)
          },
          new Student
          {
            ID = 5,
            LastName = "Lovegood",
            FirstMidName = "Luna",
            EnrollmentDate = DateTime.ParseExact("2022-01-03", format, null)
          }
        );

        context.Instructors.AddRange(
          new Instructor
          {
            ID = 1,
            LastName = "McGonagall",
            FirstMidName = "Minerva",
            HireDate = DateTime.ParseExact("2020-01-03", format, null)
          },
          new Instructor
          {
            ID = 2,
            LastName = "Lupin",
            FirstMidName = "Remus",
            HireDate = DateTime.ParseExact("2020-01-03", format, null)
          },
          new Instructor
          {
            ID = 3,
            LastName = "Snape",
            FirstMidName = "Severus",
            HireDate = DateTime.ParseExact("2020-01-03", format, null)
          },
          new Instructor
          {
            ID = 4,
            LastName = "Rubeus",
            FirstMidName = "Hagrid",
            HireDate = DateTime.ParseExact("2020-01-03", format, null)
          },
          new Instructor
          {
            ID = 5,
            LastName = "Trelawney",
            FirstMidName = "Sybill",
            HireDate = DateTime.ParseExact("2020-01-03", format, null)
          }
        );

        context.OfficeAssignments.AddRange(
          new OfficeAssignment
          {
            InstructorID = 1,
            Location = "westwing"
          },
           new OfficeAssignment
          {
            InstructorID = 2,
            Location = "eastwing"
          },
          new OfficeAssignment
          {
            InstructorID = 3,
            Location = "northwing"
          },
          new OfficeAssignment
          {
            InstructorID = 4,
            Location = "southwing"
          },
          new OfficeAssignment
          {
            InstructorID = 5,
            Location = "westwing"
          }

        );

        context.Departments.AddRange(
          new Department
          {
            DepartmentID = 1,
            Name = "Transfiguration",
            Budget = 1000m,
            StartDate = DateTime.ParseExact("2020-01-03", format, null),
            InstructorID = 1

          },
          new Department
          {
            DepartmentID = 2,
            Name = "Defence Against the Dark Arts",
            Budget = 1000m,
            StartDate = DateTime.ParseExact("2020-01-03", format, null),
            InstructorID = 2

          },
          new Department
          {
            DepartmentID = 3,
            Name = "Potions",
            Budget = 1000m,
            StartDate = DateTime.ParseExact("2020-01-03", format, null),
            InstructorID = 3

          },
          new Department
          {
            DepartmentID = 4,
            Name = "Care of Magical Creatures",
            Budget = 1000m,
            StartDate = DateTime.ParseExact("2020-01-03", format, null),
            InstructorID = 4

          },
           new Department
          {
            DepartmentID = 5,
            Name = "Divination",
            Budget = 1000m,
            StartDate = DateTime.ParseExact("2020-01-03", format, null),
            InstructorID = 5

          }
        );


        context.Courses.AddRange(
          new Course
          {
              CourseID = 1,
              Title = "Course 1",
              Credits = 2,
              DepartmentID = 1
          },
           new Course
           {
              CourseID = 2,
               Title = "Course 2",
               Credits = 2,
               DepartmentID = 2
           },
          new Course
          {
            CourseID = 3,
              Title = "Course 3",
              Credits = 2,
              DepartmentID = 3
          },
          new Course
          {
            CourseID = 4,
              Title = "Course 4",
              Credits = 4,
              DepartmentID = 4
          },
          new Course
          {
            CourseID = 5,
              Title = "Course 5",
              Credits = 4,
              DepartmentID = 5
          }

        );

        context.CourseAssignments.AddRange(
          new CourseAssignment
          {
              CourseID = 1,
              InstructorID = 1,
          },
          new CourseAssignment
          {
              CourseID = 2,
              InstructorID = 2,
          },
          new CourseAssignment
          {
              CourseID = 3,
              InstructorID = 3,
          },
          new CourseAssignment
          {
              CourseID = 4,
              InstructorID = 4,
          },
          new CourseAssignment
          {
              CourseID = 5,
              InstructorID = 5,
          }

        );

        context.Enrollments.AddRange(
          new Enrollment
          {
              CourseID = 1,
              StudentID = 1,
          },
          new Enrollment
          {
              CourseID = 2,
              StudentID = 2,
          },
          new Enrollment
          {
              CourseID = 3,
              StudentID = 3,
          },
          new Enrollment
          {
              CourseID = 4,
              StudentID = 4,
          },
          new Enrollment
          {
              CourseID = 5,
              StudentID = 5,
          }

        );
        

        context.SaveChanges();
    }
}