using System.ComponentModel;

namespace EmployeeData.Models
{
    public class EmployeeViewModel
    {
        public int id { get; set; }

        [DisplayName("First Name")]
        public String firstName { get; set; }

        [DisplayName("Last Name")]
        public String lastName { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime dateOfBirth { get; set; }

        [DisplayName("E-mail")]
        public String email { get; set; }

        [DisplayName("Salary")]
        public Double salary { get; set; }

        [DisplayName("Name")]
        public String fullName
        {
            get { return firstName + " " + lastName; }
        }
    }
}
