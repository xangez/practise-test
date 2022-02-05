using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PracticeTest.Models;

public class Student
{
    public int ID { get; set; }

    [Required, StringLength(50)]
    [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
    public string LastName { get; set; }  
      
    [Required, StringLength(50)]
    [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
    public string FirstMidName { get; set; }

    public string FullName { get; private set; }


    //Enrollment date must be of the format yyyy-mm-dd
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime EnrollmentDate { get; set; }

    public virtual List<Enrollment> Enrollments { get; set; }


}
