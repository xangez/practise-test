using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PracticeTest.Models;

public class OfficeAssignment
{

    [Key]
    public int InstructorID { get; set; }

    [StringLength(50)]
    public string Location { get; set; }


}
