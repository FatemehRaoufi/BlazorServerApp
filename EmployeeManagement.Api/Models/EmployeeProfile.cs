using AutoMapper;  // Installed AutoMapper.Extensions.Microsoft.DependencyInjection from Nuget
using EmployeeManagement.Models;

//Added the code: builder.Services.AddAutoMapper(typeof(EmployeeProfile)); to Program.cs
namespace EmployeeManagement.Api.Models
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EditEmployeeModel>()
                .ForMember(dest => dest.ConfirmEmail,
                           opt => opt.MapFrom(src => src.Email));
            CreateMap<EditEmployeeModel, Employee>();
        }
    }
}

//Resource: https://www.pragimtech.com/blog/blazor/using-automapper-in-asp.net-core/