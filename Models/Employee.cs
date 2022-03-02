using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EmployeeDetails.Models
{
    public class Employee
    {


        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(150)]
        public string Name { get; set; } = "";

        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = "";

        [Required]
        [StringLength(150)]
        public string Project { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string Experience { get; set; } = "";
    }
}
