using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeData.Models.DBEntities
{
    //Class Employee
    public class Employee
    {
        //Propeties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public String firstName { get; set; }
        public String lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public String email { get; set; }
        public Double salary { get; set; }
    }
}
