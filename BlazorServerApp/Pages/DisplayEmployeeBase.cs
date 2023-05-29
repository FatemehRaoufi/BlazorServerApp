using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Pages
{
    //Child Component Class
    public class DisplayEmployeeBase : ComponentBase
    {
        [Parameter]
        public Employee Employee { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }

        //.......................
       
       

    }
}

/*Source:https://www.pragimtech.com/blog/blazor/blazor-component-parameters/ */