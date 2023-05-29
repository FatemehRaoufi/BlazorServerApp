using BlazorServerApp.Services;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components; //Added Microsoft.AspNetCore.Components from Nuget, beacuse of using inheritance class: ComponentBase 
using Microsoft.AspNetCore.Components.Web; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Pages
{
    
    //This is a Componenet Class which it is used  by Component view(EmployeeLis.Razor inherited from this class (EmployeeListBase))
    //Parent Component Class
    public class EmployeeListBase : ComponentBase 
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        public bool ShowFooter { get; set; } = true;
        protected override async Task OnInitializedAsync()
        {
            //Employees = (await EmployeeService.GetEmployees()).ToList();
            LoadEmployees();

        }
        private void LoadEmployees()
        {
            
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "David@pragimtech.com",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = EmployeeManagement.Models.Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/john.png"
            };
            
            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@pragimtech.com",
                DateOfBrith = new DateTime(1981, 12, 22),
                Gender = EmployeeManagement.Models.Gender.Male,
                Department = new Department { DepartmentId = 2, DepartmentName = "HR" },
                PhotoPath = "images/sam.jpg"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@pragimtech.com",
                DateOfBrith = new DateTime(1979, 11, 11),
                Gender = EmployeeManagement.Models.Gender.Female,
                Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/mary.png"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@pragimtech.com",
                DateOfBrith = new DateTime(1982, 9, 23),
                Gender = EmployeeManagement.Models.Gender.Female,
                Department = new Department { DepartmentId = 3, DepartmentName = "Payroll" },
                PhotoPath = "images/sara.png"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    


    //............................................................
        protected string Coordinates { get; set; }
        protected string Name { get; set; } = "Tom";
        protected string Gender { get; set; } = "Male";
        protected string ButtonText { get; set; } = "Hide Footer";
        protected string Colour { get; set; } = "background-color:green";
        public string Description { get; set; } = string.Empty;
        protected void Mouse_Move(MouseEventArgs e)
        {
            Coordinates = $"X = {e.ClientX} Y = {e.ClientY}";
        }
       
        protected string CssClass { get; set; } = null;

        protected void Button_Click()
        {
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "HideFooter";
            }
            else
            {
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }
        //.......................................................
        protected int SelectedEmployeesCount { get; set; } = 0;

        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedEmployeesCount++;
            }
            else
            {
                SelectedEmployeesCount--;
            }
        }
        //.............................
    }
}