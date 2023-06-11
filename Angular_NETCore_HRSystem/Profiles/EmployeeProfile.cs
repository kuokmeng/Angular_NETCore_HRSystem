using Angular_ASPNETCore_CustomersService.Models;
using AutoMapper;

namespace Angular_ASPNETCore_CustomersService.Controllers
{
  public class EmployeeProfile : Profile
  {
    public EmployeeProfile()
    {
      CreateMap<Customer, EmployeeDto>();
    }
  }
}
