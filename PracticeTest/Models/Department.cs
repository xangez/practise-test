using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PracticeTest.Models;

public class Department
{
    public int DepartmentID { get; set; }

    //Name (maximum = 50 characters, minimum length = 3)
    [Required, StringLength(50, MinimumLength = 3, 
            ErrorMessage = "Name must have min length of 3 and max Length of 50")]    
    public string Name { get; set; }

    [Column(TypeName = "money")]
    [DataType(DataType.Currency)]
    public decimal Budget { get; set; }

    //Start date must be of the format yyyy-mm-dd
    [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]  
    public DateTime StartDate { get; set; }
    

    public int InstructorID { get; set; }

    public virtual List<Course> Courses { get; set; }


}
