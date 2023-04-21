using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.ApplicationCore.Model
{
    public class EmployeeTypeRequestModel
    {
        

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string TypeName { get; set; }
    }
}