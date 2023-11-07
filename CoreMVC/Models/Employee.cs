using System.ComponentModel.DataAnnotations;

namespace CoreMVC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Address { get; set; }

        [Required]
        [MaxLength(100)]
        public string? CompanyName { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Designation { get; set; }
     

    }
}
