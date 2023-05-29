using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Pages
{
    //Child Component Class that call in EmployeeList
    public class ChildEmployeeListBase : ComponentBase
    {        
        protected bool IsSelected { get; set; }

        [Parameter]
        public EventCallback<bool> OnEmployeeSelection { get; set; }

        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            IsSelected = (bool)e.Value;
            await OnEmployeeSelection.InvokeAsync(IsSelected);
        }
        //.............................................................
       

    }
}

/*Source:https://www.pragimtech.com/blog/blazor/blazor-component-parameters/ */