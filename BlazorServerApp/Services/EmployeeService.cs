using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components; //Added from Nuget
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http; //Added from Nuget for HttpClient
using System.Net.Http.Json;//Added from Nuget for HttpClientJsonExtensions
//Added: dotnet add package Microsoft.AspNetCore.Blazor.HttpClient --version 3.2.0-preview3.20168.3 by Nuget consol to found GetJsonAsync
//Source: https://www.nuget.org/packages/Microsoft.AspNetCore.Blazor.HttpClient/

//Notice:
/* To prevent from this Error: 
    "Cannot provide a value for property, There is no registered service of type [TypeName]"

    Should add this code: "builder.Services.AddSingleton<IEmployeeService,EmployeeService>();" to Program.cs
*/
namespace BlazorServerApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;
       
        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Employee> GetEmployee(int id=0)
        {
            //var user = await client.GetJsonAsync<User>($"{BaseUrl}Get-User/{Id}");

            return await httpClient.GetFromJsonAsync<Employee>($"api/employees/{id}");
            
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {

            //HttpClient client = new HttpClient();
           

              return await httpClient.GetFromJsonAsync<Employee[]>("api/employees");

            //  return (IEnumerable<Employee>)employee;

        }

    }
}

//https://www.pragimtech.com/blog/blazor/call-rest-api-from-blazor/
