using AutoMapper;
using BlazorServerApp.Services;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace BlazorServerApp.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        [Inject]
        public IMapper Mapper { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee Employee { get; set; } = new Employee();
        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();

        public string DepartmentId { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            // Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            // Departments = (await DepartmentService.GetDepartments()).ToList();
            Mapper.Map(Employee, EditEmployeeModel);
            Employee employee = new Employee
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@pragimtech.com",
                DateOfBrith = new DateTime(1981, 12, 22),
                Gender = EmployeeManagement.Models.Gender.Female,
                Department = new Department { DepartmentId = 2, DepartmentName = "HR" },
                PhotoPath = "images/sam.jpg"
            };
            Employee = employee;
         
          // DepartmentId = Employee.DepartmentId.ToString();
        }
        /// <summary>
        /// In HandleValidSubmit() method, 
        /// EmployeeService.UpdateEmployee method updates the employee data in the underlying database 
        /// by calling REST API
        /// </summary>
        /// <returns></returns>
        protected async Task HandleValidSubmit()
        {
            //Mapper.Map(EditEmployeeModel, Employee);
            //var result = await EmployeeService.UpdateEmployee(Employee);
            //if (result != null)
            //{
            //    NavigationManager.NavigateTo("/"); //this method redirects the user to the list page after a successful update.
            //}
        }
    }
}
