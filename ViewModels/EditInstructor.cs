using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PracticeTest.Models;

public class EditInstructor
{

    [Display(Name = "Last Name")]
    [Required, StringLength(50)]
    [RegularExpression(@"^[A-Z][a-zA-Z]*$", ErrorMessage = "Must start with capital letter")]
    public string LastName { get; set; }

    [Display(Name = "FirstMid Name")]
    [Required, StringLength(50)]
    [RegularExpression(@"^[A-Z][a-zA-Z]*$", ErrorMessage = "Must start with capital letter")]
    public string FirstMidName { get; set; }

    public DateOnly HireDate { get; set; }

}
