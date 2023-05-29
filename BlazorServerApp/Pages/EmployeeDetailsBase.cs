
    using BlazorServerApp.Services;
    using EmployeeManagement.Models; 
    //using global::EmployeeManagement.Models;
    using Microsoft.AspNetCore.Components;
    using System.Threading.Tasks;

    namespace BlazorServerApp.Pages
    {
        public class EmployeeDetailsBase : ComponentBase
        {
            public Employee Employee { get; set; } = new Employee();

            [Inject]
            public IEmployeeService EmployeeService { get; set; }

            [Parameter]
            public string Id { get; set; }

            protected async override Task OnInitializedAsync()
            {
                Id = Id ?? "1";
                Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            }
        }
    }




