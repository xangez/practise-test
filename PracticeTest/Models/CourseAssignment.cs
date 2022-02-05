using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PracticeTest.Models;

public class CourseAssignment
{
    public int CourseID { get; set; }

    public int InstructorID { get; set; }

}
