# Employee Management Blazor Server App

A complete Blazor Server application for managing employee data, using layered architecture and RESTful APIs.

---

## 🔧 Tech Stack

- **Frontend:** Blazor Server (.NET 7)
- **Backend:** ASP.NET Core Web API
- **Database:** SQL Server (via EF Core 7.0)
- **Mapping:** AutoMapper
- **Validation:** Data Annotations + Custom Validators
- **API Documentation:** Swagger (Swashbuckle)

---

## 📁 Project Structure

```text
Solution
│
├── EmployeeManagement.Models             # Shared domain models, enums, validators
│
├── EmployeeManagement.Api                # ASP.NET Core Web API for employees & departments
│   ├── Controllers                        # EmployeesController, DepartmentsController
│   ├── Models                             # Repositories & Interfaces
│   └── Program.cs                         # Configures services, AutoMapper, EF, etc.
│
├── EmployeeManagement.ServerApp          # Blazor Server UI project
│   ├── Pages                              # Razor pages (.razor), forms, data binding
│   ├── Services                           # HTTP services to call API
│   ├── Program.cs                         # Root configuration of Blazor app
│
├── ReusableBlazorComponents              # Custom components (e.g., CustomInputSelect)
│   └── CustomInputSelect.cs               # Parses dropdown int values properly
│
└── README.md                             # You're reading it

📦 Dependencies
Here are the key NuGet packages used:

<PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="12.0.0" />
<PackageReference Include="Microsoft.EntityFrameworkCore" Version="7.0.3" />
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="7.0.3" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="7.0.3" />
<PackageReference Include="Swashbuckle.AspNetCore" Version="5.0.0-rc2" />
<PackageReference Include="Swashbuckle.AspNetCore.Swagger" Version="6.5.0" />
<PackageReference Include="Swashbuckle.AspNetCore.SwaggerUI" Version="5.0.0-rc2" />

🧩 Features
CRUD operations for Employees and Departments

Search by name and gender

Custom form validation (email domain, confirm email)

AutoMapper integration for mapping Employee to EditEmployeeModel

Reusable Blazor components (e.g., CustomInputSelect)

RESTful APIs with proper error handling

Swagger UI for testing API endpoints

🧪 How to Run
Clone the repository:

git clone https://github.com/yourusername/EmployeeManagementApp.git
Update the connection string in appsettings.json.

Run the EF Core migrations (if needed):

dotnet ef database update
Start both the API and the Blazor Server app:


dotnet run --project EmployeeManagement.Api
dotnet run --project EmployeeManagement.ServerApp
Browse the Blazor app at:


https://localhost:5001
Swagger for the API is available at:


https://localhost:5001/swagger

✨ Custom Validators
This project includes:

EmailDomainValidator: Ensures email belongs to a specified domain.

CompareProperty: Confirms email and confirmation email fields match.

🧱 Notes
.NET 7.0 target framework

Blazor Server App model

IEmployeeRepository and IDepartmentRepository handle all business logic/data access.

API is separated cleanly from UI logic.
