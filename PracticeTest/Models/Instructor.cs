using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PracticeTest.Models;

public class Instructor
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int ID { get; set; }

    [Display(Name = "Last Name")]
    [Required, StringLength(50)]
    [RegularExpression(@"^[A-Z][a-zA-Z]*$", ErrorMessage = "Must start with capital letter")]
    public string LastName { get; set; }

    [Display(Name = "FirstMid Name")]
    [Required, StringLength(50)]
    [RegularExpression(@"^[A-Z][a-zA-Z]*$", ErrorMessage = "Must start with capital letter")]
    public string FirstMidName { get; set; }

    public string FullName { get; private set; }

    //Enrollment date must be of the format yyyy-mm-dd
    [Column(TypeName="date")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime HireDate { get; set; }

    public virtual List<Department> Departments { get; set; }

    public virtual OfficeAssignment OfficeAssignment { get; set; }

    public virtual List<CourseAssignment> CourseAssignments { get; set; }

}
