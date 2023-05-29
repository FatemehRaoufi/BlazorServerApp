using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

//Added this nuget: Microsoft.AspNetCore.Components.DataAnnotations.Validation
// by this code in nuget consol:
// NuGet\Install-Package Microsoft.AspNetCore.Components.DataAnnotations.Validation -Version 3.2.0-rc1.20223.4

namespace EmployeeManagement.Models
{
    public class EditEmployeeModel
    {
        public string Email { get; set; }

        [CompareProperty("Email",
            ErrorMessage = "Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }

        // Other properties:

        

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public int? DepartmentId { get; set; }
        public string PhotoPath { get; set; }
        public Department Department { get; set; } = new Department();


    }
}

//Resource: https://www.pragimtech.com/blog/blazor/compare-validation-in-blazor/
//https://www.nuget.org/packages/Microsoft.AspNetCore.Components.DataAnnotations.Validation
