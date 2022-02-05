using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PracticeTest.Models;

public enum Grade
{
    A,
    B,
    C,
    D,
    E,
    F,
}

public class Enrollment
{
    public int EnrollmentID  { get; set; }

    public int CourseID { get; set; }

    public int StudentID { get; set; }

    public Grade Grade { get; set; }

}

